using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy_Ex01
{
    public class Conta
    {
        private double saldo;

        public double Saldo { get => saldo; }

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public void Creditar(double valor)
        {
            this.saldo += valor;
        }

        public void Debitar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
