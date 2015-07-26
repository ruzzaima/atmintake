$(function () {
    $('.eduyear').val(function () {
        if (this.value === '0') {
            return '';
        }
        else {
            return this.value;

        }
    });
})