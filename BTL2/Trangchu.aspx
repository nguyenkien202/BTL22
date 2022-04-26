<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="BTL2.Trangchu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Chủ</title>
    <link href="CSS/Trangchu.css" rel="stylesheet" />
    <script src="JS/Trangchu.js"></script>
	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
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
				<li> <input  type="search" id="timkiemsanpham" name="timkiem" runat="server" placeholder="Nhập sản phẩm cần tìm"/><button id="submit" runat="server">Tìm kiếm</button> </li>
				<a href="javascript:void(0);" style="font-size:35px;" class="icon" onclick="responsive() ">&#9776;</a>
			</ul>
		</div>
            </div>
	
	<div class="banner">		
		<img id="img" src="Anh/qc.jpg" width="auto">
	</div>

	<div class="sach">
		<div class="left">
			<div class="p_sach">
				
			</div>
		</div>
		<div class="right">
			<div class="p_sach">
				
			</div>
		</div>
	</div>
	
	<h1 class="h1"> Danh Sách Sản phẩm Bán Chạy</h1>
	<div class="sanpham">
		<asp:ListView ID="sanphambanchay" runat="server">
			<ItemTemplate>
				<div class="sanphambanchay">
					<a href="Chitietsanpham.aspx?id=<%# Eval("Id") %>">
					<img id="anh1" wight="200" height="80" src="<%# Eval("Images") %>" title="Sách"/>
					<div class="sanphambanchay_gia" id="sanpham1">
						<strong id="ten1"><%# Eval("Name")%></strong>
						<p id="gia1"><%# Eval("gia")%> Đồng</p>
					</div>
				</a>
				</div>
			</ItemTemplate>

		</asp:ListView>
	</div>

	
	<div class="tintucsach">
		<div class="tintuc">
			<div class="tintuc_1">
				<a href="#">
					<img src="Anh/tintuc1.jpg" title="Đồng Hồ">
					<h5>Cập nhật sách tham khảo cấp 1 theo chương trình mới</h5>
					<p>Đối với các bé mới khi vào lớp 1 hành trang kiến thức còn nhiều bỡ ngỡ...</p>
				</a>	
			</div>
		</div>
		<div class="tintuc">
			<div class="tintuc_1">
				<a href="#">
					<img src="Anh/tintuc2.jpg" title="Đồng Hồ">
					<h5>Tài liệu công phá đề thi 9 vào 10</h5>
					<p>Tiến vào cánh cửa cấp 3 mọi học sinh nên chuẩn bị cho mình trang ...</p>
				</a>	
			</div>
		</div>
		<div class="tintuc">
			<div class="tintuc_1">
				<a href="#">
					<img src="Anh/tintuc3.jpg" title="Đồng Hồ">
					<h5>Sách Học Tiếng Anh cực kỳ hiệu quả</h5>
					<p>Tiếng Anh bây giờ là ngôn ngữ vô cùng phổ biến trên thế giới vì vậy chúng ta nên  ...</p>
				</a>	
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
				    <li><a href="Baotri.aspx">Liên hệ</a></li>
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
