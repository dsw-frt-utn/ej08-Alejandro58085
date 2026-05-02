using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
   public partial class ProductHelper
    {
        private string ObtenerProductoPrueba()
        {
            long code = 12023;
            string descripcion= "Teclado";
            decimal price = 123.99m;
            return ObtenerEtiquetaProducto(code, descripcion, price);
        }
    }
}
