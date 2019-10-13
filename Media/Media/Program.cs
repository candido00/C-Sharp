using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota, nota2 = 0, media = 0;
            int count = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Informe a {0}º nota para calcular a media: ", i);
                nota = float.Parse(Console.ReadLine());
                nota2 += nota;                    

            }
            media = (nota2 / 4);

            if (media >= 0 && media < 4)
            {
                Console.WriteLine("A media do estudante é: " + media);
                Console.WriteLine("Reprovado, estude mais vagabundo!");
            }
            else if (media >= 4 && media < 7)
            {
                Console.WriteLine("A media do estudante é: " + media);
                Console.WriteLine("Recuperação, vai na fé que consegue!");
            }
            else if(media >= 7 && media <= 10)
            {
                Console.WriteLine("A media do estudante é: " + media);
                Console.WriteLine("Parabéns, aprovado!");
            }
            else if(media < 0)
            {
                Console.WriteLine("Media nao pode ser negativa!");
            }
            else if (media > 10)
            {
                Console.WriteLine("Media nao pode ser maior que 10!");
            }

            Console.ReadKey();

        }

        
    }
}
