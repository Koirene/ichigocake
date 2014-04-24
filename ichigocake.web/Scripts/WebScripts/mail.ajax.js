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
});

function send(datastr) {
  $.ajax({
    type: "POST",
    url: relativePath + "Home/SendMail",
    data:datastr,
    contentType: "application/json; charset=utf-8",
    dataType: "json",
    success: function (html) {
      $("#response-true").fadeIn("slow");
      $("#response-true").html(html);
      setTimeout('$("#response-true").fadeOut("slow")', 2000);
    }
  });
}