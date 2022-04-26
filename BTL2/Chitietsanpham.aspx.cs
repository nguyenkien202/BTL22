using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Chitietsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";


            }
            string id = Request.QueryString.Get("id");
            if(id!= null)
            {
                List<Product> ProductList = (List<Product>)Application["productlist"];
                List<Product> Producttinformation = new List<Product>();
                foreach( Product product in ProductList)
                {
                    if ( id == product.Id)
                    {
                        Producttinformation.Add(product);
                    }
                    ListViewProductinformation.DataSource = Producttinformation;
                    ListViewProductinformation.DataBind();
                }
            }
            else
            {
                Response.Redirect("Trangchu.aspx");
            }

        }
        protected void themgiohang2(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                string id = Request.QueryString.Get("id");
                if (Request.Cookies["cart"] == null)
                {
                    Response.Cookies["cart"].Value = $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {
                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                Themgio.InnerHtml = "Thêm sản phẩm thành công";
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }

        }
    }
}