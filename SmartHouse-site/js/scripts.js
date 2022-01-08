const $dropdown = $(".dropdown");
const $dropdownToggle = $(".dropdown-toggle");
const $dropdownMenu = $(".dropdown-menu");
const showClass = "show";

$(window).on("load resize", function() {
    if (this.matchMedia("(min-width: 768px)").matches) {
        $dropdown.hover(
            function() {
                const $this = $(this);
                $this.addClass(showClass);
                $this.find($dropdownToggle).attr("aria-expanded", "true");
                $this.find($dropdownMenu).addClass(showClass);
            },
            function() {
                const $this = $(this);
                $this.removeClass(showClass);
                $this.find($dropdownToggle).attr("aria-expanded", "false");
                $this.find($dropdownMenu).removeClass(showClass);
            }
        );
    } else {
        $dropdown.off("mouseenter mouseleave");
    }
});

function scrollTo(px) {
    $('body').animate({ scrollTop: px }, "slow");
}

$(document).ready(function() {
    $('.back-to-top').on('click', function(e) {
        e.preventDefault();
        scrollTo(0);
    });
    $(window).on("scroll", function(e) {
        $('.back-to-top').toggleClass('show', $('body')[0].scrollTop > 500);
    });

    $(document).on('click', '.carousel-item .btn', function(e) {
        const href = this.getAttribute('href');
        if (href.indexOf('#') === 0 && href.slice(1)) {
            e.preventDefault();
            scrollTo($(href).offset().top);
        }
    })
});