//Alfonzo Avila     aavila28@cnm.edu
//File : MainWindow.xaml.cs
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AvilaP8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Catalog catalog = new Catalog();
        public MainWindow()
        {
            InitializeComponent();
            lsbProducts.ItemsSource = catalog.Items;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lsbProducts.SelectedIndex >= 0)
            {
                int item;
                item = lsbProducts.SelectedIndex;
                catalog.Items.RemoveAt(item);
                txbStatus.Text = "Item succesfully removed from catalog.";
                lsbProducts.Items.Refresh();

            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {


            CatalogItem temp = new CatalogItem();
            bool skuok = true;

            try
            {
                temp.Sku = txbSKU.Text;
            }
            catch (SKUFormatException exe)
            {
                txbStatus.Text = exe.Message + " Item not added.";
                skuok = false;
            }

            if (skuok == true)
            {
                temp.Title = txbTitle.Text;
                temp.Desc = txbDescription.Text;
                temp.Price = decimal.Parse(txbPrice.Text);
                catalog.Items.Add(temp);


                lsbProducts.Items.Refresh();
                txbStatus.Text = "The item successfully added to the catalog.";


                txbSKU.Clear();
                txbPrice.Clear();
                txbDescription.Clear();
                txbTitle.Clear();

            }



        }

        private void lsbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = lsbProducts.SelectedIndex;
            if (selected >= 0)
            {
                CatalogItem temp = catalog.Items[selected];

                txbSKU.Text = temp.Sku;
                txbTitle.Text = temp.Title;
                txbDescription.Text = temp.Desc;
                txbPrice.Text = System.Convert.ToString(temp.Price);
            }

            else
            {
                txbSKU.Clear();
                txbPrice.Clear();
                txbDescription.Clear();
                txbTitle.Clear();
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbSKU.Clear();
            txbPrice.Clear();
            txbDescription.Clear();
            txbTitle.Clear();
        }
    }
}
