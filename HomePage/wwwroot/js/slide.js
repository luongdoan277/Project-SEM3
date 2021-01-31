//slide
const slides = document.querySelector('.slides');
const slide = document.querySelectorAll('.slide');
const nextBtn = document.querySelector('#next');
const prevBtn = document.querySelector('#prev');

slides.style.width = `${slide.length * 100}%`;

let counter = 0;

const IMG_WIDTH = 25;


function next() {
    if (counter < slide.length - 1) {
        counter++;
    } else {
        counter = 0;
    }

    slides.style.transform = `translateX(-${IMG_WIDTH * counter}%)`;
}

function prev() {
    if (counter === 0) {
        counter = slide.length - 1;
    } else {
        counter--;
    }
    slides.style.transform = `translateX(-${IMG_WIDTH * counter}%)`;
}

nextBtn.addEventListener('click', function () {
    next();
});


prevBtn.addEventListener('click', function () {
    prev();
});

setInterval(function () {
    next();
}, 9000);
