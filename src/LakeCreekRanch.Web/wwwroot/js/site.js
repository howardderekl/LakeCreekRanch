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

    // parallax scrolling with stellar.js
    $(window).stellar();

    // Website Map to the property
    function initMap() {

        var location = new google.maps.LatLng(48.362152, -115.837865);

        var mapCanvas = document.getElementById('map');
        var mapOptions = {
            center: location,
            zoom: 16,
            panControl: false,
            mapTypeId: 'hybrid'
        }
        var map = new google.maps.Map(mapCanvas, mapOptions);

        var markerImage = '../images/map-marker-icon.png';

        var marker = new google.maps.Marker({
            position: location,
            map: map,
            icon: markerImage
        });

    }

    google.maps.event.addDomListener(window, 'load', initMap);
});
