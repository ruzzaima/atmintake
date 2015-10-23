
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

function loadInstitutions(category) {
    viewModel.institutions.removeAll();
    $.ajax({
        type: 'POST',
        url: server + '/Common/GetInstitutions',
        data: JSON.stringify({ category: category }),
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

function loadSkills(category) {
    viewModel.skills.removeAll();
    $.ajax({
        type: 'POST',
        url: server + '/Common/GetSkills',
        data: JSON.stringify({ category: category }),
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

function loadChecklist(applicantid, acquisitionid) {
    $.ajax({
        type: 'POST',
        url: server + '/Common/GetChecklist',
        data: JSON.stringify({ applicantid: applicantid, acquisitionid: acquisitionid }),
        contentType: "application/json; charset=utf-8",
        success: function (msg) {
            var valp = msg.point;
            var vale = msg.edu;
            var vals = msg.spo;
            var vala = msg.sas;
            var valc = msg.chd;
            initializeChecklist(valp, vale, valc, vals, vala, true);
        },
        error: function (xhr) {
        }
    });
}

function loadZones() {
    viewModel.zones.removeAll();
    $.ajax({
        type: 'POST',
        url: server + '/Common/GetZones',
        contentType: "application/json; charset=utf-8",
        success: function (msg) {
            if (msg.OK) {
                var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                $.each(list, function (i, v) {
                    viewModel.zones.push(v);
                });
            }
        },
        error: function (xhr) {
        }
    });
}

function loadMaritalStatus(servicecodes) {
    viewModel.maritalstatues.removeAll();
    $.ajax({
        type: 'POST',
        url: server + '/Common/GetMaritalStatus',
        data: JSON.stringify({ servicecodes: servicecodes }),
        contentType: "application/json; charset=utf-8",
        success: function (msg) {
            if (msg.OK) {
                var list = ko.mapping.toJS(ko.mapping.fromJSON(msg.list));
                $.each(list, function (i, v) {
                    viewModel.maritalstatues.push(v);
                });
            }
        },
        error: function (xhr) {
        }
    });
}