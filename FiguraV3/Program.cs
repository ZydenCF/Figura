using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraV3
{
    public class Program
    {
        public static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecciona la figura para calcular el área:");
                Console.WriteLine("1. Rectangulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Triangulo");

                int opcion = int.Parse(Console.ReadLine());
                Figura figura = null;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce la base:");
                        float b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura:");
                        float h = float.Parse(Console.ReadLine());
                        figura = new Rectangulo(b, h);
                        break;

                    case 2:
                        Console.WriteLine("Introduce el lado del cuadrado:");
                        float L = float.Parse(Console.ReadLine());
                        figura = new Cuadrado(L);
                        break;

                    case 3:
                        Console.WriteLine("Introduce el radio del círculo:");
                        float r = float.Parse(Console.ReadLine());
                        figura = new Circulo(r);
                        break;

                    case 4:
                        Console.WriteLine("Introduce la base del triángulo:");
                        float bT = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura:");
                        float hT = float.Parse(Console.ReadLine());
                        figura = new Triangulo(bT, hT);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }

                Console.WriteLine($"El área de la figura seleccionada es: {figura.CalculateArea()}");

                Console.WriteLine("¿Quieres calcular otra figura? (si/no)");
                continuar = Console.ReadLine() == "si";
            }
        }
    }
}
