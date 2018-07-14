using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP7
{
    class SKUFormatException:Exception
    {
        public SKUFormatException():base ("The entered SKU is in the incorrect format.")
        {

        }
    }
}
