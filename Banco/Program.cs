using Banco.Model;
using System;

namespace Banco
{
    internal class Program
    {
            private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {


            int opcao;

            conta c1 = new conta(1, 123, 1, "Pedro", 1000000.00M);

            c1.SetTipo(2);
            c1.Visualizar();
            c1.SetAgencia(457);
            c1.Visualizar();

            c1.Sacar(10000);
            c1.Visualizar();

            c1.Depositar(20000);

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

                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar todas as Contas\n\n");

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
                  }  while (consoleKeyInfo.Key != ConsoleKey.Enter);
                  }
     
    }        
}
