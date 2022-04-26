function check2() {
    var user = document.getElementById("user").value;
    var pass = document.getElementById("pass").value;
    var repass = document.getElementById("repass").value;
    var email = document.getElementById("email").value;
    var loi_tk = document.getElementById("loi_tk");
    var loi_mk = document.getElementById("loi_mk");
    var loi_mk2 = document.getElementById("loi_mk2");
    var l_email = document.getElementById("l_email");
    let valid = true;
    if (user == "") {
        loi_tk.innerHTML = "<p color='red'>Trường này không được bỏ trống</p> ";
        valid = false;
    }
    if (pass == "") {
        loi_mk.innerHTML = "<p color='red'>Trường này không được bỏ trống</p> ";
        valid = false;
    }else if (pass.length <= 8) {
        loi_mk.innerHTML = "Mật khẩu không được dưới 9 kí tự";
        valid = false;
    }
    if (repass == "") {
        loi_mk2 = "<p color='red'>Trường này không được bỏ trống</p> ";
        valid = false;
    }
    if (repass == pass) {
        loi_mk2.innerHTML = "ok";
        valid = true;
    }
    if (repass != pass) {
        loi_mk2.innerHTML = "Mật khẩu không khớp";
        valid = false;
    }
    if (email == "") {
        l_email.innerHTML = "<p color='red'>Trường này không được bỏ trống</p> ";
        valid = false;
    } else {
        valid = true;
    }
    return valid;
}