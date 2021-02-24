const floorItem = document.querySelectorAll(".floors__item");
const imgFloor = document.querySelectorAll(".img-floors > img");
const MallMap = document.querySelector(".mall-map");

const floorMap = document.querySelector(".floor-map");
const closeMap = document.querySelector(".close-map");

MallMap.addEventListener("click", function () {
    floorMap.classList.remove("un-active-map");
    floorMap.classList.add("active-map");
    console.log('dasd');
});

closeMap.addEventListener("click", function () {
    floorMap.classList.remove("active-map");
    floorMap.classList.add("un-active-map");
});

floorItem.forEach((floor, index) => {
    floor.addEventListener("click", function () {
        imgFloor.forEach((img) => {
            img.classList.remove("active-img");
        });
        imgFloor[index].classList.add("active-img");
    });
});
