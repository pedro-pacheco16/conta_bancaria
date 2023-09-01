using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaPpoupanca : conta
    {
        private int aniversario;

        public ContaPpoupanca(int numero, int agencia, int tipo, string titular, decimal saldo,int aniversario) : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public int Getaniversario()
        {
            return aniversario;
        }

        public void Setaniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversario da Conta:{this.aniversario}");
        }


    }
}
