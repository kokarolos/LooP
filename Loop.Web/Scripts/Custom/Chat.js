﻿$(function () {
    $("#addClass").on('click',function (event) {
        event.preventDefault();
        $('#sidebar_secondary').addClass('popup-box-on');
    });

    $("#removeClass").on('click',function (event) {
        event.preventDefault();
        $('#sidebar_secondary').removeClass('popup-box-on');
    });
})

$(function () {
    // Reference the auto-generated proxy for the hub.
    var chat = $.connection.chatHub;
    // Create a function that the hub can call back to display messages.
    chat.client.addNewMessageToPage = function (name, message) {
        let time = new Date();
        if (name == "kokarolos@gmail.com") {
            // Add the message to the page.
            $('#chat').append('<div class="chat_message_wrapper">' +
                '<div class="chat_user_avatar">' +
                '<a href="https://web.facebook.com/iamgurdeeposahan" target="_blank">' +
                '<img alt="Gurdeep Osahan (Web Designer)" title="Gurdeep Osahan (Web Designer)"' +
                'src="http://webncc.in/img/user/gurdeep-singh-osahan.jpg" class="md-user-image"</a></div>' +
                '<ul class="chat_message">' +
                '<li><p>' + name + " : " + htmlEncode(message) + 
                '<span class="chat_message_time">' + time.getHours() + ':' + time.getMinutes() + '</span>' +
                '</p ></li ></ul ></div > ');

        }
        else if (name != "kokarolos@gmail.com") {
            // Add the message to the page.
            $('#chat').append('<div class="chat_message_wrapper chat_message_right">' +
                '<div class="chat_user_avatar">' +
                '<a href="https://web.facebook.com/iamgurdeeposahan" target="_blank">' +
                '<img alt="Gurdeep Osahan (Web Designer)" title="Gurdeep Osahan (Web Designer)"' +
                'src="http://webncc.in/img/user/gurdeep-singh-osahan.jpg" class="md-user-image"</a></div>' +
                '<ul class="chat_message">' +
                '<li><p>' + name + " : " + htmlEncode(message) + 
                '<span class="chat_message_time">'+ time.getHours() + ':' + time.getMinutes() +'</span>'+
                '</p ></li ></ul ></div > ');
                //'<span><i class="ti-check"></i><i class="ti-check">' + time.getHours() + ':' + time.getMinutes() + '</i></span></div></li>');
        }

    };
    // Get the user name and store it to prepend to messages.

    //$('#displayname').val(prompt('Enter your name:', ''));
    $("#form").on("submit", function (event) {
        event.preventDefault();
    });

   // var name = "@User.Identity.GetUserName()";
    var name = 'kokarolos@gmail.com';
    $('#displayname').val(name);
    // Set initial focus to message input box.
    $('#message').focus();
    // Start the connection.
    $.connection.hub.start().done(function () {
        $('#sendmessage').click(function () {
            // Call the Send method on the hub.
            chat.server.send($('#displayname').val(), $('#message').val());
            // Clear text box and reset focus for next comment.
            $('#message').val('').focus();
        });
    });
});
// This optional function html-encodes messages for display in the page.
function htmlEncode(value) {
    var encodedValue = $('<div />').text(value).html();
    return encodedValue;
} 