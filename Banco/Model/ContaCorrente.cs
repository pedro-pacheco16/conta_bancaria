using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaCorrente : conta
    {
        private int limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo,int limite) : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public int GetLimite()
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
