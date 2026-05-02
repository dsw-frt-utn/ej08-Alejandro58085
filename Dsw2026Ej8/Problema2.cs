using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity <= 0 ? 0 : quantity * unitPrice;
            var producto = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total };
            return $"Resumen de Producto:\nCodigo: {producto.Code} - Descripcion:{producto.Description} - Total Producto:{producto.Total}";
        }
    }
}
