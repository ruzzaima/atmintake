var viewModel;
var oTable;

$(function () {

    viewModel = {
        cancel: function () {
            location.href = server + "/Home/";
        }
    };

    ko.applyBindings(viewModel);

    function loaduser() {
        oTable = $('#user_table').dataTable({
            "sDom": "<'row table-top-control'<'col-md-6 hidden-xs per-page-selector'l><'col-md-6 text-right'f>r>t<'row table-bottom-control'<'col-md-6'i><'col-md-6 text-right'p>>",
            "oLanguage": { "sLengthMenu": "_MENU_ &nbsp; rekod per muka surat", "sProcessing": 'Sedang Diproses...', "sSearch": "Carian" },
            "bJQueryUI": false,
            "bPaginate": true,
            "sPaginationType": "bootstrap",
            "bFilter": true,
            "bProcessing": true,
            "bDestroy": true,
            "bServerSide": true,
            "sAjaxSource": server + '/Manage/LoadUser',
            "fnDrawCallback": function (oSettings) {
                /* Need to redo the counters if filtered or sorted */
                if (oSettings.bSorted || oSettings.bFiltered) {
                    for (var i = 0, iLen = oSettings.aiDisplay.length; i < iLen; i++) {
                        $('td:eq(0)', oSettings.aoData[oSettings.aiDisplay[i]].nTr).html(i + 1);
                    }
                }
            },
            "aoColumns": [
                            { "bSortable": false },
                            { "bSortable": false },
                            { "bSortable": false },
                            { "bSortable": false },
                            { "bSortable": false },
                            { "bSortable": false },
                            {
                                "bSortable": false,
                                "fnRender": function (d) {
                                    var id = d.aData[6];
                                    return '<a class="btn btn-sm" href="' + server + "/Manage/UserProfile?id=" + id + '" >Kemaskini</a>';
                                }
                            }
            ],
        });
    }

    loaduser();
});