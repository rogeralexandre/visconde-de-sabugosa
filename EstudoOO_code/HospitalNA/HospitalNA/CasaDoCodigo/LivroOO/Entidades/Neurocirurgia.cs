using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Neurocirurgia : Procedimento
    {
        public Neurocirurgia()
        {
        }

        public Neurocirurgia(Paciente paciente, List<Medico> medicos, DateTime data) : base(paciente, medicos, data)
        {

        }

        public Neurocirurgia(int codigo) : base(codigo)
        {

        }

        public override void Marcar(List<Medico> medicos, Paciente paciente, DateTime data)
        {

            Neurocirurgia neurocirurgia = new Neurocirurgia(paciente, medicos, data);

            new ProcedimentoBancoDeDados().Adicionar(neurocirurgia);
        }

        public Neurocirurgia Consultar()
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            foreach (Procedimento procedimento in procedimentos)
            {

                if (procedimento.codigo == this.codigo)
                {
                    return (Neurocirurgia)procedimento;
                }
            }

            return null;
        }

        public List<Neurocirurgia> PesquisarPorMedico(Medico medico)
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            List<Neurocirurgia> procedimentosDoMedico = new List<Neurocirurgia>();
            foreach (Procedimento procedimento in procedimentos)
            {
                if (procedimento.medicos.Contains(medico) && procedimento is Neurocirurgia)
                {
                    procedimentosDoMedico.Add((Neurocirurgia)procedimento);
                }
            }

            return procedimentosDoMedico;
        }

        public ReadOnlyCollection<Neurocirurgia> ListarTodos()
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            List<Neurocirurgia> neurocirurgias = new List<Neurocirurgia>();

            foreach (Procedimento procedimento in procedimentos)
            {

                if (procedimento is Neurocirurgia)
                {
                    neurocirurgias.Add((Neurocirurgia)procedimento);
                }
            }
            return neurocirurgias.AsReadOnly();
        }

        public override double CalcularTotal()
        {
            double totalMedicos = 0.0;
            foreach (Medico medico in medicos)
            {
                totalMedicos += medico.ValorHora;
            }

            return valor + totalMedicos;
        }
    }
}
