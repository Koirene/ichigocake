// Mail Ajax
// Brada js v1.0 by Angelo Mazzilli
// http://themeforest.net/user/AngeloM

$(document).ready(function () {
    $("#sendmail").click(function () {
        var valid = '';
        var isr = '';
        var name = $("#name").val();
        var phone = $("#phone").val();
        var subject = $("#subject").val();
        var mail = $("#mail").val();
        var message = $("#message").val();
        if (name.length < 1) {
            valid += '<br />İsim alanını doldurunuz!' + isr;
        }
        if (phone.length < 1) {
            valid += '<br />Telefon alanını doldurunuz!' + isr;
        }
        if (!mail.match(/^([a-z0-9._-]+@[a-z0-9._-]+\.[a-z]{2,4}$)/i)) {
            valid += '<br />Lütfen geçerli E-Posta Adresi Giriniz' + isr;
        }
        if (subject.length < 1) {
            valid += '<br />Mesajınızın konusu gereklidir!' + isr;
        }
        if (message.length < 1) {
            valid += '<br />Mesajınız gereklidir!' + isr;
        }
        if (valid != '') {
            $("#response").fadeToggle("slow");
            $("#response").html("Hata:" + valid);
        } else {
            var datastr = 'name=' + name + '&phone=' + phone + '&mail=' + mail + '&subject=' + subject + '&message=' + message;
            $("#response").css("display", "block");
            $("#response").html("Mesaj Gönderiliyor... ");
            $("#response").fadeOut("slow");
            setTimeout("send('" + datastr + "')", 2000);
        }
        return false;
    });

    $("#sendOrderBtn").click(function () {
        var valid = '';
        var isr = '';
        var cakeid = $("#CakeId").val();
        var name = $("#FullName").val();
        var phone = $("#Phone").val();
        var address = $("#Address").val();
        var email = $("#Email").val();
        var date = $("#RequestedDate").val();
        var time = $("#RequestedTime").val();
        var amount = $("#PersonAmount").val();
        if (name.length < 1) {
            valid += '<br />Lütfen isminizi ve soyisminizi girin.' + isr;
        }
        if (phone.length < 1) {
            valid += '<br />Telefon numarası gereklidir.' + isr;
        }
        if (!email.match(/^([a-z0-9._-]+@[a-z0-9._-]+\.[a-z]{2,4}$)/i)) {
            valid += '<br />Lütfen geçerli E-Posta Adresi Giriniz' + isr;
        }
        if (address.length < 1) {
            valid += '<br />Adres bilgisi gereklidir.' + isr;
        }
        if (date.length < 1) {
            valid += '<br />Etkinlik tarihi gereklidir.' + isr;
        }
        if (time.length < 1) {
            valid += '<br />Etkinlik saati gereklidir.' + isr;
        }
        if (amount.length < 1) {
            valid += '<br />Kişi Sayısı Gereklidir.' + isr;
        }
        if (valid != '') {
            $("#response").fadeToggle("slow");
            $("#response").html("Hata:" + valid);
        } else {
            var datastr = 'name=' + name + '&phone=' + phone + '&email=' + email + '&address=' + address + '&date=' + date + '&time=' + time + '&amount=' + amount;
            $("#response").css("display", "block");
            $("#response").html("Mesaj Gönderiliyor... ");
            $("#response").fadeOut("slow");
            setTimeout("sendOrder('" + datastr + "')", 2000);
        }
        return false;
    });
});

function send(datastr) {
    $.ajax({
        type: "POST",
        url: relativePath + "Home/SendMail?" + datastr,
        data: datastr,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (html) {
            $("#response-true").fadeIn("slow");
            $("#response-true").html(html);
            setTimeout('$("#response-true").fadeOut("slow")', 2000);
        }
    });
}

function sendOrder(datastr) {
    $.ajax({
        type: "POST",
        url: relativePath + "Cake/SendOrder?" + datastr,
        data: datastr,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (html) {
            $("#response-true").fadeIn("slow");
            $("#response-true").html(html);
            setTimeout('$("#response-true").fadeOut("slow")', 2000);
        }
    });
}

//AddAntiForgeryToken = function (data) {
//    data.__RequestVerificationToken = $('.antiForgeryToken_div input[name=__RequestVerificationToken]').val();
//    return data;
//};