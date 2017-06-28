using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Persistencia
{
    public class PacienteBancoDeDados
    {
        private static List<Paciente> pacientes = new List<Paciente>();

        public PacienteBancoDeDados()
        {
        }

        public void Adicionar(Paciente paciente)
        {

            if (!pacientes.Contains(paciente))
            {
                pacientes.Add(paciente);
            }
        }

        public void Alterar(Paciente paciente)
        {

            int posicao = pacientes.IndexOf(paciente);
            pacientes[posicao] = paciente;
        }

        public void Excluir(Paciente paciente)
        {
            pacientes.Remove(paciente);
        }

        public ReadOnlyCollection<Paciente> ListarTodos()
        {
            return new ReadOnlyCollection<Paciente>(pacientes);
        }
    }
}
