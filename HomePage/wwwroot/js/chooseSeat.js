const seatItem = document.querySelectorAll(".seat-item");
var str = new Array();
var txt = "";

seatItem.forEach((seat, index) => {
    seat.addEventListener("click", () => {
        if (seat.checked === true) {
            // console.log(seat.value);
            str.push(seat.value); // Add thêm giá trị cho mảng
        } else {
            const pos = str.indexOf(seat.value); // Tìm trong mảng giá trị bằng seat.value
            str.splice(pos, 1); // Xóa giá trị trong mảng bằng pos số lượng là 1 phần tử
        }
        //console.log(str);
        str.forEach(convert);
        // document.querySelector("#seat-cus").value == txt;
        document.querySelector("#seat-cus").innerHTML = str;
        //document.querySelector("#total-price").innerHTML = str.length * 45000;
    });
});
function convert(value, index, array) {
    txt = txt + value + ",";
}


// 
const nomarlSeat = document.querySelectorAll(".normal-seat-index");
const vipSeat = document.querySelectorAll(".vip-seat-index");
const doubleSeat = document.querySelectorAll(".double-seat-index");

nomarlSeat.forEach((seat) => {
    seat.addEventListener("click", () => {
        seat.classList.toggle("normal-seat");
    });
});
vipSeat.forEach((seat) => {
    seat.addEventListener("click", () => {
        seat.classList.toggle("vip-seat");
    });
});
doubleSeat.forEach((seat) => {
    seat.addEventListener("click", () => {
        seat.classList.toggle("douple-seat");
    });
});
