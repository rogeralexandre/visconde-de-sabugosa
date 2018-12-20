using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfResponsability_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Roger",1000);
            Requisicao requisicao = new Requisicao(Formato.CSV);

            ProcessaSaidas proc = new ProcessaSaidas();
            Console.WriteLine(proc.ProcessarSaidas(requisicao, conta));
            Console.ReadKey();

        }
    }
}
