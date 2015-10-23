var viewModel;
var oTable;


$(function () {

    viewModel = {
        searchcriteria: {
            category: ko.observable(''),
            name: ko.observable(''),
            icno: ko.observable('')
        },
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
                "sAjaxSource": server + '/Admin/SearchingApplicant?category=' + ko.mapping.toJS(viewModel.searchcriteria.category) + "&name=" + ko.mapping.toJS(viewModel.searchcriteria.name) + "&icno=" + ko.mapping.toJS(viewModel.searchcriteria.icno) + "&acquisitionid=" + selectedid,
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
                                    "sClass": "text-center",
                                    "mRender": function (data, type, full) {
                                        var id = data;
                                        return '<a href="' + server + '/Admin/RedirectForm?id=' + id + '&acquisitionid=' + selectedid + '" class="btn btn-sm projectdomain" domainid="' + id + '" id="btn_' + id + '">Kemaskini</a>';
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
        }
    };

    ko.applyBindings(viewModel);

    $('input[name="search"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.searchcriteria.category(selectedval);
    });

});