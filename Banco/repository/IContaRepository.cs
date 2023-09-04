using System;
using System.Collections.Generic;
using Banco.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.repository
{
    public interface IContaRepository
    {
        // métodos do CRUD
        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(conta conta);
        public void Atualizar(conta conta);
        public void Deletar(int numero);

        // método Bancários
        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);
    }
}
