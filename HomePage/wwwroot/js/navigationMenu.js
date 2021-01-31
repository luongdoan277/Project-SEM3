//navbar
window.addEventListener("scroll", function () {
    const navbar = document.querySelector(".navbars");
    navbar.classList.toggle("navbar-scroll", scrollY > 80);
});

const searchBtn = document.querySelector(".search-bt");
const formInput = document.querySelector(".navbar__searchItem");

searchBtn.addEventListener("click", function () {
    formInput.classList.toggle("form-active");
    searchBtn.classList.toggle("btn-active");
});


//navlinks

const navlinks = document.querySelectorAll('.link');


navlinks.forEach((link) => {
    link.addEventListener('click', function () {
        navlinks.forEach(link => {
            link.classList.remove('active');
        });
        link.classList.add('active');
    })
});

const navbarMenu = document.querySelector('.navbar__content');
const menuBtn = document.querySelector('.menu-btn');


menuBtn.addEventListener('click', function () {
    navbarMenu.classList.toggle('navbarContent-active');
});

