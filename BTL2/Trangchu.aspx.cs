using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Trangchu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (Session["usename"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["usename"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }

           

            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> banchay = new List<Product>();
            List<Product> timkiem = new List<Product>();
            string tensp = Request.Form["timkiemsanpham"];

            if (IsPostBack)
            {
                foreach(Product product in ProductList)
 
                if (tensp== product.Name){
                        timkiem.Add(product);              
                        Response.Redirect("timkiem.aspx");
                    }
               
            }


            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "1" || id == "2" || id == "3" || id == "4" || id == "5" || id == "6" || id == "7" || id == "8" )
                {
                    banchay.Add(product);
                }
                

            }
            sanphambanchay.DataSource = banchay;
            sanphambanchay.DataBind();
            

        }
    }
}