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
           
        }
    }
}
