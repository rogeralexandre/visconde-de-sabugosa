using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Persistencia
{
    public class MedicoBancoDeDados
    {
        private static List<Medico> medicos = new List<Medico>();

        public MedicoBancoDeDados()
        {
        }

        public void Adicionar(Medico medico)
        {

            if (!medicos.Contains(medico))
            {
                medicos.Add(medico);
            }
        }

        public void Alterar(Medico medico)
        {

            int posicao = medicos.IndexOf(medico);
            medicos[posicao] = medico;
        }

        public void Excluir(Medico medico)
        {
            medicos.Remove(medico);
        }

        public ReadOnlyCollection<Medico> ListarTodos()
        {
            return medicos.AsReadOnly();
        }
    }
}
