var viewModel;
var oTable;


$(function () {
    
    viewModel = {
        searchcriteria: {
            category: ko.observable(''),
            name: ko.observable(''),
            icno: ko.observable('')
        },
        candidates: ko.observableArray([]),
        processcandidates: ko.observableArray([]),
        rejectcandidates: ko.observableArray([]),
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
                                        return '<label><input type="radio" app-data="true" name="firstselection' + id + '" class="check-row-approve" id="cba_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Temuduga/Pemilihan Akhir</span> </label>';
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
                                        return '<label><input type="radio" reject-data="true" name="firstselection' + id + '" class="check-row-reject" id="cbr_' + id + '" value="' + id + '" /> <span style="padding-bottom:5px;">Tidak Terpilih Ke Temuduga/Pemilihan Akhir</span> </label>';
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
                url: server + '/Admin/SubmitFinalSelection',
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
        savetemplate: function () {
            viewModel.announcement.Body($('.wysiwye-editor').code());
            viewModel.announcement.AnnouncementSelectionInd(2);
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
            window.open(server + "/Admin/PrintFinalInvitation", "PrintFinalInvite", null, true);
        }
    };

    ko.applyBindings(viewModel);
    viewModel.search();

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

    $('input[name="search"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.searchcriteria.category(selectedval);
    });
});