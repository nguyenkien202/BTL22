using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL2
{
    public class cart :Product
    {
        public int thanhtoan { get; set; }
        public cart(string id, string name, string Gia, string images, int thanhtoan)
        {
            this.Id = id;
            this.Name = name;
            this.Gia = Gia;
            this.Images = images;
            this.thanhtoan = thanhtoan;
        }
    }
}