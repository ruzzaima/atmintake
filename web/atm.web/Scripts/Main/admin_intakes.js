var viewModel;
var oTable;

$(function () {

    viewModel = {
        cancel: function () {
            location.href = server + "/Home/";
        }
    };

    ko.applyBindings(viewModel);


    function loadintakes() {
        oTable = $('#intakes_table').dataTable({
            "sDom": "<'row table-top-control'<'col-md-6 hidden-xs per-page-selector'l><'col-md-6 text-right'f>r>t<'row table-bottom-control'<'col-md-6'i><'col-md-6 text-right'p>>",
            "oLanguage": { "sLengthMenu": "_MENU_ &nbsp; rekod per muka surat", "sProcessing": 'Sedang Diproses...', "sSearch": "Carian", "sInfo": "Memaparkan _START_ hingga _END_ daripada _TOTAL_ rekod" },
            "bJQueryUI": false,
            "bPaginate": true,
            "sPaginationType": "bootstrap",
            "bFilter": true,
            "bProcessing": true,
            "bDestroy": true,
            "bServerSide": true,
            "sAjaxSource": server + '/Admin/LoadIntakes',
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
                            { "bSortable": false },
                            { "bSortable": false },
                            { "bSortable": false },
                            {
                                "bSortable": false,
                                "mRender": function (data, type, full) {
                                    var id = data;
                                    if (parseInt(selectedid) === parseInt(id)) {
                                        return '<input type="button" class="btn btn-sm" id="' + id + '" value="Sedang Dipilih" />';
                                    }
                                    return '<input type="button" class="btn btn-sm projectdomain" domainid="' + id + '" id="btn_' + id + '" value="Pilih" />';
                                }
                            }
            ],
            "fnCreatedCell": function (cell) {
                $('input', cell).click(function (event) {
                    event.preventDefault();
                });
            }
        });

        $('#intakes_table tbody').on('click', 'td input[type=button]', function (event) {
            event.preventDefault();
            var id = $(this).attr('domainid');
            var intid = parseInt(id);
            if (id !== 0) {
                $.ajax({
                    type: "POST",
                    url: server + "/Admin/SetSelectedAcquisition",
                    data: JSON.stringify({ acqid: intid }),
                    contentType: "application/json; charset=utf-8",
                    error: function (xhr) { ShowErrorMessage("Error : " + xhr.statusText); },
                    success: function (msg) {
                        if (msg.OK) {
                            $("#message_dialog .modal-body").html('Pemilihan ' + msg.name + ' dipilih.');
                            $("#message_dialog").modal({
                                show: 'true',
                                backdrop: 'true',
                                keyboard: 'true'
                            });

                            $('#message_dialog .btn-cancel').click(function () {
                                $('#message_dialog').modal('hide');
                                location.href = server + "/Admin/";
                            });
                        }
                    }
                });
            }
        });
    }

    loadintakes();

    $('.projectdomain').click(function () {
        var intid = parseInt(id);
        $.ajax({
            type: "POST",
            url: server + "/Admin/SetSelectedAcquisition",
            data: JSON.stringify({ acqid: intid }),
            contentType: "application/json; charset=utf-8",
            error: function (xhr) { ShowErrorMessage("Error : " + xhr.statusText); },
            success: function (msg) {
                if (msg.OK) {
                    $("#message_dialog .modal-body").html('Pemilihan ' + msg.name + ' dipilih.');
                    $("#message_dialog").modal({
                        show: 'true',
                        backdrop: 'true',
                        keyboard: 'true'
                    });

                    $('#message_dialog .btn-cancel').click(function () {
                        $('#message_dialog').modal('hide');
                        location.href = server + "/Admin/";
                    });
                }
            }
        });
    });
});