//Alfonzo Avila     aavila28@cnm.edu
//File : Catalog.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP8
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
                new CatalogItem {Sku = "TSBLK00Sma", Title = "T-Shirt Black Small", Desc="Comfortable t-shirt in black size Small", Price = 6.99M},
                new CatalogItem {Sku = "TSBLK00Med", Title = "T-Shirt Black Medium", Desc="Comfortable t-shirt in black size Medium", Price = 6.99M},
                new CatalogItem {Sku = "TSBLK00Lar", Title = "T-Shirt Black Large", Desc="Comfortable t-shirt in black size Large", Price = 6.99M},


            };
        }


        public override string ToString()
        {
            string results;
            results = "\n                  *******Items*******\n" +
                                "\nItem #  |  SKU  |   Title   |   Description   |   Price\n";

            for (int i = 0; i < items.Count; ++i)
            {
                results += (i + 1) + "|" + items[i].ToString() + "\n";
            }


            return results;
        }

    }
}
