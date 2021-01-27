// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    const yearField = $('#Year');

    if (yearField) {
        let date = yearField.attr('data-data');

        yearField.val(date);
    }
}