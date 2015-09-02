var viewModel;
var oTable;

$(function () {

    function loaduser(category) {
        oTable = $('#user_table').dataTable({
            "sDom": "<'row table-top-control'<'col-md-6 hidden-xs per-page-selector'l><'col-md-6 text-right'f>r>t<'row table-bottom-control'<'col-md-6'i><'col-md-6 text-right'p>>",
            "oLanguage": { "sLengthMenu": "_MENU_ &nbsp; rekod per muka surat", "sProcessing": loadingdatatable, "sSearch": "Carian Nama/Id Pengguna", "sInfo": "Memaparkan _START_ hingga _END_ daripada _TOTAL_ rekod" },
            "bJQueryUI": false,
            "bPaginate": true,
            "sPaginationType": "bootstrap",
            "bFilter": true,
            "bProcessing": true,
            "bDestroy": true,
            "bServerSide": true,
            "sAjaxSource": server + '/Manage/LoadUser?category=' + category,
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
                { "bSortable": true },
                { "bSortable": false },
                { "bSortable": false },
                { "bSortable": false },
                { "bSortable": false },
                {
                    "bSortable": false,
                    "mRender": function (data, type, full) {
                        var id = data;
                        return '<a class="btn btn-sm" href="' + server + "/Manage/UserProfile?id=" + id + '" >Kemaskini</a>';
                    }
                }
            ],
        });

        if (category === 'AW') {
            oTable.fnSetColumnVis(4, false);
            oTable.fnSetColumnVis(5, false);
            oTable.fnSetColumnVis(3, true);
        } else {
            oTable.fnSetColumnVis(4, true);
            oTable.fnSetColumnVis(5, true);
            oTable.fnSetColumnVis(3, false);
        }
    }

    viewModel = {
        category: ko.observable(''),
        searchuser: function () {
            loaduser(ko.mapping.toJS(viewModel.category));
        },
        cancel: function () {
            location.href = server + "/Home/";
        }
    };

    ko.applyBindings(viewModel);

    $('input[name="category"]').each(function () {
        if (this.value === 'SP') {
            viewModel.category('SP');
            $(this).iCheck('check');
        }
    });

    $('input[name="category"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.category(selectedval);
        if (selectedval === "AW") {
            oTable.fnSetColumnVis(4, false);
            oTable.fnSetColumnVis(5, false);
            oTable.fnSetColumnVis(3, true);
        } else {
            oTable.fnSetColumnVis(4, true);
            oTable.fnSetColumnVis(5, true);
            oTable.fnSetColumnVis(3, false);
        }
    });

    if (admin) {
        loaduser("SP");
    } else {
        loaduser("AW");
        $('input[name="category"]').each(function () {
            if (this.value === 'AW') {
                viewModel.category('AW');
                $(this).iCheck('check');
            }
        });

        oTable.fnSetColumnVis(4, false);
        oTable.fnSetColumnVis(5, false);
    }

});