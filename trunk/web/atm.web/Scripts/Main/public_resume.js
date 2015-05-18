var viewModel;
var oTable;

$(function () {
    $('#resume a').click(function (e) {
        console.log(e);
        e.preventDefault();
        $(this).tab('show');
    });
    $('#resume a[href="#peribadi"]').tab('show');
    $('#resume a:first').tab('show');
});