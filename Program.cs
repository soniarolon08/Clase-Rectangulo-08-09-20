using System;

namespace ClaseRectangulo_08_09       
{
    class Rectangulo
    {
        static void Main(string[] args)
        {
            double perim; a;
            
            int vBase, vAltura;

            Console.writeline("Ingrese el valor de la Base del rectangulo: ")
            vBase = int.Parse(Console.ReadLine());
            Console.writeline("Ingrese el valor de la Altura del rectangulo: ")
            vAltura = int.Parse(Console.ReadLine());

            Rectangulo objRect = new Rectangulo();

            a = objRect.calcularArea();
            Console.writeline("El valor del Área es: {0}", a);

            perim = objRect.calcularPerimetro();
            Console.writeline("El valor del Perimetro es: {0}", perim);
            
            Console.ReadKey();
        }
    }
}