using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy_Ex01
{
    class RealizadorInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.CalculaRendimento(conta);
            conta.Creditar(resultado * 0.75);
            Console.WriteLine($"Novo saldo: {conta.Saldo}");
        }
    }
}
