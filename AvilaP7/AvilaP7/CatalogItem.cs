//Alfonzo Avila     aavila28@cnm.edu
//File : CatalogItem.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AvilaP7
{
    class CatalogItem
    {
        public CatalogItem() : this("TBD", "TBD", "TBD", 0.0M)
        {

        }

        public CatalogItem(string isku, string ititle, string idesc, decimal iprice)
        {
            sku = isku;
            title = ititle;
            desc = idesc;
            price = iprice;
        }




        private string sku;
        public string Sku
        {
            get { return sku; }
            set
            {
                string pattern = @"^[a-z0-9A-Z]{10,20}$";
                if (Regex.IsMatch(value, pattern))
                {
                    sku = value;
                }
                else
                {
                    throw new SKUFormatException();
                }
            }
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
            get { return price; }
            set { price = value; }
        }


        public override string ToString()
        {
            return sku + "|" + title + "|" + desc + "|" + price.ToString("C");
        }




    }

}
