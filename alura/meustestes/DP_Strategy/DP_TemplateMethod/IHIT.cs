using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    // Classe de exercício, onde se há itens com nomes repetidos, caimos na máxima taxação.
    class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach (var item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                {
                    return true;
                }
                else
                {
                    noOrcamento.Add(item.Nome);
                }
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
