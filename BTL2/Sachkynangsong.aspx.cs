using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Sachkynangsong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["usename"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }

            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> sachkynangsong = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "20" || id == "21" || id == "22" || id == "23" || id == "24" || id == "25" || id == "26" || id == "27" || id == "28" || id == "29" || id == "30")
                {
                    sachkynangsong.Add(product);
                }


            }
            sachkynangsong1.DataSource = sachkynangsong;
            sachkynangsong1.DataBind();
        }
    }
}