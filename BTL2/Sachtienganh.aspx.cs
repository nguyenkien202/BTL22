using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Sachtienganh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["usename"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }

            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> sachtienganh = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if ( id == "31" || id == "32" || id == "33" || id == "34" || id == "35" || id == "36" || id == "37" || id == "28" )
                {
                    sachtienganh.Add(product);
                }


            }
            sachtienganh1.DataSource = sachtienganh;
            sachtienganh1.DataBind();
        }
    }
}