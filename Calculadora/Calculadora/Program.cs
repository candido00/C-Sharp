using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular();
            Console.ReadKey();

        }
        static void Calcular()
        {
            String operacao = "";
            float num1, num2, soma, subt, multip, div;

            Console.WriteLine("Informe qual operação quer fazer: + - x / : ");
            operacao = Console.ReadLine();
            Console.WriteLine("Informe o primeiro numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            switch (operacao)
            {

                case "+":
                    soma = (num1 + num2);
                    Console.WriteLine("A soma dos numeros é: " + soma);
                    break;

                case "-":
                    subt = (num1 - num2);
                    Console.WriteLine("A subtração dos numeros é: " + subt);
                    break;

                case "x":
                    multip = (num1 * num2);
                    Console.WriteLine("A multiplicação dos numeros é: " + multip);
                    break;

                case "/":
                    if (num2 == 0){
                        Console.WriteLine("Impossivel dividir!");
                        break;

                    }else{
                        div = (num1 / num2);
                        Console.WriteLine("A divisão dos numeros é: " + div);
                        break;
                    }
                    
            }
        } 
    }
}
