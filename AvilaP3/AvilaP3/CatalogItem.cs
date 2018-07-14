using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP3
{
    class CatalogItem
    {

        private string sku;
        private string title;
        private string desc;
        private decimal price;

        public string GetSku()
        {
            return sku;

        }
        public void SetSku(string isku)
        {
            sku = isku;

        }

        public string GetTitle()
        {
            return title;

        }
        public void SetTitle (string titl)
        {
            title = titl;
        }

        public string GetDesc()
        {
            return desc;

        }
        public void SetDesc(string description)
        {
            desc = description;
        }

        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(Decimal pRice)
        {
            price = pRice;
        }

        public override string ToString()
        {
            return sku + " | " + title + " | " + desc + " | $" + price;
        }
    }
}
