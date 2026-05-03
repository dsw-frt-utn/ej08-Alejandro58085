using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
   public class RetailSale : Sale
    {
        public RetailSale(decimal cantidad) : base(cantidad) { }
        public override decimal CalculateTotal()
        {
            return cantidad_;
        }
    }
}
