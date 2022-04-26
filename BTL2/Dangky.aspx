<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangky.aspx.cs" Inherits="BTL2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký</title>
    <link href="CSS/Trangchu.css" rel="stylesheet" />
    <link href="CSS/Dangky.css" rel="stylesheet" />
    <script src="JS/kiemtra2.js"></script>
</head>
<body>
      <div class ="header" >
            <div class="header_top" id="header-top">
                <p> Web Bán sách </p>
                <div id="login" class="login" runat="server"> 
                   <p class="user"></p>
                   <a href="Dangnhap.aspx" title="Đăng Nhâp">Đăng Nhập</a>
	
                </div>
			</div>
                <div class="header_mid">
			<a href="Trangchu.aspx">
				<img width="100" height="80" src="Anh/LoGo.jpg" title="LoGo">
			</a>
		</div>
            
                <div class="header_bot" id="header-bot">
			<ul>
				<li><a href="Trangchu.aspx">Trang chủ</a></li>
				<li><a href="Sachkynangsong.aspx">Sách Kỹ Năng Sống</a></li>
				<li><a href="SachTiengAnh.aspx">Sách Tiếng Anh</a></li>
				<li><a href="SachVanHoc.aspx">Sách Văn Học</a></li>
				<li><a href="Giohang.aspx">Giỏ hàng</a></li>
				<a href="javascript:void(0);" style="font-size:35px;" class="icon" onclick="responsive() ">&#9776;</a>
			</ul>
		</div>
            </div>
    <form action="Dangky.aspx" runat="server" method="post" onsubmit="return check2()">
        <div class="dangki-tt">
            <h2>Đăng ký</h2>
			<br />
			<p id="login2" runat="server"></p>
			<div class="form-dk">
            <span>Tài khoản</span>
            <input type="text" name="user" value="" id="user" placeholder="Nhập tài khoản"  />
            <lable id="loi_tk" runat="server">*</lable>
		    </div>
            <br />
			<div class="form-dk">
            <span>Password</span>
            <input type="password" name="pass" value="" id="pass" placeholder="Nhập mật khẩu"  />
            <lable id="loi_mk" runat="server">*</lable>
			</div>
            <br />
			<div class="form-dk">
            <span>Repass&nbsp&nbsp&nbsp</span>
            <input type="password" name="repass" value="" id="repass" placeholder="Nhập lại mật khẩu"  />
            <lable id="loi_mk2" runat="server">*</lable>
		    </div>
            <br />
			<div class="form-dk">
            <span>email&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span>
            <input type="email" name="email" value="" id="email" placeholder="Nhập email"  />
            <lable id="l_email" runat="server">*</lable>
			</div>
			<br />
			<br />
			<div class="form-dk">
            <button id="btnlogin" runat="server" value="LƯU">Lưu</button>
            <button id="btnlogin1" runat="server" value="go_around"><a href="Trangchu.aspx">Back Home</a></button>
			</div>
        </div>
    </form>
    <div class="footter">
		<div class="footter_top">
			<div class="Thongtinlienhe">
				<h1>Thông Tin Liên Hệ</h1>
				<p>Địa chỉ: Định Công, Hoàng Mai, Hà Nội	</p>
				<p>SĐT: 19101009</p>
				<p>Gmail: abc1234@gmail.com</p>
			</div>
			<div class="Lienket">
				<h1>Liên Kết</h1>
				<ul>
					
				    <li><a href="Sachkynangsong.aspx">Sách Kỹ Năng Sống</a></li>
				    <li><a href="SachTiengAnh.aspx">Sách Tiếng Anh</a></li>
				    <li><a href="SachVanHoc.aspx">Sách Văn Học</a></li>
				    <li><a href="Lienhe.aspx">Liên hệ</a></li>
				</ul>
			</div>
			<div class="Lienket">
				<h1>Hỗ Trợ</h1>
				<ul>
					<li><a href="#">Hướng dẫn mua hàng</a></li>
					<li><a href="#">Hướng dẫn thanh toán</a></li>
					<li><a href="#">Chính sách bảo hành</a></li>
					<li><a href="#">Chính sách đổi trả</a></li>
					<li><a href="#">Tư vấn khách hàng</a></li>
				</ul>
			</div>
		</div>
	
	</div>
</body>
</html>
