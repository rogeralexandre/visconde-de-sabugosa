using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.IntegracaoMinisterio
{
    public class DemonstrativoMinisterio : IIntegracaoMinisterio
    {
        public void gerarDados(List<Procedimento> procedimentos)
        {
            double totalProcedimentos = 0.0;
            foreach (Procedimento procedimento in procedimentos)
            {
                totalProcedimentos += procedimento.CalcularTotal();
            }

            Console.WriteLine("Total faturado pelo hospital com procedimentos: R$ " + totalProcedimentos);
        }

    }
}
