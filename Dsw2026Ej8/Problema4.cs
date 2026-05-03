using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            
            if (!nota1.HasValue && !nota2.HasValue && !nota3.HasValue)
                return 0;
            
            if (nota1.HasValue && (nota1.Value < 0 || nota1.Value >= 10))
            {
                nota1 = null;
            }
            if (nota2.HasValue && (nota2.Value < 0 || nota2.Value >= 10))
            {
                nota2 = null;
            }
            if (nota3.HasValue && (nota3.Value < 0 || nota3.Value >= 10))
            {
                nota3 = null;
            }

            if (!nota1.HasValue && !nota2.HasValue && !nota3.HasValue)
                return 0;
            double suma = 0;
            int cantidad = 0;

            if (nota1.HasValue) { suma += nota1.Value; cantidad++; }
            if (nota2.HasValue) { suma += nota2.Value; cantidad++; }
            if (nota3.HasValue) { suma += nota3.Value; cantidad++; }
            return suma / cantidad;

        }
    }
}
