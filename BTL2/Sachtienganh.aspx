<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sachtienganh.aspx.cs" Inherits="BTL2.Sachtienganh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sách Tiếng Anh</title>
    <link href="CSS/Sachtienganh.css" rel="stylesheet" />
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
		
	<div class="up">
        <div class="abc">
            <a href="Trangchu.aspx"><strong>TRANG CHỦ</strong></a> / <a href="Sachtienganh.aspx"><strong>Sách Tiếng Anh</strong></a>
        </div>
    </div>
    <div class="container">
        <div class="sidebar_one">
            <div class="row_1">
                <strong>Danh mục sản phẩm khác</strong>
                <div class="show">
                    <ul>
                        <li><a href="Sachkynangsong.aspx">Sách Kỹ Năng Sống</a></li>
				        <li><a href="SachVanHoc.aspx">Sách Văn Học</a></li>
                    </ul>
                </div>
            </div>
            <div class="row_2"></div>
            <div class="row_3"></div>
        </div>
        <div class="sidebar_two">
            <div class="sanpham">
                <asp:ListView ID="sachtienganh1" runat="server">
                    <ItemTemplate>
                        <a href="Chitietsanpham.aspx?id=<%# Eval("Id") %>">
                            <div class="sanpham_show">
                                <img src="<%# Eval("Images") %>" alt="ảnh lỗi">
                                <div class="sanpham_gia">
                                    <strong><%# Eval("Name") %></strong>
                                    <p><%# Eval("gia") %> đồng</p>
                                </div>
                            </div>
                        </a>
                    </ItemTemplate>
                </asp:ListView>
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
</body>
</html>
