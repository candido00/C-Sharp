using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float baseR, altura, calculoArea;
            Console.WriteLine("Informe o valor da base do retangulo: ");
            baseR = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura do retangulo: ");
            altura = float.Parse(Console.ReadLine());
            calculoArea = (baseR * altura);

            Console.WriteLine("A area do retangulo é: " + calculoArea);

            if (baseR > altura)
            {
                Console.WriteLine("Base do retangulo é maior que a altura!");
            }
            else if (altura > baseR)
            {
                Console.WriteLine("Altura do retangulo é maior que a base!");
            }
            else if (baseR == altura)
            {
                Console.WriteLine("A base e a altura são iguais!");
            }
            Console.ReadKey();

        }
    }
}
