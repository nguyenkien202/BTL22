<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="BTL2.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="CSS/Trangchu.css" rel="stylesheet" />
    <link href="CSS/Dangnhap.css" rel="stylesheet" />
    <script src="JS/kiemtradn.js"></script>
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
    <form action="Dangnhap.aspx" runat="server" method="post" onsubmit=" return check()">
        <div id="dangnhap-tt">
            <h1>Đăng nhập</h1>
			<br />
			<lable id="loilogin" runat="server"></lable>
			<br />
			<br />
            <div class="form-tt">
            <span>Tài khoản</span>
            <input type="text" name="user" id="user" value="" required /><lable id="loi_tk" runat="server">Bắt buộc</lable>
            </div>
             <br />
            <div class="form-tt">
            <span>Mật khẩu</span>
            <input type="password" name="pass" id="pass" value="" required /><lable id="loi_mk" runat="server">Bắt buộc</lable>
            </div>
            <br />
			<div class="form-tt">
				<p id="demo" runat="server">

				</p>            <button id="btnsubmit" runat="server" value="Đăng nhập" onclick="clickCounter()">Đăng nhập</button>
            <button id="dangki" runat="server" value="Đăng ký" ><a href="Dangky.aspx">Đăng kí</a></button>
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
