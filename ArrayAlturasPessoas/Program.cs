using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlturasPessoas
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
            double[] alturaPessoas = new double[3];

            for (int i = 0; i < alturaPessoas.Length; i++)
            {
                Console.WriteLine("Informe a altura de três pessoas: ");
                alturaPessoas[i] = double.Parse(Console.ReadLine());
            }

            foreach (var listarAltura in alturaPessoas)
            {
                Console.WriteLine("Altura: {0}  ", listarAltura.ToString("N2"));
            }




        }
    }
}
