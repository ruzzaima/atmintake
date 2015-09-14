var viewModel;
var oTable;

$(function () {

    // validation
    $("#form_peribadi").validationEngine();
    $("#form_akademik").validationEngine();

    function checkPengakuan() {

        // cronic illness
        $('input[name="cronic_illness[cronic_illness]"]').each(function () {
            if ($(this).prop('checked')) {
                if ($(this).prop('value') === 'Y') {
                    viewModel.applicant.CronicIlnessInd(true);
                } else {
                    viewModel.applicant.CronicIlnessInd(false);
                }
            }
        });


        // crime_involve
        $('input[name="crime_involve[crime_involve]"]').each(function () {
            if ($(this).prop('checked')) {
                if ($(this).prop('value') === 'Y') {
                    viewModel.applicant.CrimeInvolvement(true);
                } else {
                    viewModel.applicant.CrimeInvolvement(false);
                }
            }
        });


        // crime_drug
        $('input[name="crime_drug[crime_drug]"]').each(function () {
            if ($(this).prop('checked')) {
                if ($(this).prop('value') === 'Y') {
                    viewModel.applicant.DrugCaseInvolvement(true);
                } else {
                    viewModel.applicant.DrugCaseInvolvement(false);
                }
            }
        });
    }

    function checkBeforeSubmit() {
        // get birth of date
        var bdate = $('#birthdatepicker').data('date');
        viewModel.applicant.BirthDateString(bdate);
        var splitdate = bdate.split("/");
        bdate = splitdate[1] + "/" + splitdate[0] + "/" + splitdate[2];
        viewModel.applicant.BirthDate(bdate);

        $('input[type=text]').val(function () {
            return this.value.toUpperCase();
        });

        if (viewModel.applicant.CurrentSalary) {
            if (viewModel.applicant.CurrentSalary() !== null || viewModel.applicant.CurrentSalary() !== '') {
                var formated = viewModel.applicant.CurrentSalary();
                if (formated !== null) {
                    if (formated.toString().indexOf(',') !== -1) {
                        formated = formated.replace(',', '');
                        viewModel.applicant.CurrentSalary(formated);
                    }
                }
            }
        }
    }

    function initializeAfterSubmit() {
        if (viewModel.applicant.ApplicantId) {
            loadChecklist(viewModel.applicant.ApplicantId(), acquisitionid);
        }

        if (viewModel.applicant.BirthDate) {
            if (viewModel.applicant.BirthDate() !== null) {
                var splitdate = viewModel.applicant.BirthDate().split("-");
                var bday = splitdate[2].split("T");
                var bdate = bday[0] + "/" + splitdate[1] + "/" + splitdate[0];
                $('#birthdatepicker').data("DateTimePicker").date(bdate);
            }
        }

        $('.eduyear').val(function () {
            if (this.value === '0') {
                return '';
            }
            else {
                return this.value;

            }
        });
    }

    viewModel = {
        applicant: ko.mapping.fromJS(applicant),
        maritalstatues: ko.observableArray([]),
        countries: ko.observableArray([]),
        states: ko.observableArray([]),
        cities: ko.observableArray([]),
        birthstates: ko.observableArray([]),
        birthcities: ko.observableArray([]),
        religions: ko.observableArray([]),
        academics: ko.observableArray([]),
        races: ko.observableArray([]),
        occupations: ko.observableArray([]),
        higheducations: ko.observableArray([]),
        institutions: ko.observableArray([]),
        ethnics: ko.observableArray([]),
        sports: ko.observableArray([]),
        sportslist: ko.observableArray([]),
        kokos: ko.observableArray([]),
        achievements: ko.observableArray([]),
        kokolist: ko.observableArray([]),
        otherssportandassociations: ko.observableArray([]),
        isedusubject: ko.observable(false),
        isguardian: ko.observable(true),
        ispalapes: ko.observable(false),
        skillcats: ko.observableArray([]),
        skills: ko.observableArray([]),
        bidang: ko.observableArray([]),
        grades: ko.observableArray([]),
        subjects: ko.observableArray([]),
        zones: ko.observableArray([]),
        locations: ko.observableArray([]),
        ischecked: ko.observable(false),
        saveprofile: function (d) {

            checkBeforeSubmit();
            checkPengakuan();
            showLoading();

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant), acquisitionid: acquisitionid }),
                url: server + '/Public/SubmitProfile',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        viewModel.applicant.ApplicantId(msg.id);
                        ko.mapping.fromJSON(msg.item, viewModel.applicant);

                        initializeAfterSubmit();
                    }
                    hideLoading();
                    ShowMessage(msg.message);
                },
                error: function (xhr) {
                    hideLoading();
                }
            });
        },
        saveprofilesilent: function (d) {

            checkBeforeSubmit();
            checkPengakuan();

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant), acquisitionid: acquisitionid }),
                url: server + '/Public/SubmitProfile',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg.OK) {
                        viewModel.applicant.ApplicantId(msg.id);
                        ko.mapping.fromJSON(msg.item, viewModel.applicant);

                        initializeAfterSubmit();
                    }
                },
                error: function (xhr) {}
            });
        },
        addacademic: function () {
            viewModel.applicant.ApplicantEducations.push({
                HighEduLevelCd: ko.observable(''),
                EduCertTitle: ko.observable(''),
                OverallGrade: ko.observable(''),
                ConfermentYr: ko.observable(''),
                InstCd: ko.observable('')
            });
        },
        removeacademic: function (d) {
            if (d) {
                viewModel.applicant.ApplicantEducations.remove(d);
            }
        },
        addsport: function () {
            viewModel.applicant.Sports.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removesport: function (d) {
            if (d) {
                if (d.ApplicantSportAssocId() === null && d.ApplicantSportAssocId() === 0) {
                    viewModel.applicant.Sports.remove(d);
                } else {
                    //remove from db
                    showLoading();
                    $.ajax({
                        type: 'POST',
                        data: JSON.stringify({ appsid: ko.mapping.toJS(d.ApplicantSportAssocId) }),
                        url: server + '/Public/RemoveSportAndKokos',
                        contentType: "application/json; charset=utf-8",
                        success: function (msg) {
                            if (msg.OK) {
                                viewModel.applicant.Sports.remove(d);
                            }
                            hideLoading();
                        },
                        error: function (xhr) {
                            hideLoading();
                        }
                    });
                }
            }
        },
        addkoko: function () {
            viewModel.applicant.Kokos.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removekoko: function (d) {
            if (d) {
                if (d.ApplicantSportAssocId() === null && d.ApplicantSportAssocId() === 0) {
                    viewModel.applicant.Kokos.remove(d);
                } else {
                    //remove from db
                    showLoading();
                    $.ajax({
                        type: 'POST',
                        data: JSON.stringify({ appsid: ko.mapping.toJS(d.ApplicantSportAssocId) }),
                        url: server + '/Public/RemoveSportAndKokos',
                        contentType: "application/json; charset=utf-8",
                        success: function (msg) {
                            if (msg.OK) {
                                viewModel.applicant.Kokos.remove(d);
                            }
                            hideLoading();
                        },
                        error: function (xhr) {
                            hideLoading();
                        }
                    });
                }
            }
        },
        addothersportnkoko: function () {
            viewModel.otherssportandassociations.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removeothersportnkoko: function (d) {
            if (d) {
                viewModel.otherssportandassociations.remove(d);
            }
        },
        savesportnassociation: function () {
            viewModel.saveprofile();
        },
        saveacademics: function () {
            var valid = $("#form_akademik").validationEngine('validate');
            var vars = $("#form_akademik").serialize();
            if (valid === true) {
                viewModel.saveprofile();
            } else {
                $("#form_akademik").validationEngine();
            }
        },
        saveacademicsandcontinue: function () {
            var valid = $("#form_akademik").validationEngine('validate');
            var vars = $("#form_akademik").serialize();
            if (valid === true) {
                viewModel.saveprofile();
                $('#resume a[href="#sport"]').tab('show');
            } else {
                $("#form_akademik").validationEngine();
            }
        },
        savecontract: function () {
            viewModel.saveprofile();
        },
        savecontractandcontinue: function () {
            viewModel.savecontract();
            $('#resume a[href="#sport"]').tab('show');
        },
        saveperibadi: function (d) {
            var valid = $("#form_peribadi").validationEngine('validate');
            var vars = $("#form_peribadi").serialize();
            if (valid === true) {
                viewModel.saveprofile();
            } else {
                $("#form_peribadi").validationEngine();
            }
        },
        saveprofileandcontinue: function (d) {
            var valid = $("#form_peribadi").validationEngine('validate');
            var vars = $("#form_peribadi").serialize();
            if (valid === true) {
                viewModel.saveprofile();
                $('#resume a[href="#akademik"]').tab('show');
            } else {
                $("#form_peribadi").validationEngine();
            }
        },
        saveacademicandcontinue: function (d) {
            viewModel.saveacademics();
            $('#resume a[href="#sponsorship"]').tab('show');
        },
        saveskill: function (d) {
            viewModel.saveprofile();
        },
        saveskillandcontinue: function (d) {
            viewModel.saveprofile();
            $('#resume a[href="#crime"]').tab('show');
        },
        savescrime: function (d) {
            viewModel.saveprofile();
        },
        savescrimeandcontinue: function (d) {
            viewModel.saveprofile();
            $('#resume a[href="#confirmation"]').tab('show');
        },
        submitapplication: function (d) {
            if (viewModel.ischecked) {
                
                if (viewModel.applicant.CronicIlnessInd() == null || viewModel.applicant.CrimeInvolvement() == null || viewModel.applicant.DrugCaseInvolvement() == null) {
                    ShowMessage('Sila pilih maklumat Pengakuan.');
                    return;
                }

                $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menghantar permohonan ini?");
                $("#notification_dialog").modal({
                    show: 'true',
                    backdrop: 'true',
                    keyboard: 'true'
                });

                $('#notification_dialog .btn-submit').unbind("click");
                $('#notification_dialog .btn-submit').click(function () {

                    showLoading();

                    var pedt = $('#palapesgraduationdatepicker').data('date');
                    viewModel.applicant.PalapesTauliahEndDt(pedt);

                    $.ajax({
                        type: 'POST',
                        data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant), acquisitionid: acquisitionid }),
                        url: server + '/Public/SubmitProfile',
                        contentType: "application/json; charset=utf-8",
                        success: function (msg) {
                            if (msg.OK) {
                                $.ajax({
                                    type: 'POST',
                                    data: JSON.stringify({ acquisitionid: acquisitionid }),
                                    url: server + '/Public/SubmitApplication',
                                    contentType: "application/json; charset=utf-8",
                                    success: function (msg) {
                                        if (msg.OK) {
                                            location.href = server + "/Public/SubmissionNotification?id=" + msg.id;
                                        }
                                        hideLoading();
                                        ShowMessage(msg.message);
                                    },
                                    error: function (xhr) {
                                        hideLoading();
                                    }
                                });
                            }
                        },
                        error: function (xhr) {
                            hideLoading();
                        }
                    });
                    $('#notification_dialog').modal('hide');
                });

                $('#notification_dialog .btn-cancel').click(function () {
                    $('#notification_dialog').modal('hide');
                });
            } else {
                ShowMessage("Sila klik pada checkbox dahulu sebelum teruskan");
            }
        },
        emptiesinteger: function (d) {
            if (d) {
                var yearv = ko.mapping.toJS(d);
                if (yearv === 0) {
                    return '';
                } else {
                    return d;
                }
            }
        }
    };

    viewModel.applicant.CorresponAddrCountryCd.subscribe(function (d) {
        if (d) {
            loadStates(d, 'A');
        }
    });


    viewModel.applicant.CorresponAddrStateCd.subscribe(function (d) {
        if (d) {
            loadCities(d, 'A');
        }
    });

    viewModel.applicant.BirthCountryCd.subscribe(function (d) {
        if (d) {
            loadStates(d, 'B');
        }
    });


    viewModel.applicant.BirthStateCd.subscribe(function (d) {
        if (d) {
            loadCities(d, 'B');
        }
    });

    viewModel.applicant.RaceCd.subscribe(function (d) {
        if (d) {
            loadEthnics(d);
        }
    });
    viewModel.applicant.Weight.subscribe(function (d) {
        if (d) {
            if (viewModel.applicant.Height) {
                var bmi = d / (viewModel.applicant.Height() * viewModel.applicant.Height());
                bmi = parseFloat(bmi).toFixed(2);
                viewModel.applicant.Bmi(bmi);
            }

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ height: ko.mapping.toJS(viewModel.applicant.Height()), weight: ko.mapping.toJS(viewModel.applicant.Weight()), acquisitionid: acquisitionid }),
                url: server + '/Public/CheckHeightWeightBmi',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (!msg.OK) {
                        ShowMessage(msg.message);
                    }
                },
                error: function (xhr) {
                }
            });
        }
    });

    viewModel.applicant.Height.subscribe(function (d) {
        if (d) {

            $.ajax({
                type: 'POST',
                data: JSON.stringify({ height: ko.mapping.toJS(viewModel.applicant.Height()), weight: ko.mapping.toJS(viewModel.applicant.Weight()), acquisitionid: acquisitionid }),
                url: server + '/Public/CheckHeightWeightBmi',
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (!msg.OK) {
                        ShowMessage(msg.message);
                    }
                },
                error: function (xhr) {
                }
            });

            if (viewModel.applicant.Weight) {
                var bmi = viewModel.applicant.Weight() / (d * d);
                bmi = parseFloat(bmi).toFixed(2);
                viewModel.applicant.Bmi(bmi);
            }
        }
    });

    viewModel.applicant.DadName.subscribe(function (d) {
        if (d == null || d === "") {
            viewModel.isguardian(true);
        } else {
            viewModel.isguardian(false);
        }
    });
    viewModel.applicant.MomName.subscribe(function (d) {
        if (d == null || d === "") {
            viewModel.isguardian(true);
        } else {
            viewModel.isguardian(false);
        }
    });

    ko.applyBindings(viewModel);

    if (viewModel.applicant) {
        if (viewModel.applicant.DadName) {
            viewModel.isguardian(false);
        }
        if (viewModel.applicant.MomName) {
            viewModel.isguardian(false);
        }
    }

    $('#resume a').click(function (e) {
        e.preventDefault();
        $(this).tab('show');
    });
    $('#resume a[href="#peribadi"]').tab('show');
    $('#resume a:first').tab('show');

    $('#birthdatepicker').datetimepicker({
        format: 'DD/MM/YYYY'
    });

    $('#palapesgraduationdatepicker').datetimepicker({
        format: 'DD/MM/YYYY'
    });


    if (viewModel.applicant.BirthDate) {
        if (viewModel.applicant.BirthDate() !== null) {
            var splitdate = viewModel.applicant.BirthDate().split("-");
            var bday = splitdate[2].split("T");
            var bdate = bday[0] + "/" + splitdate[1] + "/" + splitdate[0];
            $('#birthdatepicker').data("DateTimePicker").date(bdate);
        }
    }

    if (viewModel.applicant.CorresponAddrCountryCd) {
        loadStates(viewModel.applicant.CorresponAddrCountryCd(), 'A');
    }

    if (viewModel.applicant.CorresponAddrCountryCd) {
        loadStates(viewModel.applicant.CorresponAddrCountryCd(), 'A');
    }

    if (viewModel.applicant.CorresponAddrStateCd) {
        loadCities(viewModel.applicant.CorresponAddrStateCd(), 'A');
    };

    if (viewModel.applicant.BirthCountryCd) {
        loadStates(viewModel.applicant.BirthCountryCd(), 'B');
    };

    if (viewModel.applicant.BirthStateCd) {
        loadCities(viewModel.applicant.BirthStateCd(), 'B');
    };

    if (viewModel.applicant.RaceCd) {
        loadEthnics(viewModel.applicant.RaceCd());
    }

    // status kahwin
    $('input[name="maritalstatus"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.applicant.MrtlStatusCd(selectedval);
    });

    if (viewModel.applicant.MrtlStatusCd) {
        $('input[name="maritalstatus"]').each(function () {
            if (this.value === viewModel.applicant.MrtlStatusCd()) {
                $(this).iCheck('check');
            }
        });
    }

    // bercermin mata
    $('input[name="spectacle"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.SpectaclesUserInd(true);
        } else {
            viewModel.applicant.SpectaclesUserInd(false);
        }
    });

    $('input[name="spectacle"]').each(function () {
        if (viewModel.applicant.SpectaclesUserInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // buta warna
    $('input[name="colorblind"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.ColorBlindInd(true);
        } else {
            viewModel.applicant.ColorBlindInd(false);
        }
    });

    $('input[name="colorblind"]').each(function () {
        if (viewModel.applicant.ColorBlindInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // servicetab_exatm
    $('input[name="servicetab_exatm"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.ArmyServiceInd(true);
        } else {
            viewModel.applicant.ArmyServiceInd(false);
        }
    });

    $('input[name="servicetab_exatm"]').each(function () {
        if (viewModel.applicant.ArmyServiceInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // palapes
    $('input[name="servicetab_ispalapes"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.PalapesInd(true);
        } else {
            viewModel.applicant.PalapesInd(false);
        }
    });

    $('input[name="servicetab_ispalapes"]').each(function () {
        if (viewModel.applicant.PalapesInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // servicetab_scholarship
    $('input[name="servicetab_scholarship"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.ScholarshipInd(true);
        } else {
            viewModel.applicant.ScholarshipInd(false);
        }
    });

    $('input[name="servicetab_scholarship"]').each(function () {
        if (viewModel.applicant.ScholarshipInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // servicetab_employeraggrement
    $('input[name="servicetab_employeraggrement"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.EmployeeAggreeInd(true);
        } else {
            viewModel.applicant.EmployeeAggreeInd(false);
        }
    });

    $('input[name="servicetab_employeraggrement"]').each(function () {
        if (viewModel.applicant.EmployeeAggreeInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });

    // servicetab_attendatmofficer
    $('input[name="servicetab_attendatmofficer"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.ArmySelectionInd(true);
        } else {
            viewModel.applicant.ArmySelectionInd(false);
        }
    });

    $('input[name="servicetab_attendatmofficer"]').each(function () {
        if (viewModel.applicant.ArmySelectionInd()) {
            if (this.value === 'Y') {
                $(this).iCheck('check');
            }
        } else {
            if (this.value === 'N') {
                $(this).iCheck('check');
            }
        }
    });


    // gender
    $('input[name="gender"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        viewModel.applicant.GenderCd(selectedval);
    });

    if (viewModel.applicant.GenderCd) {
        $('input[name="gender"]').each(function () {
            if (this.value === viewModel.applicant.GenderCd()) {
                $(this).iCheck('check');
            }
        });
    }


    // cronic_illness
    $('input[name="cronic_illness[cronic_illness]"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.CronicIlnessInd(true);
        } else {
            viewModel.applicant.CronicIlnessInd(false);
        }
    });

    $('input[name="cronic_illness[cronic_illness]"]').each(function () {
        if (viewModel.applicant.CronicIlnessInd() !== null) {
            if (viewModel.applicant.CronicIlnessInd()) {
                if (this.value === 'Y') {
                    $(this).iCheck('check');
                }
            } else {
                if (this.value === 'N') {
                    $(this).iCheck('check');
                }
            }
        }
    });

    // crime_involve
    $('input[name="crime_involve[crime_involve]"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.CrimeInvolvement(true);
        } else {
            viewModel.applicant.CrimeInvolvement(false);
        }
    });

    $('input[name="crime_involve[crime_involve]"]').each(function () {
        if (viewModel.applicant.CrimeInvolvement() !== null) {
            if (viewModel.applicant.CrimeInvolvement()) {
                if (this.value === 'Y') {
                    $(this).iCheck('check');
                }
            } else {
                if (this.value === 'N') {
                    $(this).iCheck('check');
                }
            }
        }
    });


    // crime_drug
    $('input[name="crime_drug[crime_drug]"]').on('ifClicked', function (event) {
        var selectedval = this.value;
        if (selectedval === 'Y') {
            viewModel.applicant.DrugCaseInvolvement(true);
        } else {
            viewModel.applicant.DrugCaseInvolvement(false);
        }
    });

    $('input[name="crime_drug[crime_drug]"]').each(function () {
        if (viewModel.applicant.DrugCaseInvolvement() !== null) {
            if (viewModel.applicant.DrugCaseInvolvement()) {
                if (this.value === 'Y') {
                    $(this).iCheck('check');
                }
            } else {
                if (this.value === 'N') {
                    $(this).iCheck('check');
                }
            }
        }
    });


    //ComputerMSWordcb
    $('input[name="ComputerMSWordcb"]').on('ifChecked', function (event) {
        viewModel.applicant.ComputerMSWord(true);
    });

    $('input[name="ComputerMSWordcb"]').on('ifUnchecked', function (event) {
        viewModel.applicant.ComputerMSWord(false);
    });

    //ComputerMSExcelcb
    $('input[name="ComputerMSExcelcb"]').on('ifChecked', function (event) {
        viewModel.applicant.ComputerMSExcel(true);
    });

    $('input[name="ComputerMSExcelcb"]').on('ifUnchecked', function (event) {
        viewModel.applicant.ComputerMSExcel(false);
    });

    //ComputerMSPwrPointcb
    $('input[name="ComputerMSPwrPointcb"]').on('ifChecked', function (event) {
        viewModel.applicant.ComputerMSPwrPoint(true);
    });

    $('input[name="ComputerMSPwrPointcb"]').on('ifUnchecked', function (event) {
        viewModel.applicant.ComputerMSPwrPoint(false);
    });

    //ComputerMSPwrPointcb
    $('input[name="ComputerICTcb"]').on('ifChecked', function (event) {
        viewModel.applicant.ComputerICT(true);
    });

    $('input[name="ComputerICTcb"]').on('ifUnchecked', function (event) {
        viewModel.applicant.ComputerICT(false);
    });

    $('input[name="aggree_to_submit"]').on('ifChecked', function (event) {
        viewModel.ischecked(true);
    });

    $('input[name="aggree_to_submit"]').on('ifUnchecked', function (event) {
        viewModel.ischecked(false);
    });


    if (viewModel.applicant.DadName) {
        if (viewModel.applicant.DadName() == null || viewModel.applicant.DadName() === "") {
            viewModel.isguardian(true);
        } else {
            viewModel.isguardian(false);
        }
    };

    if (viewModel.applicant.MomName) {
        if (viewModel.applicant.MomName() == null || viewModel.applicant.MomName() === "") {
            viewModel.isguardian(true);
        } else {
            viewModel.isguardian(false);
        }
    };

    if (viewModel.applicant.ApplicantId) {
        loadChecklist(viewModel.applicant.ApplicantId(), acquisitionid);
    }

    if (viewModel.applicant.CurrentSalary) {
        if (viewModel.applicant.CurrentSalary() !== null || viewModel.applicant.CurrentSalary() !== '') {
            var formated = FormatCurrency(viewModel.applicant.CurrentSalary());
            viewModel.applicant.CurrentSalary(formated);
        }
    }

    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        viewModel.saveprofilesilent();
    });

    loadCountry();
    loadReligions();
    loadRace();
    loadOccupations();
    loadSports();
    loadAssociations();
    loadAchievements();
    loadHighEducations();
    loadInstitutions();
    loadSkillCategories();
    loadSkills("L");
    loadMajorMinor();
    loadGrades();
    loadSubjects();
    loadZones();
    loadMaritalStatus(servicescode);

    viewModel.applicant.IsAgreeInd(true);
});