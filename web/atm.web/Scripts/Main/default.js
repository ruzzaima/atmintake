$.support.cors = true;

$(function () {
    var sPath = window.location.pathname;
    var sPage = sPath.substring(sPath.indexOf('/') + 1);
    sPage = sPage.toLowerCase();
    var addVD = "";
    if (virtualdirectory != '' && virtualdirectory.length > 0) {
        addVD = virtualdirectory + "/";
    }
    var comparevalue = '';

    $('.mainnav label').each(function () {
        if ($(this).attr('ref') != null) {
            var menupage = $(this).attr('ref');
            if (menupage.indexOf(';') > 0) {
                var splitref = menupage.split(';');
                for (var i = 0; i < splitref.length; i++) {
                    if (splitref[i].toLowerCase() == sPage) {
                        $(this).addClass("active");
                    }
                }
            }
            if ($(this).attr('ref').toLowerCase() == sPage) {
                $(this).addClass("active");
                return;
            }
        }
    });

    $("input[name='topmenu']").change(function () {
        var val = $(this).val();
        if (val == 'account') {
            location.href = "/Public/Account";
        }
        if (val == 'resume') {
            location.href = "/Public/Resume";
        }
        if (val == 'application') {
            location.href = "/Public/Application";
        }
        if (val == 'reset') {
            location.href = "/Account/ResetPassword";
        }
    });

});