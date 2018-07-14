using System.Windows;
using System.Configuration;
using System.Data.SqlClient;



namespace AvilaP12
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
            DataBind();
            dataGrid.ItemsSource = catalog.Items;
        }



        #region Data Methods 

        private void DataBind()
        {
            catalog.Items.Clear();
            string connStr = ConfigurationManager.ConnectionStrings["CatalogDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Catalog", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CatalogItem newItem = new CatalogItem();
                    newItem.Sku = dr["SKU"].ToString();
                    newItem.Title = dr["Title"].ToString();
                    newItem.Desc = dr["Description"].ToString();
                    newItem.Price = decimal.Parse(dr["Price"].ToString());
                    newItem.ItemID = int.Parse(dr["ItemId"].ToString());
                    catalog.Items.Add(newItem);
                }
            }

        }

        private void AddData(CatalogItem newItem)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CatalogDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Catalog VALUES (@SKU, @Title, @Description, @Price);", conn);
                cmd.Parameters.AddWithValue("SKU", newItem.Sku);
                cmd.Parameters.AddWithValue("Title", newItem.Title);
                cmd.Parameters.AddWithValue("Description", newItem.Desc);
                cmd.Parameters.AddWithValue("Price", newItem.Price);
                cmd.ExecuteNonQuery();


            }
        }

        private void DeleteData(CatalogItem itm)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CatalogDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Catalog WHERE ItemId = @ItemId;", conn);
                cmd.Parameters.AddWithValue("ItemId", itm.ItemID);
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateData(CatalogItem itm)
        {
            string connStr = ConfigurationManager.ConnectionStrings["CatalogDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Catalog SET SKU = @SKU, Title = @Title, 
                               Description =@Description, Price = @Price WHERE ItemId = @ItemID", conn);
                cmd.Parameters.AddWithValue("SKU", itm.Sku);
                cmd.Parameters.AddWithValue("Title", itm.Title);
                cmd.Parameters.AddWithValue("Description", itm.Desc);
                cmd.Parameters.AddWithValue("Price", itm.Price);
                cmd.Parameters.AddWithValue("ItemId", itm.ItemID);
                cmd.ExecuteNonQuery();
            }
        }



        #endregion

        #region Event Handlers
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CatalogItem newItem = new CatalogItem();


            ItemWindow itemWin = new ItemWindow(newItem);
            itemWin.ShowDialog();

            if(itemWin.DialogResult==true)
            {
                AddData(newItem);
                DataBind();
                dataGrid.Items.Refresh();
            }
            else
            {
               MessageBox.Show("Unable to add item to catalog.");
                

            }
        }
       

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem is CatalogItem)
            {
                CatalogItem itm = (CatalogItem)dataGrid.SelectedItem;
                ItemWindow itemWin = new ItemWindow(itm);
                itemWin.ShowDialog();
                if(itemWin.DialogResult == true)
                {
                    UpdateData(itm);
                    DataBind();
                    dataGrid.Items.Refresh();

                }
                else
                {
                    MessageBox.Show("Unable to update item");
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem is CatalogItem)
            {
                CatalogItem itm = (CatalogItem)dataGrid.SelectedItem;
                DeleteData(itm);
                DataBind();
                dataGrid.Items.Refresh();

            }
        }
        #endregion
    }
}
