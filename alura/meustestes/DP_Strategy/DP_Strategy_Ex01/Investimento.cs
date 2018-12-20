using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy_Ex01
{
    public interface Investimento
    {
        double CalculaRendimento(Conta contaCorrente);
    }

    public class Conservador : Investimento
    {
        public double CalculaRendimento(Conta contaCorrente)
        {
            return contaCorrente.Saldo * (0.8 / 100.00);
        }
    }

    public class Moderado : Investimento
    {
        public double CalculaRendimento(Conta contaCorrente)
        {
            double taxa;

            if (new Random().Next(100) > 50)
            {
                taxa = (0.7 / 100.00);
            }
            else
            {
                taxa = (2.5 / 100.00);
            }
            return contaCorrente.Saldo * taxa;
        }
    }

    public class Arrojado : Investimento
    {
        public double CalculaRendimento(Conta contaCorrente)
        {
            int chance = new Random().Next(100);
            double taxa;

            if (chance <= 20)
            {
                taxa = (5 / 100.00);
            }
            else if (chance > 20 && chance <= 50)
            {
                taxa = (3 / 100.00);
            }
            else
            {
                taxa = (0.6 / 100.00);
            }
            return contaCorrente.Saldo * taxa;
        }
    }
}
