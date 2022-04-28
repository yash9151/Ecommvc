﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function readURL(input) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();                      //Preview of Image
        reader.onload = function (e) {
            $("img#imgpreview").attr("src", e.target.result).width(200).height(200);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

