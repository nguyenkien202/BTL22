﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL2
{
    public partial class timkiem2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            timkiem.DataSource=timkiem;
            timkiem.DataBind();
        }
    }
}