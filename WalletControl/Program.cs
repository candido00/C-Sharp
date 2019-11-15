using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletControl
{
    class Program
    {
        static  int operacao, x = 0, numeroContas = 1;
        static string [,] CadastrarContas = new string [numeroContas, 4];

        static void Main(string[] args)
        {
            MenuPrincipal();
            Console.ReadKey();
        }

        static void MenuPrincipal()
        {
           

            Console.WriteLine("______________________________WALLET_CONTROL______________________________\n");
            Console.WriteLine("1 - CADASTRAR CONTAS. \n");
            Console.WriteLine("2 - LISTAR CONTAS. \n");
            Console.WriteLine("3 - PESQUISAR CONTAS POR PRIORIDADES. \n");
            Console.WriteLine("4 - PESQUISAR RELATORIO POR MES E ANO. \n");
            Console.WriteLine("5 - RECEITA.\n");
            Console.WriteLine("0 - SAIR.\n");


            do
            {
                Console.WriteLine("INFORME A OPERAÇÃO DESEJADA.");
                operacao = Convert.ToInt32(Console.ReadLine());
            } while (operacao != 0 && operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5);




            switch (operacao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Informe o Nome da Conta: ");
                    CadastrarContas[x, 0] = Console.ReadLine();
                    Console.WriteLine("Informe Valor Conta: ");
                    CadastrarContas[x, 1] = Console.ReadLine();
                    Console.WriteLine("Informe dia Vencimento: ");
                    //RESOLVER O DATE
                    CadastrarContas[x, 2] = Console.ReadLine();
                    Console.WriteLine("Informe a Prioridade");
                    CadastrarContas[x, 3] = Console.ReadLine();
                    Console.WriteLine("\n");
                    x++;
                    numeroContas++;


                    Console.Clear();
                    //AO INSTANCIAR O MENU ELE VEM VAZIO
                    MenuPrincipal();
                    break;

                case 2:

                    Console.Clear();
                    for (int y = 0; y < numeroContas; y++)
                    {
                        for (int z = 0; z < 4; z++)
                        {
                            Console.WriteLine(CadastrarContas[y, z].ToUpper());
                        }
                        Console.WriteLine("\n");
                       
                    }
                    Console.WriteLine("Pressione uma tecla para HOME");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 3:

                    Console.WriteLine("Informe a prioridade");
                    string prioridade = Console.ReadLine();

                    foreach (var listar in CadastrarContas)
                    {
                        if (prioridade == listar)
                        {
                            Console.WriteLine(listar.IndexOf("baixa"));
                        }
                    }
                    MenuPrincipal();

                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 0:
                    Environment.Exit(0);
                    break;


                default:
                    break;
            }

        }

    }
}
