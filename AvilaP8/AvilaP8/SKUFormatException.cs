//Alfonzo Avila     aavila28@cnm.edu
// File : SKUFormatException.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP8
{
    class SKUFormatException:Exception
    {
        public SKUFormatException():base ("The entered SKU is in the incorrect format.")
        {

        }
    }
}
