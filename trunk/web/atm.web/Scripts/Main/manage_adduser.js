var viewModel;
var oTable;

$(function () {

    viewModel = {
        isvalid: ko.observable(false),
        user: ko.mapping.fromJS(user),
        submit: function (d) {
            $.ajax({
                type: 'POST',
                url: server + '/Manage/SubmitUser',
                data: JSON.stringify({ loguser: ko.mapping.toJS(viewModel.user) }),
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        ShowMessageAndRedirect(msg.message, server + "/Manage/ManageUser");
                    } else {
                        ShowMessage(msg.message);
                    }
                },
                error: function (xhr) {
                }
            });
        },
        submitandemail: function (d) {
            $.ajax({
                type: 'POST',
                url: server + '/Manage/SubmitAndEmailUser',
                data: JSON.stringify({ loguser: ko.mapping.toJS(viewModel.user) }),
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        ShowMessageAndRedirect(msg.message, server + "/Manage/ManageUser");
                    } else {
                        ShowMessage(msg.message);
                    }
                },
                error: function (xhr) {
                }
            });
        },
        deleteuser: function () {
            if (viewModel.user.ApplicantId) {
                if (viewModel.user.ApplicantId !== null || viewModel.user.ApplicantId !== undefined) {
                    ShowMessage('Maklumat pengguna ini tidak boleh dihapuskan.');
                    return false;
                }
            }

            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menghapuskan maklumat pengguna ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                showLoading();
                $.ajax({
                    type: 'POST',
                    url: server + '/Manage/DeleteUser',
                    data: JSON.stringify({ userid: ko.mapping.toJS(viewModel.user.UserId) }),
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                            ShowMessageAndRedirect(msg.message, server + "/Manage/ManageUser");
                        } else {
                            ShowMessage(msg.message);
                        }
                    },
                    error: function (xhr) {
                    }
                });

                $('#notification_dialog').modal('hide');
            });

            $('#notification_dialog .btn-cancel').click(function () {
                $('#notification_dialog').modal('hide');
            });
        },
        cancel: function () {
            location.href = server + "/Manage/ManageUser";
        },
        generatetempassword: function () {
            $.ajax({
                type: 'POST',
                url: server + '/Account/GenerateTempPassword',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        viewModel.user.Password(msg.pass);
                    }
                },
                error: function (xhr) {
                }
            });
        }
    };

    viewModel.user.LoginId.subscribe(function (d) {
        showLoading();
        if (d) {
            if ($.isNumeric(d)) {
                $.ajax({
                    type: 'POST',
                    url: server + '/Manage/CheckInAtm',
                    data: JSON.stringify({ id: ko.mapping.toJS(d) }),
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                            viewModel.isvalid(true);
                            viewModel.user.FullName(msg.name);
                        } else {
                            ShowMessage(msg.message);
                            viewModel.isvalid(false);
                        }
                        hideLoading();
                    },
                    error: function (xhr) {
                    }
                });
            } else {
                ShowMessage('Sila masukkan angka sahaja.');
            }
        }
    });

    ko.applyBindings(viewModel);


    $('input[name="role"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.user.LoginRole.Roles(selectedval);
    });

    $('input[name="role"]').each(function () {
        if (viewModel.user.LoginRole) {
            if (viewModel.user.LoginRole.Roles() !== null) {
                if (this.value === viewModel.user.LoginRole.Roles()) {
                    $(this).iCheck('check');
                }
            }
        }
    });


    $('input[name="service"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.user.ServiceCd(selectedval);
    });

    $('input[name="service"]').each(function () {
        if (viewModel.user.ServiceCd) {
            if (viewModel.user.ServiceCd() !== null) {
                if (this.value === viewModel.user.ServiceCd()) {
                    $(this).iCheck('check');
                }
            }
        }
    });


    $('input[name="status"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.user.Status(selectedval);
    });

    $('input[name="status"]').each(function () {
        if (viewModel.user.Status) {
            if (this.value === viewModel.user.Status() || viewModel.user.Status() === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'Tidak Aktif') {
                $(this).iCheck('check');
            }
        }
    });
});