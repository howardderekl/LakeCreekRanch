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

        var contentString = '<div class="info-window">' +
            '<h3>Lake Creek Ranches</h3>' +
            '<div class="info-content">' +
            '<p>65 Lakota Loop, Troy, MT 59935.  Lake Creek Ranches is a gated community of custom 3 to 15 acre home sites located near Troy Montana in the beautiful Bull Lake Valley.</p>' +
            '</div>' +
            '</div>';

        var infowindow = new google.maps.InfoWindow({
            content: contentString,
            maxWidth: 400
        });

        marker.addListener('click', function () {
            infowindow.open(map, marker);
        });

    }

    google.maps.event.addDomListener(window, 'load', initMap);
});
