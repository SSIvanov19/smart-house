(function ($) {
    'use strict';

    var defaults = {
        topOffset: 400, //px - offset to switch of fixed position
        hideDuration: 300, //ms
        stickyClass: 'is-fixed'
    };

    $.fn.stickyPanel = function (options) {
        if (this.length == 0) return this; // returns the current jQuery object

        var self = this,
            settings,
            isFixed = false, //state of panel
            stickyClass,
            animation = {
                normal: self.css('animationDuration'), //show duration
                reverse: '', //hide duration
                getStyle: function (type) {
                    return {
                        animationDirection: type,
                        animationDuration: this[type]
                    };
                }
            };

        // Init carousel
        function init() {
            settings = $.extend({}, defaults, options);
            animation.reverse = settings.hideDuration + 'ms';
            stickyClass = settings.stickyClass;
            $(window).on('scroll', onScroll).trigger('scroll');
        }

        // On scroll
        function onScroll() {
            if (window.pageYOffset > settings.topOffset) {
                if (!isFixed) {
                    isFixed = true;
                    self.addClass(stickyClass)
                        .css(animation.getStyle('normal'));
                }
            } else {
                if (isFixed) {
                    isFixed = false;

                    self.removeClass(stickyClass)
                        .each(function (index, e) {
                            void e.offsetWidth;
                        })
                        .addClass(stickyClass)
                        .css(animation.getStyle('reverse'));

                    setTimeout(function () {
                        self.removeClass(stickyClass);
                    }, settings.hideDuration);
                }
            }
        }

        init();

        return this;
    }
})(jQuery);


//run
$(function () {
    $('#fixed').stickyPanel();

     //Get the modal
    var modal = document.getElementById('myModal');

    // // Get the image and insert it inside the modal - use its "alt" text as a caption
    var img = document.getElementById('myImg');
    var modalImg = document.getElementById("img01");
    var captionText = document.getElementById("caption");
    img.onclick = function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    }

    // // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
    modal.style.display = "none";
    }


});

///////////////////////////////

function openCity(evt, cityName) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}

/****************************************************************************************************************************************************/