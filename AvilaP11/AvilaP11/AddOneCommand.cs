using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP11
{
    class AddOneCommand:IInventoryCommand
    {
        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        public AddOneCommand(List<InventoryItem> list, InventoryItem it)
        {
            TargetList = list;
            Item = it;

        }


        public void Do()
        {
            TargetList.Add(Item);
        }

        public void Undo()
        {
            TargetList.Remove(Item);
        }

    }
}
