using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL2
{
    public class Product
    {
        private string ten;
        private string price;

        public Product(string id, string ten, string price)
        {
            Id = id;
            this.ten = ten;
            this.price = price;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Gia { get; set; }
        public string Images { get; set; }
        public string tieude { get; set; }
    }
}