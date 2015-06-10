var viewModel;
var oTable;

$(function () {

    function loadCountry() {
        viewModel.countries.removeAll();
        $.ajax({
            type: 'POST',
            url: '/Common/GetCountries',
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
            url: '/Common/GetStates',
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
            url: '/Common/GetCities',
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
            url: '/Common/GetReligions',
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
            url: '/Common/GetRaces',
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
            url: '/Common/GetOccupations',
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
            url: '/Common/GetHighEducationLevel',
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
            url: '/Common/GetInstitutions',
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
            url: '/Common/GetEthnics',
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
            url: '/Common/GetSports',
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
            url: '/Common/GetAchivements',
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
            url: '/Common/GetAssociations',
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
                    url: '/Public/SubmitProfile',
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
            viewModel.sports.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removesport: function(d) {
            if (d) {
                viewModel.sports.remove(d);
            }
        },
        addkoko: function () {
            viewModel.kokos.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removekoko: function(d) {
            if (d) {
                viewModel.kokos.remove(d);
            }
        },
        addothersportnkoko: function () {
            viewModel.otherssportandassociations.push({ SportAssocId: ko.observable(0), AchievementCd: ko.observable(''), ApplicantSportAssocId: ko.observable(0) });
        },
        removeothersportnkoko: function(d) {
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
                    url: '/Public/SubmitSportAndKoko',
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
            console.log(ko.mapping.toJS(d));
            viewModel.isedusubject(true);
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

    ko.applyBindings(viewModel);

    $('#resume a').click(function (e) {
        e.preventDefault();
        $(this).tab('show');
    });
    $('#resume a[href="#peribadi"]').tab('show');
    $('#resume a:first').tab('show');

    $('#birthdatepicker').datetimepicker({
        format: 'DD/MM/YYYY'
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
});