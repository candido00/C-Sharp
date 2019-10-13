using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Potencia();
            Console.ReadKey();

        }
        static void Potencia()
        {
            int num1 = 1;
            double calcPoten;

            do
            {
                Console.WriteLine("Informe um numero para calcular a potencia: ");
                num1 = int.Parse(Console.ReadLine());
                calcPoten = Math.Pow(num1, 2);
                if (num1 != 0)
                {
                    Console.WriteLine(calcPoten);
                }

            } while (num1 != 0);


        }
    }
}
