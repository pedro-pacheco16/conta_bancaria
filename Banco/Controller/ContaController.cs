using Banco.Model;
using Banco.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Controller
{
    public class ContaController : IContaRepository
    {
        private readonly List<conta> listaContas = new();
        int numero = 0;

        //métodos do Crud
        public void Atualizar(conta conta)
        {
            var buscaConta = BuscarNaCollection(conta.GetNumero());

            if(buscaConta is not null)
            {
                var index = listaContas.IndexOf(buscaConta);

                listaContas[index] = conta;

                Console.WriteLine($"A conta número {conta.GetNumero()} foi atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine($"A conta número {numero} não foi encontrada!");
                numero = Convert.ToInt32(Console.ReadLine());

            }
            
        }

        public void Cadastrar(conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta número {conta.GetNumero()} foi criada com sucesso");
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (listaContas.Remove(conta) == true)
                Console.WriteLine($"A conta {numero} foi apagada com sucesso!");
            }
            else
            {
                Console.WriteLine($"A conta número {numero} não foi encontrada!");
                numero = Convert.ToInt32(Console.ReadLine());


            }
           
        }

        public void ListarTodas()
        {
            foreach(var conta in listaContas)
            {
                conta.Visualizar();
            }
        }

        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
                conta.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        //métodos Bancários

        public void Sacar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
                if(conta.Sacar(valor) == true)
                    Console.WriteLine($"O saque na conta numero {numero} foi efetuado com sucesso!");
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Depositar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                conta.Depositar(valor);
                Console.WriteLine($"O saque na conta numero {numero} foi efetuado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            var contaOrigem = BuscarNaCollection(numeroOrigem);
            var contaDestino = BuscarNaCollection(numeroDestino);

            if (contaOrigem is not null && contaDestino is not null)
            {
                if (contaOrigem.Sacar(valor) == true)

                    contaDestino.Depositar(valor);
                    Console.WriteLine($"A transferência foi efetuada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta de Origem e/ ou conta de Destino não foi encontrada!");
                Console.ResetColor();
            }
        }

        //Métodos Auxiliares

        public int GerarNumeros()
        {
            return ++numero;
        }

        //método para buscar um Objeto Conta especifico 
        public conta? BuscarNaCollection(int numero)
        {
            foreach(var conta in listaContas)
            {
                if (conta.GetNumero() == numero)
                {
                    return conta;
                }
                  
            }
            return null;
        }
    }
}
