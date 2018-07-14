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

namespace AvilaP11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<InventoryItem> invItems = new List<InventoryItem>();
        List<IInventoryCommand> commands = new List<IInventoryCommand>();

        public MainWindow()
        {           
            InitializeComponent();
            lbxItems.ItemsSource = invItems;
        }

        private void btnAddOne_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem newitem = new InventoryItem(txbItemName.Text);

            AddOneCommand one = new AddOneCommand(invItems, newitem);

            one.Do();
            commands.Add(one);
            //invItems = one.TargetList;

            lbxItems.Items.Refresh();

        }

        private void btnAddRandom_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem newitem = new InventoryItem(txbItemName.Text);
            AddMultipleCommand multi = new AddMultipleCommand(newitem, invItems);

            multi.Do();
            commands.Add(multi);
            //invItems = multi.TargetList;
            lbxItems.Items.Refresh();

        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            int last = commands.Count - 1;
            commands[last].Undo();
            commands.RemoveAt(last);

            lbxItems.Items.Refresh();
            
            

        }
    }
}
