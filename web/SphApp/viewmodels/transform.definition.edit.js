﻿/// <reference path="../../Scripts/jquery-2.1.3.intellisense.js" />
/// <reference path="../../Scripts/knockout-3.2.0.debug.js" />
/// <reference path="../../Scripts/knockout.mapping-latest.debug.js" />
/// <reference path="../../Scripts/require.js" />
/// <reference path="../../Scripts/underscore.js" />
/// <reference path="../../Scripts/moment.js" />
/// <reference path="../../Scripts/.js" />
/// <reference path="../services/datacontext.js" />
/// <reference path="../schemas/trigger.workflow.g.js" />
/// <reference path="../../Scripts/jsPlumb/jsPlumb.js" />


define(["services/datacontext", "services/logger", objectbuilders.system, "ko/_ko.mapping", objectbuilders.app, objectbuilders.router],
    function (context, logger, system, koMapping, app, router) {

        var td = ko.observable(new bespoke.sph.domain.TransformDefinition({ Id: "0" })),
            functoidToolboxItems = ko.observableArray(),
            originalEntity = "",
            errors = ko.observableArray(),
            isBusy = ko.observable(false),
            sourceMember = ko.observable(),
            sourceSchema = ko.observable(),
            destinationSchema = ko.observable(),
            activate = function (id) {
                id = id || "0";
                if (id === "0") {
                    td(new bespoke.sph.domain.TransformDefinition({ Name: "New Mapping Definition", WebId: system.guid() }));
                    return true;
                }



                var query = String.format("Id eq '{0}'", id);
                return $.get("/transform-definition/functoids")
                            .then(function (list) {
                                functoidToolboxItems(list.$values);
                                return context.loadOneAsync("TransformDefinition", query);
                            })
                            .then(function (b) {

                                _(b.FunctoidCollection()).each(function (v) {
                                    v.designer = ko.observable({ FontAwesomeIcon: "", "BootstrapIcon": "", "PngIcon": "", Category: "" });
                                });
                                td(b);
                                originalEntity = ko.toJSON(td);
                                return context.get("/transform-definition/json-schema/" + b.OutputTypeName());

                            })
                            .then(function (s) {
                                destinationSchema(s);
                                if (td().InputTypeName()) {
                                    return context.get("/transform-definition/json-schema/" + td().InputTypeName());
                                }
                                return context.post(ko.toJSON(td), "/transform-definition/json-schema");

                            })
                            .then(sourceSchema)
                            .fail(function (a, b, text) {
                                console.error(a);
                                // console.error(b);
                                logger.error(text);
                            });

            },
            isJsPlumbReady,
            jsPlumbInstance = null,
            initializeFunctoid = function (fnc) {
                var element = $("#" + fnc.WebId());
                jsPlumbInstance.makeSource(element, {
                    filter: ".fep",
                    endPoint: ["Rectangle", { width: 10, height: 10 }],
                    anchor: "RightMiddle",
                    connector: ["Straight"],
                    connectorStyle: { strokeStyle: "#5c96bc", lineWidth: 2, outlineColor: "transparent", outlineWidth: 4 }
                });

                var anchorOptions = ["LeftMiddle", "LeftTop", "LeftBottom"];
                if (fnc.ArgumentCollection().length) {
                    jsPlumbInstance.makeTarget(element, {
                        dropOptions: { hoverClass: "dragHover" },
                        anchors: anchorOptions,
                        maxConnections: fnc.ArgumentCollection().length,
                        onMaxConnections: function (info, e) {
                            alert("Maximum connections (" + info.maxConnections + ") reached" + e);
                        }
                    });
                }
                jsPlumbInstance.draggable(element);
            },
            toolboxItemDraggedStop = function (arg) {
                if (!td().Id() || td().Id() === "0") {
                    logger.error("Please save your mapping definition before using functoid!!");
                    return;
                }

                var functoid = context.toObservable(ko.mapping.toJS(ko.dataFor(this).functoid)),
                    x = arg.clientX,
                    y = arg.clientY,
                    canvas = $("#container-canvas"),
                    offset = canvas.offset(),
                    canvasWidth = parseFloat(canvas.css("width").replace("px", ""));

                if (x > (offset.left + canvasWidth)) {
                    logger.error("Please drop the functoid inside the mapping designer box");
                    return;
                }

                functoid.designer = ko.dataFor(this).designer;
                functoid.X(x - offset.left + $(window).scrollLeft());
                functoid.Y(y - offset.top + $(window).scrollTop());
                functoid.WebId(system.guid());
                td().FunctoidCollection.push(functoid);

                setTimeout(function () {
                    initializeFunctoid(functoid);
                }, 500);
            },
            jsPlumbReady = function () {
                isJsPlumbReady = true;

                var instance = jsPlumb.getInstance({
                    Endpoint: ["Rectangle", { width: 10, height: 10 }],
                    HoverPaintStyle: { strokeStyle: "#1e8151", lineWidth: 2 },
                    ConnectionOverlays: [
                        ["Arrow", {
                            location: 1,
                            id: "arrow",
                            length: 14,
                            foldback: 0.8
                        }]
                    ],
                    Container: "container-canvas"
                });
                jsPlumbInstance = instance;

                //instance.draggable(windows);

                instance.bind("click", function (c) {
                    instance.detach(c);
                    if (c.map) {
                        td().MapCollection.remove(c.map);
                    }

                    if (typeof c.functoidArg === "function") {
                        c.functoidArg(null);
                    }
                    td().FunctoidCollection.remove(c.sf);

                });

                var connectionInitialized = false;
                instance.bind("connection", function (info) {
                    if (!connectionInitialized) {
                        return;
                    }

                    // direct map
                    if (info.sourceId.indexOf("source-field-") > -1 && info.targetId.indexOf("destination-field-") > -1) {
                        var sourceField2 = info.sourceId.replace("source-field-", "").replace("-", "."),
                            destinationField2 = info.targetId.replace("destination-field-", "").replace("-", ".");

                        var dm = new bespoke.sph.domain.DirectMap({ Source: sourceField2, Destination: destinationField2, WebId: system.guid() });
                        td().MapCollection.push(dm);
                        info.connection.map = dm;
                    }
                    //  functoid map
                    if (info.targetId.indexOf("destination-field-") > -1 && info.sourceId.indexOf("source-field-") < 0) {
                        var destinationField = info.targetId.replace("destination-field-", "").replace("-", ".");

                        var fm = new bespoke.sph.domain.FunctoidMap({ Destination: destinationField, WebId: system.guid() });
                        fm.Functoid(info.sourceId);
                        td().MapCollection.push(fm);
                        info.connection.map = fm;
                    }


                    var selectArg = function (sourceFunctoid, targetFunctoid) {

                        var tcs = new $.Deferred();
                        // for those with more than 1 arg, if array or 1 arg, just auto add or select
                        require(["viewmodels/functoid-args", "durandal/app"], function (dialog, app2) {

                            dialog.functoid(targetFunctoid);
                            app2.showDialog(dialog)
                                .done(function (result) {
                                    if (!result) return;
                                    if (result === "OK") {
                                        var arg = _(targetFunctoid.ArgumentCollection()).find(function (v) {
                                            return ko.unwrap(v.Name) === dialog.arg();
                                        });
                                        arg.Functoid(ko.unwrap(sourceFunctoid.WebId));
                                        info.connection.sf = sourceFunctoid;

                                        info.connection.setLabel(dialog.arg());
                                    }
                                    tcs.resolve(result);
                                });

                        });

                        return tcs.promise();
                    };
                    // source field functoid
                    if (info.sourceId.indexOf("source-field-") > -1 && info.targetId.indexOf("destination-field-") < 0) {
                        var sourceField = info.sourceId.replace("source-field-", "").replace(/-/g, "."),
                            targetFnc2 = ko.dataFor(document.getElementById(info.targetId));

                        var sourceFnc2 = new bespoke.sph.domain.SourceFunctoid({ Field: sourceField, WebId: system.guid() });

                        selectArg(sourceFnc2, targetFnc2).done(function (result) {
                            if (result === "OK") {
                                td().FunctoidCollection.push(sourceFnc2);
                            } else {
                                instance.detach(info.connection);
                            }
                        });

                    }


                    // functoid- functoid
                    if (info.sourceId.indexOf("source-field-") < 0 && info.targetId.indexOf("destination-field-") < 0) {
                        var sourceFnc = ko.dataFor(document.getElementById(info.sourceId)),
                            targetFnc = ko.dataFor(document.getElementById(info.targetId));

                        selectArg(sourceFnc, targetFnc);

                    }
                });



                var sourceWindows = jsPlumb.getSelector("#source-panel li.jstree-leaf");
                var targetWindows = jsPlumb.getSelector("#destination-panel li.jstree-leaf");

                // suspend drawing and initialise.
                instance.doWhileSuspended(function () {
                    instance.makeSource(sourceWindows, {
                            //filter: "li.jstree-leaf",
                            anchor: ["RightMiddle"],
                            connector: ["Straight"],
                            connectorStyle: { strokeStyle: "#5c96bc", lineWidth: 2, outlineColor: "transparent", outlineWidth: 4 }
                        });
                   

                });

                instance.makeTarget(targetWindows, {
                    //filter: "a.jstree-anchor",
                    dropOptions: { hoverClass: "dragHover" },
                    anchor: ["LeftMiddle"],
                    maxConnections: 1,
                    onMaxConnections: function (info, e) {
                        alert("Maximum connections (" + info.maxConnections + ") reached" + e);
                    }
                });


                var makeFunctoidElement = function (item) {
                    if (!item) {
                        return;
                    }
                    var tool = _(functoidToolboxItems()).find(function (v) {
                        return ko.unwrap(item.$type) === ko.unwrap(ko.unwrap(v.functoid).$type);
                    });
                    item.designer(tool.designer);

                    var element = document.getElementById(ko.unwrap(item.WebId));
                    instance.makeSource(element, {
                        filter: ".fep",
                        endPoint: ["Rectangle", { width: 10, height: 10 }],
                        anchor: "RightMiddle",
                        connector: ["Straight"],
                        connectorStyle: { strokeStyle: "#5c96bc", lineWidth: 2, outlineColor: "transparent", outlineWidth: 4 }
                    });
                    if (item.ArgumentCollection().length) {
                        instance.makeTarget(element, {
                            dropOptions: { hoverClass: "dragHover" },
                            anchor: ["LeftMiddle"],
                            maxConnections: item.ArgumentCollection().length,
                            onMaxConnections: function (info, e) {
                                alert("Maximum connections (" + info.maxConnections + ") reached" + e);
                            }
                        });
                    }
                    instance.draggable(element);
                };

                // functoids maps
                var fncContains = function (webid) {
                    var found = null;
                    _(td().FunctoidCollection()).each(function (f) {
                        _(f.ArgumentCollection()).each(function (m) {
                            if (ko.unwrap(m.Functoid) === ko.unwrap(webid)) {
                                found = ko.unwrap(f.WebId);
                            }
                        });
                    });
                    return found;
                };

                // create the source and target for each functoid
                _(td().FunctoidCollection()).each(function (f) {
                    if (ko.unwrap(f.$type) !== "Bespoke.Sph.Domain.SourceFunctoid, domain.sph") {
                        makeFunctoidElement(f);
                    }
                });

                // creates the connection for each argument list
                _(td().FunctoidCollection()).each(function (f) {
                    if (ko.unwrap(f.$type) !== "Bespoke.Sph.Domain.SourceFunctoid, domain.sph") {
                        _(f.ArgumentCollection()).each(function (a) {
                            var source = document.getElementById(ko.unwrap(a.Functoid));
                            if (typeof a.Functoid !== "function" || !source) {
                                return;
                            }
                            var conn = instance.connect({ source: source, target: ko.unwrap(f.WebId) });
                            conn.functoidArg = a.Functoid;
                        });
                    }
                });

                // for source to functoid
                _(td().FunctoidCollection()).each(function (f) {
                    if (ko.unwrap(f.$type) === "Bespoke.Sph.Domain.SourceFunctoid, domain.sph") {
                        var target = document.getElementById(fncContains(f.WebId));
                        if (!target) {
                            td().FunctoidCollection.remove(f);
                            return;
                        }
                        var conn = instance.connect({ source: "source-field-" + ko.unwrap(f.Field).replace(".", "-"), target: target });
                        conn.sf = f;

                    }
                });

                // direct maps
                _(td().MapCollection()).each(function (m) {
                    if (ko.unwrap(m.Source)) {
                        try {

                                var src = "source-field-" + ko.unwrap(m.Source).replace(".", "-"),
                                    target = "destination-field-" + ko.unwrap(m.Destination).replace(".", "-");

                                if(!document.getElementById(src))return;
                                if(!document.getElementById(target))return;

                                var conn = instance.connect({ source: src, target: target})
                                conn.map = m;
                            } catch (e) {
                                console.log("Cannot connect", ko.mapping.toJS(m));
                            }
                    }
                });
                // functoid maps
                _(td().MapCollection()).each(function (m) {
                    if (typeof m.Source === "undefined") {
                        var conn = instance.connect({ source: ko.unwrap(m.Functoid), target: "destination-field-" + ko.unwrap(m.Destination).replace(".", "-") });
                        conn.map = m;
                    }
                });


                connectionInitialized = true;

                jsPlumb.fire("jsPlumbDemoLoaded", instance);

            },
            attached = function () {

                $("ul#function-toolbox>li.list-group-item").draggable({
                    helper: function () {
                        return $("<div></div>").addClass("dragHoverToolbox").append($(this).find("i").clone());
                    },
                    stop: toolboxItemDraggedStop
                });


                var script = $("<script type=\"text/javascript\" src=\"/Scripts/jsPlumb/bundle.js\"></script>").appendTo("body"),
                    timer = setInterval(function () {
                        if (window.jsPlumb !== undefined) {
                            clearInterval(timer);
                            script.remove();

                            jsPlumb.ready(jsPlumbReady);
                        }
                    }, 1500);


                if (!td().OutputTypeName()) {
                    return;
                }
                var icon = function (item) {
                        var type = item.type,
                            format = item.format;
                        if (typeof type === "object") {
                            type = type[0];
                        }
                        if (format === "date-time") {
                            return "glyphicon glyphicon-calendar";
                        }
                        if (type === "string") {
                            return "glyphicon glyphicon-bold";
                        }
                        if (type === "integer") {
                            return "fa fa-sort-numeric-asc";
                        }
                        if (type === "object") {
                            return "fa fa-building-o";
                        }
                        if (type === "number") {
                            return "glyphicon glyphicon-usd";
                        }
                        if (type === "boolean") {
                            return "glyphicon glyphicon-ok";
                        }
                        if (type === "array") {
                            return "fa fa-list";
                        }
                        return "";
                    },
                    root = sourceSchema();

                var sources = [],
                    buildTree = function (side, branch, parent, items, parentNode) {
                        for (var key in branch.properties) {
                            if (branch.properties.hasOwnProperty(key)) {

                                var leaf = {
                                    id: side + parent + key ,
                                    icon : icon(branch.properties[key]),
                                    text: key
                                };
                                if(parentNode)
                                    leaf.parent = parentNode.id;
                                else
                                    leaf.parent = "#";

                                items.push(leaf);

                                var type = branch.properties[key].type;
                                if (typeof type === "object") {
                                    type = type[0];
                                }
                                if (type === "object") {
                                    buildTree(side, branch.properties[key], parent + key + "-", items, leaf);
                                }
                                if (type === "array") {
                                    buildTree(side, branch.properties[key].items, parent + key + "-", items, leaf);
                                }
                            }
                        }
                };

                buildTree("source-field-", root, "", sources);
                $("#source-panel").jstree({
                    'core': {
                        'data': sources
                    },
                    "plugins": ["search"]

                }).jstree("open_all");


                var destinations = [];
                buildTree("destination-field-", destinationSchema(), "", destinations);
                $("#destination-panel").jstree({
                    'core': {
                        'data': destinations
                    },
                    "plugins": ["search"]

                });
                $("#destination-panel li.jstree-leaf").addClass("target-item");

                $("#search-box-tree").on("keyup", function () {
                    var text = $(this).val().toLowerCase();
                    $("#source-panel li>span.source-field").each(function () {
                        var span = $(this),
                            li = span.parent(),
                            content = span.text().toLowerCase();
                        if (content.indexOf(text) < 0) {
                            li.hide();
                        } else {
                            li.show();
                        }

                    });
                });


            },
            save = function () {

                $("div.functoid").each(function () {
                    var fnt = ko.dataFor(this),
                        p = $(this),
                        x = parseInt(p.css("left")),
                        y = parseInt(p.css("top"));
                    if (!fnt) {
                        p.remove();
                    } else {
                        fnt.X(x);
                        fnt.Y(y);
                    }
                });
                var data = ko.mapping.toJSON(td);
                isBusy(true);


                return context.post(data, "/transform-definition")
                     .done(function (result) {
                         isBusy(false);
                         if (!td().Id() || td().Id() === "0") {
                             td().Id(result.id);
                             router.navigate("transform.definition.edit/" + result.id);
                         }

                         originalEntity = ko.toJSON(td);
                     });
            },
            canDeactivate = function () {
                var tcs = new $.Deferred();
                if (originalEntity !== ko.toJSON(td)) {
                    app.showMessage("Save change to the item", "Rx Developer", ["Yes", "No", "Cancel"])
                        .done(function (dialogResult) {
                            if (dialogResult === "Yes") {
                                save().done(function () {
                                    tcs.resolve(true);
                                });
                            }
                            if (dialogResult === "No") {
                                tcs.resolve(true);
                            }
                            if (dialogResult === "Cancel") {
                                tcs.resolve(false);
                            }

                        });
                } else {
                    return true;
                }
                return tcs.promise();
            },
            editProp = function () {

                var tcs = new $.Deferred(),
                    clone = context.toObservable(ko.mapping.toJS(td));
                require(["viewmodels/transform.definition.prop.dialog", "durandal/app"], function (dialog, app2) {
                    dialog.td(clone);

                    app2.showDialog(dialog)
                        .done(function (result) {
                            tcs.resolve(true);
                            $("div.modalBlockout,div.modalHost").remove();
                            if (!result) return;
                            if (result === "OK") {
                                for (var g in td()) {
                                    if (typeof td()[g] === "function" && (td()[g].name === "c" || td()[g].name === "observable")) {
                                        td()[g](ko.unwrap(clone[g]));
                                    } else {
                                        td()[g] = clone[g];
                                    }
                                }

                                // try build the tree for new item
                                if (!td().Id() || td().Id() === "0") {
                                    var inTask = context.post(ko.toJSON(td), "/transform-definition/json-schema"),
                                       outTask = context.get("/transform-definition/json-schema/" + td().OutputTypeName());
                                    $.when(inTask, outTask).done(function (input, output) {
                                        sourceSchema(input[0]);
                                        destinationSchema(output[0]);
                                        attached();
                                    });
                                }
                            }
                        });

                });

                return tcs.promise();
            },
            validateAsync = function () {
                var tcs = new $.Deferred();
                context.post(ko.mapping.toJSON(td), "/transform-definition/validate-fix")
                    .done(function (result) {
                        $("i.fa.fa-exclamation-circle.error").remove();
                        if (result.success) {
                            logger.info(result.message);
                            errors.removeAll();
                        } else {
                            logger.error("There are errors in your map, !!!");
                            var uniqueList = _.uniq(result.Errors, function (item, key, a) {
                                return item.ItemWebId;
                            });
                            errors(uniqueList);
                            _(uniqueList).each(function (v) {
                                $("#" + v.ItemWebId + " div.toolbox-item").append("<i class=\"fa fa-exclamation-circle error\"></i>");
                            });
                        }
                        tcs.resolve(true);

                    });

                return tcs.promise();
            },
            publishAsync = function () {
                return context.post(ko.mapping.toJSON(td), "/transform-definition/publish")
                    .done(function (result) {
                        if (result.success) {
                            logger.info(result.message);
                            errors.removeAll();
                            originalEntity = ko.toJSON(td);
                        } else {
                            errors(result.Errors);
                            logger.error("There are errors in your map, !!!");
                        }
                    });

            },
            generatePartialAsync = function () {
                return context.post(ko.mapping.toJSON(td), "/transform-definition/generate-partial")
                         .done(function (result) {
                             if (result.success) {
                                 logger.info(result.message);
                             } else {
                                 logger.error("You alread have the partial code define, in " + result.message);
                             }
                         });
            };

        var vm = {
            isBusy: isBusy,
            errors: errors,
            functoidToolboxItems: functoidToolboxItems,
            activate: activate,
            canDeactivate: canDeactivate,
            attached: attached,
            sourceMember: sourceMember,
            sourceSchema: sourceSchema,
            destinationSchema: destinationSchema,
            td: td,
            editProp: editProp,
            toolbar: {
                saveCommand: save,
                commands: ko.observableArray([
                    {
                        command: editProp,
                        caption: "Edit Properties",
                        icon: "fa fa-table"
                    },
                    {
                        command: validateAsync,
                        caption: "Validate",
                        icon: "fa fa-check"
                    },
                    {
                        command: publishAsync,
                        caption: "Publish",
                        icon: "fa fa-sign-out"
                    },
                    {
                        command: generatePartialAsync,
                        caption: "Generate Partial",
                        icon: "fa fa-code",
                        enable: ko.computed(function () {
                            if (ko.unwrap(td().Id) === "0") {
                                return false;
                            }
                            if (!ko.unwrap(td().Id)) {
                                return false;
                            }
                            return true;
                        })
                    }
                ])
            }
        };

        return vm;

    });
