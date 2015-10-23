var viewModel;
var oTable;


$(function () {

    function loadSubmittedStates() {
        viewModel.applicantstates.removeAll();
        viewModel.applicantcities.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Admin/GetSubmittedStates',
            data: JSON.stringify({ acquisitionid: selectedid, finalselection: true }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.applicantstates.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    viewModel = {
        searchcriteria: {
            category: ko.observable(''),
            name: ko.observable(''),
            icno: ko.observable(''),
            acqlocation: ko.observable(''),
            state: ko.observable(''),
            city: ko.observable(''),
            finalselectionlocid: ko.observable(''),
        },
        candidates: ko.observableArray([]),
        processcandidates: ko.observableArray([]),
        rejectcandidates: ko.observableArray([]),
        announcement: ko.mapping.fromJS(announcement),
        setloccandidates: ko.observableArray([]),
        applicantstates: ko.observableArray([]),
        applicantcities: ko.observableArray([]),
        acqlocations: ko.observableArray([]),
        selectedlocation: ko.observable(''),
        startdate: ko.observable(''),
        enddate: ko.observable(''),
        selectime: ko.observable(''),
        reportsuppdoc: ko.mapping.fromJS(reportsuppdoc),
        reportsuppdocori: ko.mapping.fromJS(reportsuppdocori),
        selectedservice: ko.observable(''),
        search: function (d) {
            oTable = $('#applicant_table').dataTable({
                "sDom": "<'row table-top-control'<'col-md-6 hidden-xs per-page-selector'l><'col-md-6 text-right'f>r>t<'row table-bottom-control'<'col-md-6'i><'col-md-6 text-right'p>>",
                "oLanguage": { "sLengthMenu": "_MENU_ &nbsp; rekod per muka surat", "sProcessing": loadingdatatable, "sSearch": "Carian Nama/No Kad Pengenalan", "sInfo": "Memaparkan _START_ hingga _END_ daripada _TOTAL_ rekod" },
                "bJQueryUI": false,
                "bPaginate": true,
                "sPaginationType": "bootstrap",
                "bFilter": true,
                "bProcessing": true,
                "bDestroy": true,
                "bServerSide": true,
                "sAjaxSource": server + '/Admin/LoadToUpdateApplicant?category=' + ko.mapping.toJS(viewModel.searchcriteria.category) + "&name=" + ko.mapping.toJS(viewModel.searchcriteria.name) + "&icno=" + ko.mapping.toJS(viewModel.searchcriteria.icno) + "&acquisitionid=" + selectedid + "&firstselection=true",
                "fnDrawCallback": function (oSettings) {
                    /* Need to redo the counters if filtered or sorted */
                    //if (oSettings.bSorted || oSettings.bFiltered) {
                    for (var i = 0, iLen = oSettings.aiDisplay.length; i < iLen; i++) {
                        $('td:eq(0)', oSettings.aoData[oSettings.aiDisplay[i]].nTr).html(i + 1);
                    }
                    //}
                },
                "aoColumns": [
                                { "bSortable": false },
                                { "bSortable": true },
                                { "bSortable": true },
                                { "bSortable": false },
                                {
                                    "bSortable": false,
                                    "sClass": "text-middle text-center",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="radio" app-data="true" name="firstselection' + id + '" class="check-row-approve" id="cba_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Lulus Temuduga/Pemilihan Akhir</span> </label>';
                                    }
                                },
                                {
                                    "bSortable": false,
                                    "sClass": "text-middle text-center",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="radio" pro-data="true" name="firstselection' + id + '" class="check-row-process" id="cbp_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Sedang Diproses</span> </label>';
                                    }
                                },
                                {
                                    "bSortable": false,
                                    "sClass": "text-middle text-center",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="radio" reject-data="true" name="firstselection' + id + '" class="check-row-reject" id="cbr_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Tidak Lulus Ke Temuduga/Pemilihan Akhir</span> </label>';
                                    }
                                }
                ],
                "fnCreatedCell": function (cell) {
                    $('input', cell).click(function (event) {
                        event.preventDefault();
                    });
                }
            });
        },
        searchselected: function () {
            oTable = $('#selectedapplicant_table').dataTable({
                "sDom": "<'row table-top-control'<'col-md-6 hidden-xs per-page-selector'l><'col-md-6 text-right'f>r>t<'row table-bottom-control'<'col-md-6'i><'col-md-6 text-right'p>>",
                "oLanguage": { "sLengthMenu": "_MENU_ &nbsp; rekod per muka surat", "sProcessing": loadingdatatable, "sSearch": "Carian Nama/No Kad Pengenalan", "sInfo": "Memaparkan _START_ hingga _END_ daripada _TOTAL_ rekod" },
                "bJQueryUI": false,
                "bPaginate": true,
                "sPaginationType": "bootstrap",
                "bFilter": true,
                "bProcessing": true,
                "bDestroy": true,
                "bServerSide": true,
                "sAjaxSource": server + '/Admin/LoadSubmittedApplicant?category=' + ko.mapping.toJS(viewModel.searchcriteria.category) + '&acquisitionid=' + selectedid + '&finalselection=true&statecode=' + ko.mapping.toJS(viewModel.searchcriteria.state) + '&citycode=' + ko.mapping.toJS(viewModel.searchcriteria.city) + '&reportdutylocid=' + ko.mapping.toJS(viewModel.searchcriteria.finalselectionlocid),
                "fnDrawCallback": function (oSettings) {
                    /* Need to redo the counters if filtered or sorted */
                    //if (oSettings.bSorted || oSettings.bFiltered) {
                    for (var i = 0, iLen = oSettings.aiDisplay.length; i < iLen; i++) {
                        $('td:eq(0)', oSettings.aoData[oSettings.aiDisplay[i]].nTr).html(i + 1);
                    }
                    //}
                },
                "aoColumns": [
                                { "bSortable": false },
                                { "bSortable": true },
                                { "bSortable": true },
                                { "bSortable": false },
                                { "bSortable": false },
                                { "bSortable": false },
                                {
                                    "bSortable": false,
                                    "sClass": "text-middle text-center",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="checkbox" name="setloc' + id + '" setloc-data="true" class="check-row-setloc" id="cbs_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Pilih</span> </label>';
                                    }
                                }
                ],
                "fnCreatedCell": function (cell) {
                    $('input', cell).click(function (event) {
                        event.preventDefault();
                    });
                }
            });
        },
        cancel: function () {
            location.href = server + "/Home/";
        },
        submit: function () {
            viewModel.candidates.removeAll();
            $("input:checked", oTable.fnGetNodes()).each(function () {
                if ($(this).attr('app-data')) {
                    viewModel.candidates.push($(this).val());
                }

                if ($(this).attr('reject-data')) {
                    viewModel.rejectcandidates.push($(this).val());
                }

                if ($(this).attr('pro-data')) {
                    viewModel.processcandidates.push($(this).val());
                }
            });

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ candidates: ko.mapping.toJS(viewModel.candidates), rejectcandidates: ko.mapping.toJS(viewModel.rejectcandidates), processcandidates: ko.mapping.toJS(viewModel.processcandidates) }),
                url: server + '/Admin/SubmitLastSelection',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        $("#selectall_shortlist").prop("checked", false);
                        $("#selectall_reject").prop("checked", false);
                        $("#selectall_process").prop("checked", false);
                        viewModel.search();
                    }
                    hideLoading();
                    ShowMessage(msg.message);
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        },
        submitselectedlocation: function () {
            viewModel.setloccandidates.removeAll();

            $("input:checked", oTable.fnGetNodes()).each(function () {
                if ($(this).attr('setloc-data')) {
                    viewModel.setloccandidates.push($(this).val());
                }
            });

            var sdate = $('#startdate').data('date');
            if (sdate !== null && sdate !== undefined) {
                var splitdate = sdate.split("/");
                sdate = splitdate[1] + "/" + splitdate[0] + "/" + splitdate[2];
                viewModel.startdate(sdate);
            }

            var edate = $('#enddate').data('date');
            if (edate !== null && edate !== undefined) {
                var splitdate = edate.split("/");
                edate = splitdate[1] + "/" + splitdate[0] + "/" + splitdate[2];
                viewModel.enddate(edate);
            }

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ candidates: ko.mapping.toJS(viewModel.setloccandidates), selectedlocation: ko.mapping.toJS(viewModel.selectedlocation), startdate: ko.mapping.toJS(viewModel.startdate), enddate: ko.mapping.toJS(viewModel.enddate), selectime: ko.mapping.toJS(viewModel.selectime), selectedservice: ko.mapping.toJS(viewModel.selectedservice) }),
                url: server + '/Admin/SubmitReportDutySetLocation',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        $("#selectall_setloc").prop("checked", false);
                        viewModel.searchselected();
                        loadSubmittedStates();
                    }
                    hideLoading();
                    ShowMessage(msg.message);
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        },
        uploaddocument: function () {
            $("#upload_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#filuploadname').val('');
            $('#progressbar').attr('aria-valuenow', '0');
            $('#progressbar').attr('aria-valuemin', '0');
            $('#progressbar').width(0);
            fileupload = $('#filetoupload').fileupload({
                dataType: 'json',
                url: server + '/Upload/Upload',
                limitConcurrentUploads: 1,
                sequentialUploads: true,
                progressInterval: 100,
                formData: { uploadtype: 'ACQDOCRD', acquisitionid: selectedid },
                add: function (e, data) {
                    data.context = $('#fileuploadbutton')
                        .click(function () {
                            data.submit();
                        });
                },
                done: function (e, data) {
                    var result = ko.mapping.toJS(data.result);
                    if (result.OK) {
                        var docs = ko.mapping.fromJSON(result.item);
                        viewModel.reportsuppdocori(docs.DocumentName());
                    } else {
                        ShowMessage(result.message);
                    }
                    $('#upload_dialog').modal('hide');

                }
            }).on('fileuploadadd', function (e, data) {
                $.each(data.files, function (index, file) {
                    $('#filuploadname').val(file.name);
                });
            }).on('fileuploadprogressall', function (e, data) {
                var progress = parseInt(data.loaded / data.total * 100, 10);
                $('#progressbar').css('width', progress + '%');
            });
        },
        downloaddoc: function (d) {
            window.open(server + "/SuppDoc/" + viewModel.reportsuppdoc(), "DownloadDoc", null, true);
        },
        print: function () {
            window.open(server + "/Admin/PrintReportDutyList", "PrintFinalInvite", null, true);
        }
    };

    function loadSubmittedCities(state) {
        viewModel.applicantcities.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Admin/GetSubmittedCities',
            data: JSON.stringify({ acquisitionid: selectedid, statecode: state, finalselection: true }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.applicantcities.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    viewModel.searchcriteria.state.subscribe(function (d) {
        if (d) {
            loadSubmittedCities(d);
        }
    });

    ko.applyBindings(viewModel);
    viewModel.search();

    function loadReportDutyLocation() {
        viewModel.acqlocations.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetReportDutyLocations',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.acqlocations.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    $("#selectall_shortlist").change(function () {
        $("#selectall_reject").prop("checked", false);
        $("#selectall_process").prop("checked", false);
        if ($(this).is(":checked")) {
            $('.check-row-approve').prop("checked", true);
        } else {
            $('.check-row-approve').prop("checked", false);
        }
    });

    $("#selectall_reject").change(function () {
        $("#selectall_shortlist").prop("checked", false);
        $("#selectall_process").prop("checked", false);
        if ($(this).is(":checked")) {
            $('.check-row-reject').prop("checked", true);
        } else {
            $('.check-row-reject').prop("checked", false);
        }
    });

    $("#selectall_process").change(function () {
        $("#selectall_shortlist").prop("checked", false);
        $("#selectall_reject").prop("checked", false);
        if ($(this).is(":checked")) {
            $('.check-row-process').prop("checked", true);
        } else {
            $('.check-row-process').prop("checked", false);
        }
    });

    $("#selectall_setloc").change(function () {
        if ($(this).is(":checked")) {
            $('.check-row-setloc').prop("checked", true);
        } else {
            $('.check-row-setloc').prop("checked", false);
        }
    });

    $('input[name="search"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.searchcriteria.category(selectedval);
    });

    $('input[name="service"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.selectedservice(selectedval);
    });

    $('#startdate').datetimepicker({
        format: 'DD/MM/YYYY'
    });

    loadReportDutyLocation();
    loadSubmittedStates();
});