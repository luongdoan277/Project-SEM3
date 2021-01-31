//ontop

const btnTop = document.querySelector('.btn-top');

window.addEventListener('scroll', function () {
    btnTop.classList.toggle('active-btn', scrollY > 100);
});

btnTop.addEventListener('click', function () {
    window.scrollTo({
        top: 0,
        behavior: 'smooth'
    })
});
