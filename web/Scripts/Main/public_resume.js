var viewModel;
var oTable;

$(function () {

    function loadCountry() {
        viewModel.countries.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetCountries',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.countries.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadStates(countrycode, type) {
        if (type == 'A') { viewModel.states.removeAll(); }
        if (type == 'B') { viewModel.birthstates.removeAll(); }
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetStates',
            data: JSON.stringify({ countrycode: countrycode }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        if (type == 'A') { viewModel.states.push(v); }
                        if (type == 'B') { viewModel.birthstates.push(v) }
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadCities(statecode, type) {
        if (type == 'A') { viewModel.cities.removeAll(); }
        if (type == 'B') { viewModel.birthcities.removeAll(); }
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetCities',
            data: JSON.stringify({ statecode: statecode }),
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        if (type == 'A') { viewModel.cities.push(v); }
                        if (type == 'B') { viewModel.birthcities.push(v); }
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }


    function loadReligions() {
        viewModel.religions.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetReligions',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.religions.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadRace() {
        viewModel.races.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetRaces',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.races.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadOccupations() {
        viewModel.occupations.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetOccupations',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.occupations.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadHighEducations() {
        viewModel.higheducations.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetHighEducationLevel',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.higheducations.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }


    function loadInstitutions() {
        viewModel.institutions.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetInstitutions',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.institutions.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadEthnics(racecode) {
        viewModel.ethnics.removeAll();
        $.ajax({
            type: 'POST',
            data: JSON.stringify({ racecode: racecode }),
            url: server + '/Common/GetEthnics',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.ethnics.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadSports() {
        viewModel.sportslist.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetSports',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.sportslist.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadAchievements() {
        viewModel.achievements.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetAchivements',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.achievements.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }


    function loadAssociations() {
        viewModel.kokolist.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetAssociations',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.kokolist.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadSkillCategories() {
        viewModel.skillcats.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetSkillCategories',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.skillcats.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadSkills() {
        viewModel.skills.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetSkills',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.skills.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadMajorMinor() {
        viewModel.bidang.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetMajorMinor',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.bidang.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadGrades() {
        viewModel.grades.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetGrades',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.grades.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }

    function loadSubjects() {
        viewModel.subjects.removeAll();
        $.ajax({
            type: 'POST',
            url: server + '/Common/GetSubjects',
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.OK) {
                    var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                    $.each(list, function (i, v) {
                        viewModel.subjects.push(v);
                    });
                }
            },
            error: function (xhr) {
            }
        });
    }


    viewModel = {
        applicant: ko.mapping.fromJS(applicant),
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
        appeducation: ko.mapping.fromJS(appeducation),
        isguardian: ko.observable(true),
        ispalapes: ko.observable(false),
        skillcats: ko.observableArray([]),
        skills: ko.observableArray([]),
        bidang: ko.observableArray([]),
        grades: ko.observableArray([]),
        subjects: ko.observableArray([]),
        saveprofile: function (d) {
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod peribadi ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                // get birth of date
                var bdate = $('#birthdatepicker').data('date');
                viewModel.applicant.BirthDate(bdate);
                $.ajax({
                    type: 'POST',
                    data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant) }),
                    url: server + '/Public/SubmitProfile',
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                            viewModel.applicant.ApplicantId(msg.id);
                        }
                        ShowMessage(msg.message);
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
                viewModel.applicant.Sports.remove(d);
            }
        },
        addkoko: function () {
            viewModel.applicant.Kokos.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removekoko: function (d) {
            if (d) {
                viewModel.applicant.Kokos.remove(d);
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
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod kegiatan sukan dan kokurikulum ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                // get birth of date
                var bdate = $('#birthdatepicker').data('date');
                viewModel.applicant.BirthDate(bdate);
                $.ajax({
                    type: 'POST',
                    data: JSON.stringify({ sports: ko.mapping.toJS(viewModel.sports), kokos: ko.mapping.toJS(viewModel.sports), others: ko.mapping.toJS(viewModel.otherssportandassociations) }),
                    url: server + '/Public/SubmitSportAndKoko',
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                        }
                        ShowMessage(msg.message);
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
        managesubject: function (d) {
            if (d) {
                viewModel.isedusubject(true);
                ko.mapping.fromJS(ko.mapping.toJS(d), viewModel.appeducation);
            }
        },
        addedusubject: function (d) {
            viewModel.appeducation.ApplicantEduSubjects = ko.observableArray([]);
            viewModel.appeducation.ApplicantEduSubjects.push({ SubjectCd: ko.observable(''), Grade: ko.observable('') });
        },
        saveaddedusubject: function () {
            viewModel.isedusubject(false);
            ko.mapping.fromJS(appeducation, viewModel.appeducation);
        },
        saveacademics: function () {
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod akademik ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                // get birth of date
                var bdate = $('#birthdatepicker').data('date');
                viewModel.applicant.BirthDate(bdate);
                $.ajax({
                    type: 'POST',
                    data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant) }),
                    url: server + '/Public/SubmitProfile',
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                        }
                        ShowMessage(msg.message);
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
        savecurrentoccupation: function () {
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod pekerjaan sekarang ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                // get birth of date
                var bdate = $('#birthdatepicker').data('date');
                viewModel.applicant.BirthDate(bdate);
                $.ajax({
                    type: 'POST',
                    data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant) }),
                    url: server + '/Public/SubmitProfile',
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                        }
                        ShowMessage(msg.message);
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
        savecontract: function () {
            $("#notification_dialog .modal-body").html("Adakah anda pasti untuk menyimpan rekod ikatan/kontrak ini?");
            $("#notification_dialog").modal({
                show: 'true',
                backdrop: 'true',
                keyboard: 'true'
            });

            $('#notification_dialog .btn-submit').unbind("click");
            $('#notification_dialog .btn-submit').click(function () {
                // get birth of date
                var bdate = $('#birthdatepicker').data('date');
                viewModel.applicant.BirthDate(bdate);
                $.ajax({
                    type: 'POST',
                    data: JSON.stringify({ applicant: ko.mapping.toJS(viewModel.applicant) }),
                    url: server + '/Public/SubmitProfile',
                    contentType: "application/json; charset=utf-8",
                    success: function (msg) {
                        if (msg.OK) {
                        }
                        ShowMessage(msg.message);
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
        saveprofileandcontinue: function(d) {
            viewModel.saveprofile();
            $('#resume a[href="#akademik"]').tab('show');
        },
        saveacademicandcontinue: function (d) {
            viewModel.saveacademics();
            $('#resume a[href="#sponsorship"]').tab('show');
        },
        saveskill: function(d) {
            
        },
        saveskillandcontinue: function (d) {
            $('#resume a[href="#crime"]').tab('show');
        },
        savescrime: function (d) {

        },
        savescrimeandcontinue: function (d) {
            $('#resume a[href="#confirmation"]').tab('show');
        },
        submit:function(d) {
            
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
                var bmi = viewModel.applicant.Weight() / (viewModel.applicant.Height() * viewModel.applicant.Height());
                bmi = parseFloat(bmi).toFixed(2);
                viewModel.applicant.Bmi(bmi);
            }
        }
    });

    viewModel.applicant.Height.subscribe(function (d) {
        if (d) {
            if (viewModel.applicant.Weight) {
                var bmi = viewModel.applicant.Weight() / (viewModel.applicant.Height() * viewModel.applicant.Height());
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
        console.log(viewModel.isguardian());
    });
    viewModel.applicant.MomName.subscribe(function(d) {
        if (d == null || d === "") {
            viewModel.isguardian(true);
        } else {
            viewModel.isguardian(false);
        }
    });

    viewModel.applicant.PalapesInd.subscribe(function(d) {
        if (d) {
            var selected = ko.mapping.toJS(d);
            viewModel.ispalapes(selected);
        }
        console.log(viewModel.ispalapes());
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

    if (viewModel.applicant.BirthDate) {
        var splitdate = viewModel.applicant.BirthDate().split("-");
        var bday = splitdate[2].split("T");
        var bdate = splitdate[1] + "/" + bday[0] + "/" + splitdate[0];
        $('#birthdatepicker').data("DateTimePicker").date(bdate);
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

    viewModel.applicant.RaceCd.subscribe(function (d) {
        if (d) {
            loadEthnics(d);
        }
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
    loadSkills();
    loadMajorMinor();
    loadGrades();
    loadSubjects();


});