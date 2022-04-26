function check() {
    var user = document.getElementById("user").value;
    var pass = document.getElementById("pass").value;
    var loi_tk = document.getElementById("loi_tk");
    var loi_mk = document.getElementById("loi_mk");
    let invalid = true;
    if (user == "") {
        loi_tk.innerHTML = "Trường này không được bỏ trống";
        invalid = false;
    }
    if (pass == "") {
        loi_mk.innerHTML = "Trường này không được bỏ trống";
        invalid = false;
    } else if (pass.length <= 8) {
        loi_mk.innerHTML = "Password không được dưới 8 kí tự ";
        invalid = false;
    }
    return invalid;
}
function clickCounter() {
    if (localStorage.clickcount) {
        localStorage.clickcount = Number(localStorage.clickcount) + 1;
    } else {
        localStorage.clickcount = 1;
    }
    document.getElementById("demo").innerHTML = localStorage.clickcount;
    if (localStorage.clickcount >= 3) {
        aler("Bạn đã nhập sai quá 3 lần,Vui lòng nhập lại sau 1 phút");
        setTimeout("reload", 1000);

    }
}