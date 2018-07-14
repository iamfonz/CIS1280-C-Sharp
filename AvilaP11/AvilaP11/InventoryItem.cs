using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP11
{
    class InventoryItem
    {
        public string Name { get; set; }

        public InventoryItem()
        {
            Name = "";
        }

        public InventoryItem(string n):this()
        {
            Name = n;
        }

       public override string ToString()
        {
            return Name;

        }
    }
}
