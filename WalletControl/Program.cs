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
        static string prioridade, pesquisarRelat;
        static double receitaFinal, valor;

        static void Main(string[] args)
        {
            MenuPrincipal();
            Console.ReadKey();
        }
        class Conta 
        {
        public string nomeConta;
        public double valor;
        public string dataVencimento;
        public string prioridade;
        
        }

        static void MenuPrincipal()
        {

            Console.WriteLine("______________________________WALLET_CONTROL______________________________\n");
            Console.WriteLine("1 - CADASTRAR CONTAS. \n");
            Console.WriteLine("2 - LISTAR CONTAS. \n");
            Console.WriteLine("3 - PESQUISAR CONTAS POR PRIORIDADES. \n");
            Console.WriteLine("4 - PESQUISAR RELATORIO POR DATA. \n");
            Console.WriteLine("5 - RECEITA.\n");
            Console.WriteLine("6 - CALCULADORA DE JUROS.\n");
            Console.WriteLine("0 - SAIR.\n");

            try 
	        {
                do
            {
                Console.WriteLine("INFORME A OPERAÇÃO DESEJADA.");
                operacao = Convert.ToInt32(Console.ReadLine().Trim());
            } while (operacao != 0 && operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6);

	        }
	        catch (FormatException)
	        {
                Console.WriteLine("DIGITE APENAS NÚMEROS!");
                Console.WriteLine("");
                Console.WriteLine("PRESSIONE ENTER PARA HOME");
                Console.ReadLine();
                Console.Clear();
                MenuPrincipal();
	        }




            switch (operacao)
            {
                case 1:
                    try 
	                {

                        Console.Clear();
                        Console.WriteLine("Quantas contas deseja cadastrar?");
                        numeroContas = Convert.ToInt32(Console.ReadLine().Trim());
		
	                }
	                catch (FormatException)
	                {
                        Console.WriteLine("DIGITE APENAS NÚMEROS!");
                        Console.WriteLine("");
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadLine();
                        Console.Clear();
                        MenuPrincipal();
	                }

                    for (int i = 0; i < numeroContas; i++)
	                {
                        Conta Conta = new Conta();

                        Console.WriteLine("Informe o Nome da Conta: ");
                        Conta.nomeConta = Console.ReadLine().ToUpper();
                       
                        if (Conta.nomeConta == null || Conta.nomeConta == "")
	                    {
                            Console.WriteLine("VALOR NAO PODE SER NULO OU VAZIO!");
                            Console.WriteLine("");
                            Console.WriteLine("PRESSIONE ENTER PARA HOME");
                            Console.ReadLine();
                            Console.Clear();
                            MenuPrincipal();
	                    }

                        Console.WriteLine("Informe a Prioridade, baixa, media, alta: ");
                        Conta.prioridade = Console.ReadLine().ToUpper().Trim();

                        if (Conta.prioridade == null|| Conta.prioridade == "")
	                    {
                            Console.WriteLine("VALOR NAO PODE SER NULO OU VAZIO!");
                            Console.WriteLine("");
                            Console.WriteLine("PRESSIONE ENTER PARA HOME");
                            Console.ReadLine();
                            Console.Clear();
                            MenuPrincipal();
	                    }

                        try 
	                    {
                            Console.WriteLine("Informe Valor Conta: ");
                            Conta.valor = Convert.ToDouble(Console.ReadLine().Trim());
                            SubtrairValorReceita(Conta.valor);
                            Console.WriteLine("Informe Dia Vencimento (DD/MM/AAAA): ");
                            Conta.dataVencimento = Console.ReadLine().Trim();
                            
	                    }
	                    catch (FormatException)
	                    {
                            Console.WriteLine("DIGITE APENAS NÚMEROS!");
                            Console.WriteLine("");
                            Console.WriteLine("PRESSIONE ENTER PARA HOME");
                            Console.ReadLine();
                            Console.Clear();
                            MenuPrincipal();
	                    }
                        
                        Console.WriteLine("\n");
                    
                        contas.Add(Conta);
                    }
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 2:

                    if (contas.Count > 0)
	                {
                        Console.Clear();
                        foreach (var listar in contas)
	                    {
                            Console.WriteLine(listar.nomeConta);
                            Console.WriteLine(listar.valor);
                            Console.WriteLine(listar.dataVencimento);
                            Console.WriteLine(listar.prioridade);
                            Console.WriteLine("\n");
                            
	                    }
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();

	                }else
	                {
                        Console.Clear();
                        Console.WriteLine("NÃO EXISTEM CONTAS CADASTRADAS.");
                        Console.WriteLine("");
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();
	                }
                    break;
                    
                case 3:

                    Console.Clear();
                    Console.WriteLine("Informe a prioridade: baixa, media, alta: ");
                    prioridade = Console.ReadLine().ToUpper().Trim();
                    Console.Clear();

                   
                    List<Conta> contasPorPrioridade = contas.FindAll(conta2 => prioridade == conta2.prioridade);

                    if (contasPorPrioridade.Count > 0)
	                {
                        foreach (var lista in contasPorPrioridade)
	                    {

                        Console.WriteLine(lista.nomeConta);
                        Console.WriteLine(lista.valor);
                        Console.WriteLine(lista.dataVencimento);
                        Console.WriteLine(lista.prioridade);
                        Console.WriteLine("\n");

	                    }

	                }
                    else
	                {
                        Console.WriteLine("NAO EXISTEM CONTAS CADASTRADAS COM ESSA PRIORIDADE.");
                        Console.WriteLine("");
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();

	                }

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("Informe a data (DD/MM/AAAA) ");
                    pesquisarRelat = Console.ReadLine().Trim();
                    Console.Clear();

                    List<Conta> relatorio = contas.FindAll(conta3 => pesquisarRelat == conta3.dataVencimento);

                    if (relatorio.Count > 0)
	                {
                        foreach (var listarR in relatorio)
                        {

                            Console.WriteLine(listarR.nomeConta);
                            Console.WriteLine(listarR.valor);
                            Console.WriteLine(listarR.dataVencimento);
                            Console.WriteLine(listarR.prioridade);
                            Console.WriteLine("\n");
                        }

	                }
                    else
	                {

                        Console.WriteLine("NAO EXISTEM CONTAS CADASTRADAS NESTA DATA.");
                        Console.WriteLine("");
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();
	                }
                    break;

                case 5:
                    try 
	                {
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar Receita.\n");
                        Console.WriteLine("2 - Mostrar Receita Atual.\n");
                        decisao = Convert.ToInt32(Console.ReadLine().Trim());
                    
                        if (decisao == 1)
	                    {
                            Console.Clear();
                            Console.WriteLine("Informe sua receita: ");
                            double receita = Convert.ToDouble(Console.ReadLine().Trim());
                            receitaFinal += receita;
                            Console.Clear();
                            MenuPrincipal();
	                    }
                        else if (decisao == 2)
	                    {
                            Console.Clear();
                            Console.WriteLine("Receita Atual: {0}\n", receitaFinal);
                            Console.WriteLine("Pressione uma tecla para HOME");
                            Console.ReadKey();
                            Console.Clear();
                            MenuPrincipal();
	                    }else
	                    {
                            Console.WriteLine("OPÇÃO INVÁLIDA!!");
                            Console.WriteLine("");
                            Console.WriteLine("PRESSIONE ENTER PARA HOME");
                            Console.ReadLine();
                            Console.Clear();
                            MenuPrincipal();
	                    }
		
	                }
	                catch (FormatException)
	                {
                        Console.WriteLine("DIGITE APENAS NÚMEROS!");
                        Console.WriteLine("");
                        Console.WriteLine("PRESSIONE ENTER PARA HOME");
                        Console.ReadLine();
                        Console.Clear();
                        MenuPrincipal();
	                }
                    break;

                case 6:
                    CalculadoraJuros();

                    Console.WriteLine("PRESSIONE ENTER PARA HOME");
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

            try 
	        {
                Console.Clear();
                Console.WriteLine("Informe o valor Inicial: ");
                double valorInicial = Convert.ToDouble(Console.ReadLine().Trim());
                Console.WriteLine("Informe o valor dos Juros: ");
                double Juros = Convert.ToDouble(Console.ReadLine().Trim());
                Console.WriteLine("");
                double calculoJuros = valorInicial * (Juros / 100);
                Console.WriteLine("O VALOR DO JUROS É : {0} R$ \n", calculoJuros);
                double novoValor = Convert.ToDouble(valorInicial + calculoJuros);
                Console.WriteLine("O NOVO VALOR É : {0} R$ \n", novoValor);
	        }
	        catch (FormatException)
	        {
                Console.WriteLine("DIGITE APENAS NÚMEROS!");
                Console.WriteLine("");
                Console.WriteLine("PRESSIONE ENTER PARA HOME");
                Console.ReadLine();
                Console.Clear();
                MenuPrincipal();
	        }

        }

    }

}
