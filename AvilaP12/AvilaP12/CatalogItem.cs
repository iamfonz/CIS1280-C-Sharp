//Alfonzo Avila     aavila28@cnm.edu
//File : CatalogItem.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AvilaP12
{
    /// <summary>
    /// Object to represent a Catalog Item.
    /// </summary>
    public class CatalogItem
    {
        #region Constructors

        /// <summary>
        /// Default constructor. Sets all string values to "TBD" and 0.0M for price.
        /// </summary>
        public CatalogItem() : this("TBD", "TBD", "TBD", 0.0M)
        {

        }
        /// <summary>
        /// Overloaded constructor to create catalog item.
        /// </summary>
        /// <param name="isku">Item Sku</param>
        /// <param name="ititle">Item Title</param>
        /// <param name="idesc">Item Description</param>
        /// <param name="iprice">Item Price</param>
        public CatalogItem(string isku, string ititle, string idesc, decimal iprice)
        {
            sku = isku;
            title = ititle;
            desc = idesc;
            price = iprice;
        }
        #endregion

        #region Full Properties and Fields

        private int itemID;

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string sku;

        /// <summary>
        /// Get/Set Item Sku.
        /// </summary>
        public string Sku
        {
            get { return sku; }
            set
            {
                sku = value;
            }
        }

        private string title;
        /// <summary>
        /// Get/Set Item Title
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string desc;

        /// <summary>
        /// Get/Set Item Description
        /// </summary>
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private decimal price;
        /// <summary>
        /// Get/Set Item Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Overridden ToString()  
        /// </summary>
        /// <returns>Returns item details in format; SKU|Title|Description|Price</returns>
        public override string ToString()
        {
            return sku + " | " + title + " | " + desc + " | " + price.ToString("C");
            /* Returns
             * {Sku} | {Title} | {Description} | {Price}
             *  */
        }

        #endregion


    }

}
