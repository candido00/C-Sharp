using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoAltoBaixo
{
    class Program
    {
        static void Main(string[] args)
        {
            Listar();
            Console.ReadKey();
        }
        static void Listar()
        {
            string nome, maisBaixo = "", maisAlto ="";
            double alturaInicial = 0, altura;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe {0}º nome: ", i+1);
                nome = Console.ReadLine();
                Console.WriteLine("Informe a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                if (altura > alturaInicial)
                {
                    alturaInicial = altura;
                    maisAlto = nome;
                    
                }
                if (altura < alturaInicial)
                {
                    maisBaixo = nome;
                }

            }
            Console.WriteLine("Mais alto: " + maisAlto);
            Console.WriteLine("Mais baixo: " + maisBaixo);
        }
    }
}
