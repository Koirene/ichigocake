// Mail Ajax
// Brada js v1.0 by Angelo Mazzilli
// http://themeforest.net/user/AngeloM

$(document).ready(function () {
  $("#sendmail").click(function () {
    var valid = '';
    var isr = '';
    var name = $("#name").val();
    var city = $("#city").val();
    var subject = $("#subject").val();
    var mail = $("#mail").val();
    var message = $("#message").val();
    if (name.length < 1) {
      valid += '<br />Name required' + isr;
    }
    if (city.length < 1) {
      valid += '<br />City required' + isr;
    }
    if (!mail.match(/^([a-z0-9._-]+@[a-z0-9._-]+\.[a-z]{2,4}$)/i)) {
      valid += '<br />A valid Email' + isr;
    }
    if (subject.length < 1) {
      valid += '<br />Subject required' + isr;
    }
    if (message.length < 1) {
      valid += '<br />Message required' + isr;
    }
    if (valid != '') {
      $("#response").fadeToggle("slow");
      $("#response").html("Error:" + valid);
    } else {
      var datastr = 'name=' + name + '&city=' + city + '&mail=' + mail + '&subject=' + subject + '&message=' + message;
      $("#response").css("display", "block");
      $("#response").html("Sending message... ");
      $("#response").fadeOut("slow");
      setTimeout("send('" + datastr + "')", 2000);
    }
    return false;
  });
});

function send(datastr) {
  $.ajax({
    type: "POST",
    url: "mail.php",
    data: datastr,
    cache: false,
    success: function (html) {
      $("#response-true").fadeIn("slow");
      $("#response-true").html(html);
      setTimeout('$("#response-true").fadeOut("slow")', 2000);
    }
  });
}