using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletControl
{
    class Program
    {
        static  int operacao, numeroContas = 1, decisao;
        static List<Conta> contas = new List<Conta>();
        static string [,] CadastrarContas = new string [numeroContas, 4];
        static string prioridade, pesquisarRelat;
        static double receitaFinal, valor;

        static void Main(string[] args)
        {
            MenuPrincipal();
            Console.ReadKey();
        }
        class Conta 
        {
        public string NomeConta;
        public double Valor;
        public string DataVencimento;
        public string prioridade;
        
        }

        static void MenuPrincipal()
        {

            Console.WriteLine("______________________________WALLET_CONTROL______________________________\n");
            Console.WriteLine("1 - CADASTRAR CONTAS. \n");
            Console.WriteLine("2 - LISTAR CONTAS. \n");
            Console.WriteLine("3 - PESQUISAR CONTAS POR PRIORIDADES. \n");
            Console.WriteLine("4 - PESQUISAR RELATORIO POR MES E ANO. \n");
            Console.WriteLine("5 - RECEITA.\n");
            Console.WriteLine("6 - CALCULADORA DE JUROS.\n");
            Console.WriteLine("0 - SAIR.\n");


            do
            {
                Console.WriteLine("INFORME A OPERAÇÃO DESEJADA.");
                operacao = Convert.ToInt32(Console.ReadLine());
            } while (operacao != 0 && operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6);




            switch (operacao)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Quantas contas deseja cadastrar");
                    numeroContas = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numeroContas; i++)
	                {
                        Conta Conta = new Conta();
                        Console.WriteLine("Informe o Nome da Conta: ");
                        Conta.NomeConta = Console.ReadLine().ToUpper();
                        Console.WriteLine("Informe Valor Conta: ");
                        Conta.Valor = Convert.ToDouble(Console.ReadLine());
                        SubtrairValorReceita(Conta.Valor);
                        Console.WriteLine("Informe dia Vencimento (DD/MM/AAAA): ");
                        //RESOLVER O DATE
                        Conta.DataVencimento = Console.ReadLine();
                        Console.WriteLine("Informe a Prioridade");
                        Conta.prioridade = Console.ReadLine().ToUpper();
                        Console.WriteLine("\n");
                    
                        contas.Add(Conta);
                    }
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 2:

                    Console.Clear();
                   foreach (var listar in contas)
	                {
                        Console.WriteLine(listar.NomeConta);
                        Console.WriteLine(listar.Valor);
                        Console.WriteLine(listar.DataVencimento);
                        Console.WriteLine(listar.prioridade);
                        Console.WriteLine("\n");
	                }
                    Console.WriteLine("Pressione uma tecla para HOME");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Informe a prioridade: baixa, media, alta: ");
                    prioridade = Console.ReadLine().ToUpper();
                    Console.Clear();

                   
                    List<Conta> contasPorPrioridade = contas.FindAll(conta2 => prioridade == conta2.prioridade);

                    foreach (var lista in contasPorPrioridade)
	                {

                        Console.WriteLine(lista.NomeConta);
                        Console.WriteLine(lista.Valor);
                        Console.WriteLine(lista.DataVencimento);
                        Console.WriteLine(lista.prioridade);
                        Console.WriteLine("\n");
	                }
                   

                    Console.WriteLine("Pressione uma tecla para HOME");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("Informe a data (DD/MM/AAAA) ");
                    pesquisarRelat = Console.ReadLine();

                    List<Conta> relatorio = contas.FindAll(conta3 => pesquisarRelat == conta3.DataVencimento);

                    foreach (var listarR in relatorio)
                    {
                        Console.WriteLine(listarR.NomeConta);
                        Console.WriteLine(listarR.Valor);
                        Console.WriteLine(listarR.DataVencimento);
                        Console.WriteLine(listarR.prioridade);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Pressione uma tecla para HOME");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar Receita.\n");
                    Console.WriteLine("2 - Mostrar Receita Atual.\n");
                    decisao = Convert.ToInt32(Console.ReadLine());
                    
                    if (decisao == 1)
	                {
                        Console.Clear();
                        Console.WriteLine("Informe sua receita: ");
                        double receita = Convert.ToDouble(Console.ReadLine());
                        receitaFinal += receita;
                        Console.Clear();
                        MenuPrincipal();
	                }
                    else
	                {
                        Console.Clear();
                        Console.WriteLine("Receita Atual: {0}\n", receitaFinal);
                        Console.WriteLine("Pressione uma tecla para HOME");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();
	                }

                    break;

                case 6:
                    CalculadoraJuros();

                    Console.WriteLine("Pressione uma tecla para HOME");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;


                default:
                    break;
            }

        }
        static void SubtrairValorReceita(double Valor){

            valor = Convert.ToDouble(Valor);
            receitaFinal -= valor;
        }
        static void CalculadoraJuros(){

            Console.Clear();
            Console.WriteLine("Informe o valor Inicial: ");
            double valorInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor dos Juros: ");
            double Juros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double calculoJuros = valorInicial * (Juros / 100);
            Console.WriteLine("O valor do juros é : {0} R$ \n", calculoJuros);
            double novoValor = Convert.ToDouble(valorInicial + calculoJuros);
            Console.WriteLine("O novo valor é {0} R$ \n", novoValor);

        }

    }

}
