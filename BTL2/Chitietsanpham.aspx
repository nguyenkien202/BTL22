<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chitietsanpham.aspx.cs" Inherits="BTL2.Chitietsanpham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chi Tiết Sản Phẩm</title>
    <script src="JS/Trangchu.js"></script>
    <link href="CSS/Chitietsanpham.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
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

		<div>
	<div class="main">
		<asp:ListView ID="ListViewProductinformation" runat="server" >
			<ItemTemplate>
				<div class="anh">
					<img src="<%# Eval("Images") %>" title="Ảnh Trưng Bày">
				</div>

				<div class="content">
					
					<h1 class="header-content"><%# Eval("Name") %></h1>
					<hr width="20px" />
					<p style="font-size:45px;color: #C89979;   " class="header-content"><b><%# Eval("Gia") %> đồng</b></p>
					<p class="header-content"><%# Eval("tieude") %>
					</p>
					<ul class="header-content">
						<li>Cam Đoan bảo hành 12 tháng nếu mua phải sách lậu</li>
						<li>Thu mua lại với giá cao </li>
					</ul>
				</ItemTemplate>
		</asp:ListView>
		<div class="submit">
			<p class="Themgio" name="Themgio" runat="server" id="Themgio" style="color:red"></p>
			<button type="submit" class="themvaogio" runat="server" ID="themgiohang1" onserverclick="themgiohang2"  >Thêm vào giỏ hàng</button>
		</div>
		</div>
		</div>


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
    </form>
</body>
</html>
