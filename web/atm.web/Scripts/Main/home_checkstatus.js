var viewModel;
var oTable;

$(function () {
    function loadCaptcha() {
        showLoading();
        $.ajax({
            type: 'GET',
            url: server + '/Public/generateCaptcha',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            success: function (data) {
                $("#m_imgCaptcha").attr('src', server + "/Images/" + data);
                hideLoading();
            },
            error: function(data) {
                ShowMessage("Error while loading captcha image");
                hideLoading();
            }
        });
    }

    viewModel = {
        ischecked: ko.observable(false),
        idnumber: ko.observable(''),
        captcha: ko.observable(''),
        cancel: function () {
            location.href = server + "/Account/Login";
        },
        checkstatus: function (d) {
            showLoading();
            $.ajax({
                type: 'POST',
                url: server + '/Public/CheckStatus',
                data: JSON.stringify({ idnumber: ko.mapping.toJS(viewModel.idnumber), captcha: ko.mapping.toJS(viewModel.captcha) }),
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                    }
                    $('.msg').html(msg.message);
                    hideLoading();
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
            viewModel.ischecked(true);
        },
        resetchecking: function (d) {
            viewModel.idnumber('');
            viewModel.ischecked(false);
        },
        refresh: function() {
            loadCaptcha();
        }
    };

    ko.applyBindings(viewModel);

    loadCaptcha();
});