using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public abstract class Procedimento
    {
        public int codigo { get; set; }

        public Paciente paciente { get; }

        public List<Medico> medicos { get; }

        public DateTime data { get; }

        public Sala sala { get; }

        public double valor { get; }

        public int tempoDuracao { get; }

        public Procedimento()
        {

        }

        public Procedimento(int codigo)
        {
            this.codigo = codigo;
        }

        public Procedimento(Paciente paciente, List<Medico> medicos, DateTime data)
        {
            this.paciente = paciente;
            this.medicos = medicos;
            this.data = data;
        }

        public void Cancelar()
        {
            new ProcedimentoBancoDeDados().Excluir(this);
        }

        public abstract void Marcar(List<Medico> medico, Paciente paciente, DateTime data);

        public abstract double CalcularTotal();
    }
}
