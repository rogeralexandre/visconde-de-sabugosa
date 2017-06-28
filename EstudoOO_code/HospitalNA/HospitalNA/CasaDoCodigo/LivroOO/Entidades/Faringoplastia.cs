using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Faringoplastia : Procedimento
    {
        public Faringoplastia()
        {
        }

        public Faringoplastia(int codigo) : base(codigo)
        {

        }

        public Faringoplastia(Paciente paciente, List<Medico> medicos, DateTime data) : base(paciente, medicos, data)
        {

        }

        public override void Marcar(List<Medico> medicos, Paciente paciente, DateTime data)
        {

            Faringoplastia faringoplastia = new Faringoplastia(paciente, medicos, data);

            new ProcedimentoBancoDeDados().Adicionar(faringoplastia);
        }

        public Faringoplastia Consultar()
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            foreach (Procedimento procedimento in procedimentos)
            {

                if (procedimento.codigo == this.codigo)
                {
                    return (Faringoplastia)procedimento;
                }
            }

            return null;
        }

        public List<Faringoplastia> PesquisarPorMedico(Medico medico)
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            List<Faringoplastia> procedimentosDoMedico = new List<Faringoplastia>();
            foreach (Procedimento procedimento in procedimentos)
            {
                if (procedimento.medicos.Contains(medico) && procedimento is Faringoplastia)
                {
                    procedimentosDoMedico.Add((Faringoplastia)procedimento);
                }
            }

            return procedimentosDoMedico;
        }

        public ReadOnlyCollection<Faringoplastia> ListarTodos()
        {

            ReadOnlyCollection<Procedimento> procedimentos = new ProcedimentoBancoDeDados().ListarTodos();

            List<Faringoplastia> faringoplastias = new List<Faringoplastia>();

            foreach (Procedimento procedimento in procedimentos)
            {

                if (procedimento is Faringoplastia)
                {
                    faringoplastias.Add((Faringoplastia)procedimento);
                }
            }

            return faringoplastias.AsReadOnly();
        }

        public override double CalcularTotal()
        {
            double valorCliente = paciente.Plano.Mensalidade * 0.25;

            double totalMedicos = 0.0;
            foreach (Medico medico in medicos)
            {
                totalMedicos += medico.ValorHora;
            }

            return valorCliente + valor + totalMedicos;
        }
    }
}
