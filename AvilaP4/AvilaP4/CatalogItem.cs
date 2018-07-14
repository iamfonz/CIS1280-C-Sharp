using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP4
{
    class CatalogItem
    {

        private string sku;
        public string Sku
        {
            get { return sku;}
            set { sku = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private decimal price;
        public decimal Price
        {
            get { return price;}
            set { price = value; }
        }

       
        public override string ToString()
        {
            return sku + " | " + title + " | " + desc + " | " + price.ToString("C");
        }




    }
}
