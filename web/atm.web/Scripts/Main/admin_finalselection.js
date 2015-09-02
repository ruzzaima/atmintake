var viewModel;
var oTable;


$(function () {
    function loadApplicant() {
        viewModel.search();
    }

    viewModel = {
        searchcriteria: {
            category: ko.observable(''),
            name: ko.observable(''),
            icno: ko.observable('')
        },
        approvecandidates: ko.observableArray([]),
        rejectedcandidates: ko.observableArray([]),
        candidates: ko.observableArray([]),
        announcement: ko.mapping.fromJS(announcement),
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
                "sAjaxSource": server + '/Admin/LoadToUpdateApplicant?category=' + ko.mapping.toJS(viewModel.searchcriteria.category) + "&name=" + ko.mapping.toJS(viewModel.searchcriteria.name) + "&icno=" + ko.mapping.toJS(viewModel.searchcriteria.icno) + "&acquisitionid=" + selectedid + "&finalinvitation=true",
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
                                    "sClass": "text-middle",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="checkbox" app-data="true" class="approve-row" id="af_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Lulus Pemilihan Akhir</span> </label>';
                                    }
                                },
                                {
                                    "bSortable": false,
                                    "sClass": "text-middle",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<label><input type="checkbox" call-data="true" class="check-row" id="cb_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Berjaya</span> </label> <br/><label><input type="checkbox" reject-data="true" class="reject-row" id="cb_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Gagal</span> </label>';
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
                    viewModel.approvecandidates.push($(this).val());
                }

                if ($(this).attr('reject-data')) {
                    viewModel.rejectedcandidates.push($(this).val());
                }

                if ($(this).attr('call-data')) {
                    viewModel.candidates.push($(this).val());
                }
            });

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ approvecandidates: ko.mapping.toJS(viewModel.approvecandidates), rejectedcandidates: ko.mapping.toJS(viewModel.rejectedcandidates), candidates: ko.mapping.toJS(viewModel.candidates) }),
                url: server + '/Admin/SubmitLastSelection',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        $("#approveall").prop("checked", false);
                        loadApplicant();
                    }
                    hideLoading();
                    ShowMessage(msg.message);
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        }
    };

    ko.applyBindings(viewModel);
    loadApplicant();

    $("#selectall").change(function () {
        if ($(this).is(":checked")) {
            $('.check-row').prop("checked", true);
        } else {
            $('.check-row').prop("checked", false);
        }
    });

    $("#approveall").change(function () {
        if ($(this).is(":checked")) {
            $('.approve-row').prop("checked", true);
        } else {
            $('.approve-row').prop("checked", false);
        }
    });

});