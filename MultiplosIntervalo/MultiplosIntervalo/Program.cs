using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Intervalo();
            Console.ReadKey();
        }
        static void Intervalo()
        {
            int num1, num2, num3;

            Console.WriteLine("Informe o divisor do intervalo: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 1º numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º numero: ");
            num3 = int.Parse(Console.ReadLine());

            for (int i = num2; i < num3; i++)
            {
                if (i % num1 ==0)
                {
                    Console.WriteLine(i);
                }

            }
            for (int i = num3; i < num2; i++)
            {
                if (i % num1 == 0)
                {
                    Console.WriteLine(i);
                }

            }


        }
    }
}
