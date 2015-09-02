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
                "sAjaxSource": server + '/Admin/LoadToUpdateApplicant?category=' + ko.mapping.toJS(viewModel.searchcriteria.category) + "&name=" + ko.mapping.toJS(viewModel.searchcriteria.name) + "&icno=" + ko.mapping.toJS(viewModel.searchcriteria.icno) + "&acquisitionid=" + selectedid + "&firstinvitation=true",
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
                                        return '<label><input type="checkbox" class="check-row" id="cb_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Panggil Pemilihan</span> </label>';
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
                viewModel.candidates.push($(this).val());
            });

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ candidates: ko.mapping.toJS(viewModel.candidates) }),
                url: server + '/Admin/SubmitFirstSelection',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        $("#selectall").prop("checked", false);
                        loadApplicant();
                    }
                    hideLoading();
                    ShowMessage(msg.message);
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        },
        savetemplate: function () {
            viewModel.announcement.Body($('.wysiwye-editor').code());
            viewModel.announcement.AnnouncementSelectionInd(1);
            viewModel.announcement.AnnouncementTypeInd('E');
            $.ajax({
                type: 'POST',
                data: JSON.stringify({ announcement: ko.mapping.toJS(viewModel.announcement) }),
                url: server + '/Admin/SubmitAnnouncement',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        ShowMessage(msg.message);
                    }
                    hideLoading();
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        },
        print: function () {
            window.open(server + "/Admin/PrintFirstInvitation", "PrintFirstInvite", null, true);
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

    if (viewModel.announcement.Body) {
        if (viewModel.announcement.Body() !== null) {
            $('.wysiwye-editor').code(viewModel.announcement.Body());
        }
    }
});