using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Util
{
    public sealed class ExibidoraDados
    {
        public ExibidoraDados()
        {

        }

        public void ExibirPaciente(Paciente paciente)
        {

            Console.WriteLine("Paciente");
            Console.WriteLine("         " + paciente.ToString());
            Console.WriteLine("         Endereço: " + paciente.endereco);

        }

        public void ExibirPacientes(IReadOnlyCollection<Paciente> pacientes)
        {

            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine(paciente.ToString());
            }
        }

        public void ExibirMedico(Medico medico)
        {
            Console.WriteLine("Médico");
            Console.WriteLine("         " + medico.ToString());
            Console.WriteLine("         Endereço: " + medico.endereco);
        }

        public void ExibirMedicos(List<Medico> medicos)
        {

            foreach (Medico medico in medicos)
            {
                Console.WriteLine(medico.ToString());
            }
        }

        public void ExibirMedicos(ReadOnlyCollection<Medico> medicos)
        {

            foreach (Medico medico in medicos)
            {
                Console.WriteLine(medico.ToString());
            }
        }

        public void ExibirConsulta(Consulta consulta)
        {
            Console.WriteLine("Consulta");
            Console.WriteLine("         Paciente: " + consulta.paciente);
            Console.WriteLine("         Médico: " + consulta.medico);
            Console.WriteLine("         Data: " + consulta.data.ToString("dd/MM/yyyy"));
            Console.WriteLine("         Código: " + consulta.codigo);
        }

        public void ExibirConsultas(List<Consulta> consultasListagem)
        {
            foreach (Consulta consulta in consultasListagem)
            {
                Console.WriteLine("Consulta");
                Console.WriteLine("         Paciente: " + consulta.paciente);
                Console.WriteLine("         Médico: " + consulta.medico);
                Console.WriteLine("         Data: " + consulta.data.ToString("dd/MM/yyyy"));
                Console.WriteLine("         Código: " + consulta.codigo);
            }
        }

        public void ExibirConsultas(ReadOnlyCollection<Consulta> consultasListagem)
        {
            foreach (Consulta consulta in consultasListagem)
            {
                Console.WriteLine("Consulta");
                Console.WriteLine("         Paciente: " + consulta.paciente);
                Console.WriteLine("         Médico: " + consulta.medico);
                Console.WriteLine("         Data: " + consulta.data.ToString("dd/MM/yyyy"));
                Console.WriteLine("         Código: " + consulta.codigo);
            }
        }

        public void ExibirFaringoplastia(Faringoplastia faringoplastia)
        {
            Console.WriteLine("Faringoplastia");
            Console.WriteLine("         Paciente: " + faringoplastia.paciente);
            Console.WriteLine("         Médico: " + faringoplastia.medicos);
            Console.WriteLine("         Data: " + faringoplastia.data.ToString("dd/MM/yyyy"));
            Console.WriteLine("         Código: " + faringoplastia.codigo);
        }

        public void ExibirNeurocirurgia(Neurocirurgia neurocirurgia)
        {
            Console.WriteLine("Neurocirurgia");
            Console.WriteLine("         Paciente: " + neurocirurgia.paciente);
            Console.WriteLine("         Médico: " + neurocirurgia.medicos);
            Console.WriteLine("         Data: " + neurocirurgia.data.ToString("dd/MM/yyyy"));
            Console.WriteLine("         Código: " + neurocirurgia.codigo);
        }

        public void ExibirProcedimentos(List<Procedimento> procedimentos)
        {
            foreach (Procedimento procedimento in procedimentos)
            {
                Console.WriteLine(procedimento.GetType().Name);
                Console.WriteLine("         Paciente: " + procedimento.paciente);
                foreach (Medico medico in procedimento.medicos)
                {
                    Console.WriteLine("         Médico: " + medico.ToString());
                }
                Console.WriteLine("         Data: " + procedimento.data.ToString("dd/MM/yyyy"));
                Console.WriteLine("         Código: " + procedimento.codigo);
            }
        }
    }
}
