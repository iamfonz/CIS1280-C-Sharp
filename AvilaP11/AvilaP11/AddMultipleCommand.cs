using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP11
{
    class AddMultipleCommand:IInventoryCommand
    {
        private int number;

        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        public AddMultipleCommand()
        {
            Item = new InventoryItem();
            TargetList = new List<InventoryItem>();
            Random rand = new Random();
            number = rand.Next(1, 6);
        }

        public AddMultipleCommand(InventoryItem it, List<InventoryItem> list):this()
        {
            Item = it;
            TargetList = list;

        }


        public void Do()
        {
           
            for(int i = 0; i<number; ++i)
            {
                
                TargetList.Add(Item);

            }
        }

        public void Undo()
        {
            for(int i = 0;i<number; ++i)
            {
                
                TargetList.Remove(Item);
            }
        }



    }
}
