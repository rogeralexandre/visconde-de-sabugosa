using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.IntegracaoMinisterio
{
    public interface IIntegracaoMinisterio
    {
        void gerarDados(List<Procedimento> procedimentos);
    }
}
