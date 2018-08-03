// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {


    //Adding new application
    $('#addApp').hide();

    $('#newAppBtn').click(function () {
        $(this).hide();
        $('#addApp').show();
        $('#AppName').focus();
    });

    $('#cancelappbtn').click(function () {
        $('#addApp').hide();
        $('#newAppBtn').show();
    });


    //Login
    $(".log-btn").click(function() {
        var parentDiv = $(".login-form");
        var inputs = parentDiv.find("input");
        var userName = $(inputs[0]).val();
        var password = $(inputs[1]).val();
        var rememberMe = $(inputs[2]).val();
        var loginModel = {
            Email: userName,
            Password: password,
            RememberMe: rememberMe
        };

        $.ajax({
            url: "/Account/LoginUser",
            type: "POST",
            data: loginModel,
            dataType: "json",
            error: function (response) {
                alert(response.responseText);
            },
            success: function (response) {
                if (!response.success) {
                    $(".alert").show();
                } else {
                    var domain = window.location.href;
                    var position = domain.indexOf("/Account/Login");
                    domain = domain.substring(0, position) + "/App/List";
                    window.location.replace(domain);
                }
                  
            }

        });
    });



    //Copying App Id
    $('.appId').click(function () {

        var content = $(this).text().trim();
        var targetId = "_hiddenCopyText_";

        target = document.getElementById(targetId);
        if (!target) {
            var target = document.createElement("textarea");
            target.style.position = "absolute";
            target.style.left = "-9999px";
            target.style.top = "0";
            target.id = targetId;
            document.body.appendChild(target);
        }
        target.textContent = content;

        var currentFocus = document.activeElement;
        target.focus();
        target.setSelectionRange(0, target.value.length);

        if (document.execCommand('copy')) {
            alert('Copied to clipboard ' + content);
        }

        currentFocus.focus();
    });



    //Variable operations

    $('.updateValueBtn').click(function () {
        $('.overlay').css({ 'visibility': 'visible', 'opacity': '1' });
        $('#popup-addon').text($(this).attr('hidden-name'));
        $('#updateRequestBtn').attr('hidden-id', $(this).attr('hidden-id'));
    });

    $('.close').click(function () {
        $('.overlay').css({ 'visibility': 'hidden', 'opacity': '0' });
    });

    $('#updateRequestBtn').click(function () {
        var id = $(this).attr('hidden-id');
        var value = $('#newValue').val();
        var model = {
            Id: id,
            Value: value
        };

        $.ajax({
            url: "/AJAX/UpdateValue",
            type: "POST",
            data: model,
            dataType: "json",
            error: function (response) {
                alert(response.responseText);
            },
            success: function (response) {
                $('.close').click();
                $('.col-variable-value').each(function () {
                    var hiddenid = $(this).attr('hidden-id');
                    if (hiddenid === id) {
                        $(this).text(value);
                        $(this).parent().addClass('warning');
                    }
                });
            }

        });
    });
    $('.deleteValueBtn').click(function () {


        var id = $(this).attr('hidden-id');

        var model = {
            Id : id
        };

        $.ajax({
            url: "/AJAX/DeleteValue",
            type: "POST",
            data: model,
            dataType: "json",
            error: function (response) {
                alert(response.responseText);

            },
            success: function (response) {
                if (response.success === true) {
                    $(".valueTableRow").each(function () {
                        var hiddenid = $(this).attr("hidden-id");
                        if (hiddenid === response.values[0] || hiddenid === response.values[1]) {
                            $(this).remove();
                        }
                    });
                }
            }

        });
    });
});