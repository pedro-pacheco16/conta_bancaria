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
            throw new NotImplementedException();
        }

        public void Cadastrar(conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta número {conta.GetNumero()} foi criada com sucesso");
        }

        public void Deletar(int numero)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        //métodos Bancários

        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }

        //Métodos Auxiliares

        public int GerarNumeros()
        {
            return ++numero;
        }

    }
}
