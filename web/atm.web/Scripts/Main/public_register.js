var viewModel;
var oTable;

$(function () {

    viewModel = {
        isvalid: ko.observable(true),
        cancel: function () {
            location.href = server + "/Home/";
        }
    };

    ko.applyBindings(viewModel);

    $('#register_idnumber').change(function (d) {
        var idnumber = $(this).val();
        $.ajax({
            type: 'POST',
            url: server + '/Public/ValidateMyKad',
            data: JSON.stringify({ idnumber: idnumber }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    viewModel.isvalid(true);
                } else {
                    ShowMessage(msg.message);
                    viewModel.isvalid(false);
                }
            },
            error: function (xhr) {
            }
        });
    });
});