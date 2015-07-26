var viewModel;
var oTable;

$(function () {

    viewModel = {
        ischecked: ko.observable(false),
        idnumber: ko.observable(''),
        cancel: function () {
            location.href = server + "/Account/Login";
        },
        checkstatus: function (d) {
            $.ajax({
                type: 'POST',
                url: server + '/Public/CheckStatus',
                data: JSON.stringify({ idnumber: ko.mapping.toJS(viewModel.idnumber) }),
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                    }
                    $('.msg').html(msg.message);
                },
                error: function (xhr) {
                }
            });
            viewModel.ischecked(true);
        },
        resetchecking: function (d) {
            viewModel.idnumber('');
            viewModel.ischecked(false);
        }
    };

    ko.applyBindings(viewModel);

});