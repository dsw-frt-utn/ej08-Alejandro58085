namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba de problema 1
            ProductHelper producto = new ProductHelper();
            string etiqueta = producto.ObtenerEtiquetaProducto(12023, "Mouse", 123.99m);
            Console.WriteLine(etiqueta);
            //Prueba de problema 2
            Problema2 producto2 = new Problema2();
            string resumen = producto2.CrearResumenVenta(1234, "Teclado", 23, 1234.55m);
            Console.WriteLine(resumen);
            //Prueba de problema 3
            Product productprueba = new Product("Teclado");
            Problema3 problema3 = new Problema3();
            string comparar = problema3.CompararCopias(1234, productprueba);
            Console.WriteLine(comparar);



        }
    }
}
