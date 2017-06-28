using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Persistencia
{
    public class ProcedimentoBancoDeDados
    {
        private static List<Procedimento> procedimentos = new List<Procedimento>();

        public ProcedimentoBancoDeDados()
        {
        }

        public void Adicionar(Procedimento procedimento)
        {

            if (!procedimentos.Contains(procedimento))
            {
                procedimentos.Add(procedimento);
                procedimento.codigo = procedimentos.Count();
            }
        }

        public void Excluir(Procedimento procedimento)
        {
            procedimentos.Remove(procedimento);
        }

        public ReadOnlyCollection<Procedimento> ListarTodos()
        {
            return procedimentos.AsReadOnly();
        }
    }
}
