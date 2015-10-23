var viewModel;
var oTable;

$(function () {

    viewModel = {
        cancel: function () {
            location.href = server + "/Admin/Intakes";
        }
    };

    ko.applyBindings(viewModel);

});