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
            location.href = server + "/Public/Account";
        }
        if (val == 'resume') {
            location.href = server + "/Public/Resume";
        }
        if (val == 'application') {
            location.href = server + "/Public/Application";
        }
        if (val == 'reset') {
            location.href = server + "/Account/ResetPassword";
        }
    });

    $('.popup').click(function (event) {
        event.preventDefault();
        window.open(server + $(this).attr("href"), "", "", false);
    });


    $('.logout').click(function (event) {
        event.preventDefault();
        $("#notification_dialog .modal-body").html("Adakah anda pasti untuk log keluar?");
        $("#notification_dialog").modal({
            show: 'true',
            backdrop: 'true',
            keyboard: 'true'
        });

        $('#notification_dialog .btn-submit').unbind("click");
        $('#notification_dialog .btn-submit').click(function () {
            signout();
            $('#notification_dialog').modal('hide');
        });

        $('#notification_dialog .btn-cancel').click(function () {
            $('#notification_dialog').modal('hide');
        });
    });

    $('input[type=text]').val(function () {

        var cap = $(this).attr("noncap");
        if (cap) {
            return this.value;
        }

        return this.value.toUpperCase();
    });

    $("input[type=text]").keyup(function () {
        var cap = $(this).attr("noncap");
        if (cap) {
            return this.value;
        }

        $(this).val($(this).val().toUpperCase());
    });

    $('.money').val(function () {
        return FormatCurrency(this.value);
    });

    $(".money").change(function () {
        $(this).val(FormatCurrency(parseFloat($(this).val()).toFixed(2)));
    });

});


function ShowMessage(message) {
    $("#message_dialog .modal-body").html(message);
    $("#message_dialog").modal({
        show: 'true',
        backdrop: 'true',
        keyboard: 'true'
    });

    $('#message_dialog .btn-cancel').click(function () {
        $('#message_dialog').modal('hide');
    });
}

function ShowMessageAndRedirect(message, url) {
    $("#message_dialog .modal-body").html(message);
    $("#message_dialog").modal({
        show: 'true',
        backdrop: 'true',
        keyboard: 'true'
    });

    $('#message_dialog .btn-cancel').click(function () {
        $('#message_dialog').modal('hide');
        window.location = url;
    });
}

function showLoading() {
    $("#loading_dialog").modal({
        show: 'true',
        backdrop: 'true',
        keyboard: 'true'
    });
}

function hideLoading() {
    $("#loading_dialog").modal('hide');
}

function signout() {
    $.ajax({
        type: 'POST',
        url: server + '/Account/SignOut',
        contentType: "application/json; charset=utf-8",
        success: function (msg) {
            if (msg.OK) {
                location.href = server + "/Home/";
            }
        },
        error: function (xhr) {
        }
    });
}

function initializeChecklist(peribadi, akademik, pengakuan, sponsorship, sport, ispegawai) {

    var progressperibadi = parseInt(peribadi);
    $('.peribadi').css('width', progressperibadi + '%');

    var progressakademik = parseInt(akademik);
    $('.akademik').css('width', progressakademik + '%');

    var progresspengakuan = parseInt(pengakuan);
    $('.pengakuan').css('width', progresspengakuan + '%');

    if (ispegawai) {
        $('.pegawai').show();
    } else {
        $('.pegawai').hide();
    }

    var progresssponsorship = parseInt(sponsorship);
    $('.sponsorship').css('width', progresssponsorship + '%');

    var progresssport = parseInt(sport);
    $('.sport').css('width', progresssport + '%');
}


function getQuerystring(key, defaultv) {
    if (defaultv == null) defaultv = "";
    key = key.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var regex = new RegExp("[\\?&]" + key + "=([^&#]*)");
    var qs = regex.exec(window.location.href);
    if (qs == null)
        return defaultv;
    else
        return qs[1];
}

function FormatCurrency(num) {
    if (num) {
        var str = num.toString().replace("$", ""), parts = false, output = [], i = 1, formatted = null;
        if (str.indexOf(".") > 0) {
            parts = str.split(".");
            str = parts[0];
        }
        str = str.split("").reverse();
        for (var j = 0, len = str.length; j < len; j++) {
            if (str[j] != ",") {
                output.push(str[j]);
                if (i % 3 == 0 && j < (len - 1)) {
                    output.push(",");
                }
                i++;
            }
        }

        formatted = output.reverse().join("");
        return ("" + formatted + ((parts) ? "." + parts[1].substr(0, 2) : ".00"));
    }
    return num;
}

function openinwindow(url, name, overwrite) {
    window.open(url, name, null, true);
}