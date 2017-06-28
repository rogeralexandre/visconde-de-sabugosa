using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Util
{
    public sealed class ConversoraEspecialidade
    {
        public static List<Especialidade> ConverterEspecialidades(String especialidades)
        {

            String[] especialidadesArray = especialidades.Split(',');

            List<Especialidade> listaEspecialidades = new List<Especialidade>();
            foreach (String nomeEspecialidade in especialidadesArray)
            {

                Especialidade especialidade = new Especialidade();
                especialidade.Nome = nomeEspecialidade;
                listaEspecialidades.Add(especialidade);
            }

            return listaEspecialidades;
        }
    }
}
