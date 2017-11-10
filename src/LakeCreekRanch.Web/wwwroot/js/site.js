$(function () {
    $(window).on("load resize", function () {
        $(".fill-screen").css("height", window.innerHeight - 50);
    });

    //Add Bootstraps scrollspy
    $('body').scrollspy({
        target: '.navbar',
        offset: 100
    });

    //Smooth Scrolling
    $('nav a, .down-button a').bind('click', function () {
        $('html, body').stop().animate({
            scrollTop: $($(this).attr('href')).offset().top - 75
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });
});
