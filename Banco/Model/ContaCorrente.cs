using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaCorrente : conta
    {
        private decimal limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo,decimal limite) : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite()
        {
            return limite;
        }

        public void SetLimite(int Limite)
        {
            this.limite = limite;
        }
        public override bool Sacar(decimal valor)
        {

            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("\n Saldo Insuficiente!");
                return false;
            }

            this.SetSaldo(this.GetSaldo() + this.limite - valor);
            return true;
        }
        public override void Visualizar()
        {
            
            base.Visualizar();
            Console.WriteLine($"Limite Conta Corrente:{this.limite}");
        }
    }
    
}
