using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Sachvanhoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usename"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["usename"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }

            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> sachvanhoc = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "41" || id == "42" || id == "43" || id == "44" || id == "45"  )
                {
                    sachvanhoc.Add(product);
                }


            }
            sachvanhoc1.DataSource = sachvanhoc;
            sachvanhoc1.DataBind();
        }
    }
}