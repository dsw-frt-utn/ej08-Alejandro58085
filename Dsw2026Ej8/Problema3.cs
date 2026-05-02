using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia_ = originalValue;
            copia_++;
            Product productoCopia = product;
            productoCopia.SetDescription("Nueva Descripcion");

            return $"Valor Original: {originalValue} - Valor copia: {copia_} - Descripcion: {productoCopia.description_}";
        }

    }
}
