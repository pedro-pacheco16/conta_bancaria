using Banco.Model;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using Banco.Controller;
using System.Runtime.CompilerServices;

namespace Banco
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {

            int opcao, agencia, tipo, aniversario;

            string? titular;

            decimal saldo, limite;

            ContaController contas = new();


            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumeros(), 123, 1, "Pedro", 1000, 500);
            contas.Cadastrar(cc1);

            ContaPpoupanca cp1 = new ContaPpoupanca(contas.GerarNumeros(), 123, 2, "luiz", 10000, 10);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("************************************************************************");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("                         BANCO DO BRAZIL COM Z                          ");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("                      1 - Criar Conta                                   ");
                Console.WriteLine("                      2 - Listar todas as Contas                        ");
                Console.WriteLine("                      3 - Buscar Conta por Numero                       ");
                Console.WriteLine("                      4 - Atualizar Dados da Conta                      ");
                Console.WriteLine("                      5 - Apagar Conta                                  ");
                Console.WriteLine("                      6 - Sacar                                         ");
                Console.WriteLine("                      7 - Depositar                                     ");
                Console.WriteLine("                      8 - Transferir valores entre Contas               ");
                Console.WriteLine("                      9 - Sair                                          ");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                             ");
                Console.WriteLine("                                                                        ");


                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.WriteLine("\nBanco doBrasil com Z - O seu Futuro começa aqui!");
                    sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Criar Conta\n\n");

                        Console.WriteLine("Digite o Número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Nome do Ttitular: ");
                        titular = Console.ReadLine();

                        titular ??= string.Empty;
                        do
                        {



                            Console.WriteLine("Digite o tipo da Conta: ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        }
                        while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o saldo: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());


                        switch (tipo)
                        {
                            case 1:

                                

                                Console.WriteLine("Digite o Limite da Conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());


                                contas.Cadastrar(new ContaCorrente(contas.GerarNumeros(), agencia, tipo, titular, saldo, limite));

                                break;


                            case 2:



                                Console.WriteLine("Digite o Aniversário da Conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());


                                

                                KeyPress();
                                break;


                        }
                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar todas as Contas\n\n");

                        contas.ListarTodas();

                        KeyPress();
                        break;

                    case 3:
                        Console.WriteLine("Buscar Conta por Numero\n\n");

                        KeyPress();
                        break;

                    case 4:
                        Console.WriteLine("Atualizar Dados da Conta\n\n");

                        KeyPress();
                        break;

                    case 5:
                        Console.WriteLine("Apagar Conta\n\n");

                        KeyPress();
                        break;

                    case 6:
                        Console.WriteLine("Sacar\n\n");

                        KeyPress();
                        break;

                    case 7:
                        Console.WriteLine("Depositar\n\n");

                        KeyPress();
                        break;

                    case 8:
                        Console.WriteLine("Transferir valores entre Contas\n\n");

                        KeyPress();
                        break;

                    case 9:
                        Console.WriteLine("Sair\n\n");
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida!\n");
                        break;
                }
            }
        }
        static void sobre()
        {
            Console.WriteLine("\n************************************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Pedro");
            Console.WriteLine("Pedro Augusto Pacheco de Souza Santos - pedroaugustopacheco16@gmail.com");
            Console.WriteLine("github.com/pedro-pacheco16");
            Console.WriteLine("************************************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...\"");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

    }
}
