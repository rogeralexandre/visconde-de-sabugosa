using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfResponsability
{
    public class CalculadoraDeDescontos
    {
        public Double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new DescontoParaVendaCasada();
            Desconto sd = new DescontoNaoAtendido();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = sd;

            return d1.Desconta(orcamento);
        }
    }
}
