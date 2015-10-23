jQuery.extend(jQuery.validator.messages, {
    required: "Diperlukan.",
    remote: "Please fix this field.",
    email: "Emel tidak sah.",
    url: "Please enter a valid URL.",
    date: "Tarikh tidak sah.",
    dateISO: "Please enter a valid date (ISO).",
    number: "Nombor tidak sah.",
    digits: "Please enter only digits.",
    creditcard: "Please enter a valid credit card number.",
    equalTo: "Please enter the same value again.",
    accept: "Please enter a value with a valid extension.",
    maxlength: jQuery.validator.format("Sila masukkan maklumat jangan lebih dari {0} perkataan."),
    minlength: jQuery.validator.format("Sila masukkan sekurang-kurangnya {0} perkataan."),
    rangelength: jQuery.validator.format("Please enter a value between {0} and {1} characters long."),
    range: jQuery.validator.format("Please enter a value between {0} and {1}."),
    max: jQuery.validator.format("Sila masukkan angka kurang atau sama {0}."),
    min: jQuery.validator.format("Sila masukkan angka lebih atau sama {0}.")
});