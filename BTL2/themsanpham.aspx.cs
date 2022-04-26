using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{

        public partial class themsanpham :System.Web.UI.Page
        { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string id= Request.Form.Get("Images");
                string ten = Request.Form.Get("ten");
                string Price = Request.Form.Get("Price");
                Application["ProductList"] = new List<Product>();
                List<Product> ProductList = new List<Product>();
                int dem = 0;
                foreach(Product a in ProductList)
                {
                    if (id==a.Id)
                    {
                        dem = 1;
                        Response.Write("ID đã trùng không thể thêm ");
                        break;
                    }
                    if (dem == 0)
                    {
                        Product newsp = new Product(id, ten, Price);
                        ProductList.Add(newsp);
                        Application["ProductList"] = ProductList;

                    }
                    
                }
            }
        }
    }
}