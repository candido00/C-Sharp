using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1416, volume, raio, calculoRaio, altura;
            Console.WriteLine("Informe o valor do raio para calcular o volume do cilindro: ");
            raio = double.Parse( Console.ReadLine());
            Console.WriteLine("Informe o valor da altura para calcular o volume do cilindro: ");
            altura = double.Parse(Console.ReadLine());
            calculoRaio = Math.Pow(raio, 2);
            volume = (pi * calculoRaio * altura);
            Console.WriteLine("O volume total do cilindro é: " + volume);

            Console.ReadKey();


            

        }
    }
}
