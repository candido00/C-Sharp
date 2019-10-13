using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Media();
            Console.ReadKey();

        }
        static void Media()
        {
            int num1, count = 0;
            double soma = 0, mediaIdade = 0;


            Console.WriteLine("Informe uma idade para calcular a media: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 <= 0)
            {
                Console.WriteLine("Impossível calcular!!");

            }
            else
            {
                soma += num1;
                count++;

                while (true)
                {
                    Console.WriteLine("Informe outra idade para calcular a media: ");
                    num1 = int.Parse(Console.ReadLine());
                    if (num1 <= 0)
                    {
                        break;
                    }
                    soma += num1;
                    count++;
                }
            }

            mediaIdade = (soma / count);
            Console.WriteLine(soma);
            Console.WriteLine(count);
            Console.WriteLine(mediaIdade);
        }
    }
}
