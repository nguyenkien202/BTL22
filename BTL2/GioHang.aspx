<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="BTL2.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giỏ Hàng</title>
    <link href="CSS/Giohang.css" rel="stylesheet" />
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
				<li><a href="Giohang.aspx">Giỏ hàng</a><p class="sogiohang" id="sogiohang" runat="server"></p></li>

				<a href="javascript:void(0);" style="font-size:35px;" class="icon" onclick="responsive() ">&#9776;</a>
			</ul>
		</div>
            </div>
	<div class="GioHang">
		
		<div class="ThemSp">
			<table class="bang">
						<tr>
							<th>Ảnh</th>
							<th>Tên sản phẩm</th>
							<th>Giá</th>
							<th>Tác vụ</th>
						</tr>
			<asp:ListView ID="ListViewCart" runat="server">
				<ItemTemplate>
						<tr>
							<td class="td1"><img src= "<%# Eval("Images") %>" class="anh" /></td>
							<td><p><%# Eval("Name") %></p></td>
							<td><p><%# Eval("Gia") %> đồng</p></td>
							<td><a href="Xoagiohang.aspx?id=<%#Eval("Id")%>" class="xoa"><button class="xoa">Xóa</button></a></td>
						</tr>
				</ItemTemplate>
			</asp:ListView>
			</table>
		</div>
		<div class="ThanhToan">
			<div class="Bang-tt">
                    <h2 class="tt-donhang">Đơn hàng<br></h2>
                    <div class="tinhtongtien">
                        <p>Tổng tiền sản phẩm</p>
                        <p runat="server" id="products_price">0 <span class="cart__product-price-unit">đ</span></p>
                    </div>
                  
                    <div class="thanhtien">
                        <p>Tổng cộng: </p>
                        <p runat="server" id="order_total_price">0 <span class="cart__product-price-unit">đ</span></p>
                    </div>
                    <div class="cart__buttons--right">
                        <button class="button" type="button">Thanh toán</button>
                    </div>
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
