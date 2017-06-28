using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Consulta
    {
        public int codigo { get; set; }

        public Paciente paciente { get; }

        public Medico medico { get; }

        public DateTime data { get; }

        public Consulta()
        {

        }

        public Consulta(int codigo)
        {
            this.codigo = codigo;
        }

        public Consulta(Paciente paciente)
        {
            this.paciente = paciente;
        }

        public Consulta(Paciente paciente, Medico medico, DateTime data)
        {
            this.codigo = 0;
            this.paciente = paciente;
            this.medico = medico;
            this.data = data;
        }

        public void Marcar(Paciente paciente, Medico medico, DateTime data)
        {
            new ConsultaBancoDeDados().Adicionar(new Consulta(paciente, medico, data));
        }

        public void Cancelar()
        {
            new ConsultaBancoDeDados().Excluir(this);
        }

        public Consulta Consultar()
        {

            ReadOnlyCollection<Consulta> consultas = new ConsultaBancoDeDados().ListarTodos();

            foreach (Consulta consulta in consultas)
            {
                if (consulta.codigo == this.codigo)
                {
                    return consulta;
                }
            }
            return null;
        }

        public List<Consulta> PesquisarPorPaciente()
        {

            ReadOnlyCollection<Consulta> consultas = new ConsultaBancoDeDados().ListarTodos();

            List<Consulta> consultasDoPaciente = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                if (consulta.paciente.Equals(this.paciente))
                {
                    consultasDoPaciente.Add(consulta);
                }
            }

            return consultasDoPaciente;
        }

        public ReadOnlyCollection<Consulta> ListarTodos()
        {
            return new ConsultaBancoDeDados().ListarTodos();
        }

        public override int GetHashCode()
        {

            int prime = 11;
            int result = 23;
            result = prime * result + ((data == null) ? 0 : data.GetHashCode());
            result = prime * result
                    + ((paciente == null) ? 0 : paciente.GetHashCode());
            result = prime * result + ((medico == null) ? 0 : medico.GetHashCode());
            return result;
        }

        public override bool Equals(Object obj)
        {

            if (obj is Consulta) {

                Consulta consulta = obj as Consulta;

                return this.data.Equals(consulta.data)
                        && this.paciente.Equals(consulta.paciente)
                            && this.medico.Equals(consulta.medico);
            }
            return false;
        }

        public override String ToString()
        {
            return "Paciente : " + this.paciente.nome + " Médico: " + this.medico.nome + " Data: " + this.data.ToString("dd/MM/yyyy");
        }
    }
}
