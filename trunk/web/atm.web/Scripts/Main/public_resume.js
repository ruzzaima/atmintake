var viewModel;
var oTable;

$(function () {

    function loadCountry() {
        viewModel.countries.removeAll();
        $.ajax({
            type: 'POST',
            url: '/Common/GetCountries',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.countries.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadStates(countryid) {
        viewModel.states.removeAll();
        $.ajax({
            type: 'POST',
            url: '/Common/GetStates',
            data: JSON.stringify({ countryid: countryid }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.states.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadCities(stateid) {
        viewModel.cities.removeAll();
        $.ajax({
            type: 'POST',
            url: '/Common/GetCities',
            data: JSON.stringify({ stateid: stateid }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.cities.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    viewModel = {
        countries: ko.observableArray([]),
        states: ko.observableArray([]),
        cities: ko.observableArray([]),
        saveprofile:function(d) {
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod peribadi ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function() {
                $('#notification_dialog').modal('hide');
            });

            $('#notification_dialog .btn-cancel').click(function () {
                $('#notification_dialog').modal('hide');
            });
        }
    };

    ko.applyBindings(viewModel);

    $('#resume a').click(function (e) {
        console.log(e);
        e.preventDefault();
        $(this).tab('show');
    });
    $('#resume a[href="#peribadi"]').tab('show');
    $('#resume a:first').tab('show');
});