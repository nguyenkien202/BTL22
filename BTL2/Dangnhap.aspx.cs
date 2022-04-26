using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String user = Request.Form.Get("user");
                String pass = Request.Form.Get("pass");
                int dem = 1;
                if (user != "" && pass != "")
                {
                    List<Nguoidung> users = (List<Nguoidung>)Application["Users"];

                    foreach (Nguoidung a in users)
                    {
                        if (user == a.usename)
                        {
                            dem = 0;
                            if (pass == a.password)
                            {
                                Session["usename"] = user;
                                Response.Redirect("Trangchu.aspx");
                                break;
                            }
                            else
                            {
                                loi_mk.InnerHtml = "Sai mật khẩu";
                                break;
                            }
                        }

                    }
                    if (dem == 1) { 
                            loilogin.InnerHtml = "<p text-align='center'>Tài khoản không tồn tại!</p>";
                        }
                    }
                }
            }
        }
    }
