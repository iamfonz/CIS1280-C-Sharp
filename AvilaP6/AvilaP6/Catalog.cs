//TODO: -3 no comment header
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP6
{
    class Catalog
    {
        //fields
        private List<CatalogItem> items;

        //properties
        public List<CatalogItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        //constructors
        public Catalog()
        {
            items = new List<CatalogItem>()
            {
                new CatalogItem {Sku = "TSBLK S", Title = "T-Shirt Black Small", Desc="Comfortable t-shirt in black size Small", Price = 6.99M},
                new CatalogItem {Sku = "TSBLK M", Title = "T-Shirt Black Medium", Desc="Comfortable t-shirt in black size Medium", Price = 6.99M},
                new CatalogItem {Sku = "TSBLK L", Title = "T-Shirt Black Large", Desc="Comfortable t-shirt in black size Large", Price = 6.99M},


            };
        }


        public override string ToString()
        {
            string results;
            results = "\n                  *******Items*******\n" +
                                "\nItem #  |  SKU  |   Title   |   Description   |   Price\n";

            for (int i = 0; i < items.Count; ++i)
            {
                results += (i+1)+"|"+ items[i].ToString() + "\n";
            }


            return results;
        }

    }
}
