using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AvilaP12
{
    /// <summary>
    /// Interaction logic for ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        #region Full Properties and Fields
        private CatalogItem item;

        public CatalogItem Item
        {
            get { return item; }
            set { item = value; }
        }
        #endregion

        #region Constructors
        public ItemWindow(CatalogItem itm)
        {
            InitializeComponent();
            item = itm;
            txbSKU.Text = itm.Sku;
            txbTitle.Text = itm.Title;
            txbDescription.Text = itm.Desc;
            txbPrice.Text = itm.Price.ToString();

        }
        public ItemWindow():this(new CatalogItem())
        {

        }
        #endregion

        #region Button Events


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            item.Sku = txbSKU.Text;
            item.Title = txbTitle.Text;
            item.Desc = txbDescription.Text;
            item.Price = decimal.Parse(txbPrice.Text);
            DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
        #endregion
    }
}
