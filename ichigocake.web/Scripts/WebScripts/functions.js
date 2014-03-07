// JavaScript Functions
// Brada js v1.0 by Angelo Mazzilli
// http://themeforest.net/user/AngeloM

$(window).on("load resize",function () {
  var t=setTimeout(function() {

    /* --- Masonry --- */
    if (jQuery().isotope) {
      $(".masonry").isotope({
        itemSelector: ".item"
      });
      $(".menu-filters li a").click(function () {
        var selector = $(this).attr("data-filter");
        $(".masonry").isotope({
          itemSelector: ".item",
          filter: selector
        });
        return false;
      });
    }

  },500);

});

$(document).ready(function () {

  /* --- NiceScroll --- */
  $("html").niceScroll();

  /* --- Flexslider --- */
  $('.flexslider').flexslider({
    animation: 'slide',
    animationLoop: true,
	prevText: '<i class="icon-angle-left"></i>',
	nextText: '<i class="icon-angle-right"></i>',
	controlNav: false,
	touch: true
  });

  /* --- Fancybox --- */
  $(".fancybox").fancybox({
    openEffect: 'fade',
    closeEffect: 'fade',
    next: '<i class="icon-smile"></i>',
    prev: '<a title="Previous" class="fancybox-nav fancybox-prev" href="javascript:;"><span></span></a>'
  });

  /* --- Hover Effect --- */
    $('.masonry .item').mouseover(function() {
            $(this).siblings().css({ "opacity": "0.75", "-webkit-filter": "saturate(0%)" });
        })
        .mouseout(function() {
            $(this).siblings().css({ "opacity": "1", "-webkit-filter": "saturate(100%)" });
        });

  /* --- Active Filter Menu --- */
  $(".menu-filters a").click(function (e) {
    $(".menu-filters a").removeClass("active");
    $(this).addClass("active");
    e.preventDefault();
  });

  /* --- toTop --- */
  $('#toTop').click(function () {
    $('body,html').animate({
      scrollTop: 0
    }, 1000);
  });
  $(window).scroll(function () {
    if ($(this).scrollTop() != 0) {
      $('#toTop').fadeIn();
    } else {
      $('#toTop').fadeOut();
    }
  });

});