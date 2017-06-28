using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Persistencia
{
    public class ConsultaBancoDeDados
    {
        private static List<Consulta> consultas = new List<Consulta>();

        public ConsultaBancoDeDados()
        {
        }

        public void Adicionar(Consulta consulta)
        {

            if (!consultas.Contains(consulta))
            {
                consultas.Add(consulta);
                consulta.codigo = consultas.Count();
            }
        }

        public void Excluir(Consulta consulta)
        {
            consultas.Remove(consulta);
        }

        public ReadOnlyCollection<Consulta> ListarTodos()
        {
            return new ReadOnlyCollection<Consulta>(consultas);
        }
    }
}
