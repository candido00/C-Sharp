using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado, perimetro;
            Console.WriteLine("Informe o valor do lado para calcular o perimetro do quadrado: ");
            lado = float.Parse(Console.ReadLine());
            perimetro = (lado * 4);
            Console.WriteLine("O valor total do perimetro é: " + perimetro);

            Console.ReadKey();
        }
    }
}
