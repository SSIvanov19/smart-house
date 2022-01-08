(function($){
      'use strict';
  
      var defaults = {
          topOffset: 400, //px - offset to switch of fixed position
          hideDuration: 300, //ms
          stickyClass: 'is-fixed'
      };
  
      $.fn.stickyPanel = function(options){
          if(this.length == 0) return this; // returns the current jQuery object
  
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
          function init(){
              settings = $.extend({}, defaults, options);
              animation.reverse = settings.hideDuration + 'ms';
              stickyClass = settings.stickyClass;
              $(window).on('scroll', onScroll).trigger('scroll');
          }
  
          // On scroll
          function onScroll() {
              if ( window.pageYOffset > settings.topOffset){
                  if (!isFixed){
                      isFixed = true;
                      self.addClass(stickyClass)
                          .css(animation.getStyle('normal'));
                  }
              } else {
                  if (isFixed){
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
  });
  
  ///////////////////////////////
  
  
  /////////////////////////////////////////////////////////////
  
  
  
  //////////////////////////////////////////////////////////////////////////////////////////
  
  $('.slider').each(function() {
    var $this = $(this);
    var $group = $this.find('.slide_group');
    var $slides = $this.find('.slide');
    var bulletArray = [];
    var currentIndex = 0;
    var timeout;
   
    function move(newIndex) {
      var animateLeft, slideLeft;
     
      advance();
     
      if ($group.is(':animated') || currentIndex === newIndex) {
        return;
      }
     
      bulletArray[currentIndex].removeClass('active');
      bulletArray[newIndex].addClass('active');
     
      if (newIndex > currentIndex) {
        slideLeft = '100%';
        animateLeft = '-100%';
      } else {
        slideLeft = '-100%';
        animateLeft = '100%';
      }
     
      $slides.eq(newIndex).css({
        display: 'block',
        left: slideLeft
      });
      $group.animate({
        left: animateLeft
      }, function() {
        $slides.eq(currentIndex).css({
          display: 'none'
        });
        $slides.eq(newIndex).css({
          left: 0
        });
        $group.css({
          left: 0
        });
        currentIndex = newIndex;
      });
    }
   
    function advance() {
      clearTimeout(timeout);
      timeout = setTimeout(function() {
        if (currentIndex < ($slides.length - 1)) {
          move(currentIndex + 1);
        } else {
          move(0);
        }
      }, 4000);
    }
   
    $('.next_btn').on('click', function() {
      if (currentIndex < ($slides.length - 1)) {
        move(currentIndex + 1);
      } else {
        move(0);
      }
    });
   
    $('.previous_btn').on('click', function() {
      if (currentIndex !== 0) {
        move(currentIndex - 1);
      } else {
        move(3);
      }
    });
   
    $.each($slides, function(index) {
      var $button = $('<a class="slide_btn">&bull;</a>');
     
      if (index === currentIndex) {
        $button.addClass('active');
      }
      $button.on('click', function() {
        move(index);
      }).appendTo('.slide_buttons');
      bulletArray.push($button);
    });
   
    advance();
  });
  
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
  $(document).ready(function(){
    // Add smooth scrolling to all links
    $("a").on('click', function(event) {
  
      // Make sure this.hash has a value before overriding default behavior
      if (this.hash !== "") {
        // Prevent default anchor click behavior
        event.preventDefault();
  
        // Store hash
        var hash = this.hash;
  
        // Using jQuery's animate() method to add smooth page scroll
        // The optional number (800) specifies the number of milliseconds it takes to scroll to the specified area
        $('html, body').animate({
          scrollTop: $(hash).offset().top
        }, 800, function(){
     
          // Add hash (#) to URL when done scrolling (default click behavior)
          window.location.hash = hash;
        });
      } // End if
    });
  });
