const seatItem = document.querySelectorAll(".seat-item");
var str = new Array();
var txt = "";
var price = 0;

seatItem.forEach((seat, index) => {
    seat.addEventListener("click", () => {
        if (seat.checked === true) {
            addToSeat(seat.id);
            str.push(seat.value); // Add thêm giá trị cho mảng
            price += 9;
        } else {
            const pos = str.indexOf(seat.value); // Tìm trong mảng giá trị bằng seat.value
            str.splice(pos, 1); // Xóa giá trị trong mảng bằng pos số lượng là 1 phần tử
            delateToSeat(seat.id);
            price -= 9;
        }
        console.log(price);
        str.forEach(convert);
        // document.querySelector("#seat-cus").value == txt;
        document.querySelector("#seat-cus").innerHTML = str;
        document.querySelector("#TotalPrice").value = "$" + price;
        //document.querySelector("#total-price").innerHTML = str.length * 45000;
    });
});
function addToSeat(id) {
    $.ajax({
        url: '/CinemaSeat/AddSeat/' + id,
        type: 'GET'
    }).done(function (response) {
        alertify.success('Success add a seat');
    });
}
function delateToSeat(id) {
    $.ajax({
        url: '/CinemaSeat/RemoveSeat/' + id,
        type: 'GET'
    }).done(function (response) {
        alertify.success('Success remove a seat');
    });
}
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
