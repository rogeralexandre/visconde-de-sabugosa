using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //double valor;

            Conta contaCorrente = new Conta(1000);

            Conservador conservador = new Conservador();

            RealizadorInvestimentos realizador = new RealizadorInvestimentos();

            Console.WriteLine($"Saldo anterior: {contaCorrente.Saldo}");
            realizador.Realiza(contaCorrente, conservador);
            
            Console.ReadKey();

            Moderado moderado = new Moderado();
            Console.Clear();
            Console.WriteLine($"Saldo anterior: {contaCorrente.Saldo}");
            realizador.Realiza(contaCorrente, moderado);

            Console.ReadKey();

            Arrojado arrojado = new Arrojado();
            Console.Clear();
            Console.WriteLine($"Saldo anterior: {contaCorrente.Saldo}");
            realizador.Realiza(contaCorrente, arrojado);

            Console.ReadKey();
        }
    }
}
