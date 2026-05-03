using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal cantidad) : base(cantidad) { }
        public override decimal CalculateTotal()
        {
            return cantidad_ * 0.90m;
        }
    }
}
