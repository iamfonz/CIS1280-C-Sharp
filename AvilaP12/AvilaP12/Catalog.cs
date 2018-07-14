//Alfonzo Avila     aavila28@cnm.edu
//File : Catalog.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP12
{
    /// <summary>
    /// Class object to represent a catalog of CatalogItem objects.
    /// </summary>
   public class Catalog
    {
        #region Full Properties and Fields
        //fields
        private List<CatalogItem> items;

        //properties
        /// <summary>
        /// Get/Set Items in Catalog.
        /// </summary>
        public List<CatalogItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default construcor for a Catalog of CatalogItem objects.
        /// </summary>
        public Catalog()
        {
            items = new List<CatalogItem>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Overridden ToString() for catalog details.
        /// </summary>
        /// <returns>Returns catalog items in a string formated as; Item#|SKU|Title|Description|Price</returns>
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
        #endregion
    }
}
