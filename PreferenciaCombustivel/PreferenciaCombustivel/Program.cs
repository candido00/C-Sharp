using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreferenciaCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Preferencia();
            Console.ReadKey();
        }
        static void Preferencia()
        {
            int codigo, gasolina = 0, alcool = 0, diesel = 0;

            do
            {
                Console.WriteLine("Informe qual o combustivel de sua preferencia: 1-Alcool, 2-Gasolina, 3- Diesel, 4-Encerrar.");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    Console.WriteLine("Alcool");
                    alcool++;
                }
                else if (codigo == 2)
                {
                    Console.WriteLine("Gasolina");
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    Console.WriteLine("Diesel");
                    diesel++;
                }
                else if (codigo == 4)
                {
                    Console.WriteLine("Muito Obrigado!");
                    Console.WriteLine("Alcool: " + alcool + " Gasolina: " + gasolina + " Diesel: " + diesel);
                }

            } while (codigo != 4 || codigo <= 0 || codigo >= 5);

            
            



        }
    }
}
