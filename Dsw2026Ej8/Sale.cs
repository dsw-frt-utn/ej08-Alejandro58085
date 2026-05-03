using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal cantidad_;
        public Sale(decimal cantidad)
        {
            cantidad_ = cantidad;
        }
        public void SetCantidad(decimal cantidad)
        {
           cantidad_= cantidad;
        }
        public decimal GetCantidad()
        {
            return cantidad_;
        }
        public virtual decimal CalculateTotal()
        {
            return cantidad_;
        }
    }
}
