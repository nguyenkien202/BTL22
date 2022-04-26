function check2() {
    var user = document.getElementById("user").value;
    var loi_tk = document.getElementById("loi_tk");
    let valid = true;
    if (user == "") {
        loi_tk.innerHTML = "Trường này không được bỏ trống ";
        valid = false;
    }
    return valid;
}