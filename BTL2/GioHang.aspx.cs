using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                int soluot = Convert.ToInt32(Application["sogiohang"]);

                login.InnerHtml = "<p class='user'>Xin chào " + Session["usename"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";



                if (Request.Cookies["cart"] != null)
                {
                    List<Product> cartList = new List<Product>();
                    List<Product> productList = (List<Product>)Application["ProductList"];
                    string[] productsID = Request.Cookies["cart"].Value.Split(',');
                    foreach (string productID in productsID)
                    {
                        foreach (Product product in productList)
                        {
                            if (product.Id == productID)
                            {
                                soluot++;
                                cartList.Add(product);

                            }
                        }
                        sogiohang.InnerHtml = "<p> ( " + soluot +")</p>";
                    }
                    ListViewCart.DataSource = cartList;
                    ListViewCart.DataBind();
                    //Tính tiền sản phẩm 

                    int sanpham = 0;
                    
                    foreach (Product product in cartList) 
                    sanpham += Int32.Parse(product.Gia);
                    products_price.InnerHtml = $"{sanpham} <span class='cart__product-price-unit'>đ</span>";
                    
                    // Tính Tổng tiền tất cả 

                    int tongtien = sanpham;
                    order_total_price.InnerHtml = $"{tongtien} <span class='cart__product-price-unit'>đ</span>";

                }
                else
                {
                    Response.Redirect("Trangchu.aspx");
                }
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }
        }
    }
}