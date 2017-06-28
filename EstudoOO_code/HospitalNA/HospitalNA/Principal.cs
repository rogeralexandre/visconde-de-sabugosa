using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasaDoCodigo.LivroOO.Util;
using CasaDoCodigo.LivroOO.Entidades;
using System.Collections.ObjectModel;
using CasaDoCodigo.LivroOO.IntegracaoMinisterio;

namespace CasaDoCodigo.LivroOO.RodarAplicacao
{
    public class Principal
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Sistema Hospitalar!");
            Console.WriteLine("\n");

            DemonstrativoMinisterio demonstrativoMinisterio = new DemonstrativoMinisterio();
            LeitoraDados leitoraDados = new LeitoraDados();
            ExibidoraDados exibidoraDados = new ExibidoraDados();

            String opcao = "";

            while (!opcao.Equals("22"))
            {

                Console.WriteLine("Selecione um número:");
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Alterar paciente");
                Console.WriteLine("3 - Excluir paciente");
                Console.WriteLine("4 - Consultar paciente pelo CPF");
                Console.WriteLine("5 - Consultar paciente por nome e data de nascimento");
                Console.WriteLine("6 - Listar pacientes");

                Console.WriteLine("7 - Cadastar médico");
                Console.WriteLine("8 - Alterar médico");
                Console.WriteLine("9 - Excluir médico");
                Console.WriteLine("10 - Consultar médico por CRM");
                Console.WriteLine("11 - Consular médico por nome");
                Console.WriteLine("12 - Listar médicos");

                Console.WriteLine("13 - Marcar consulta");
                Console.WriteLine("14 - Cancelar consulta");
                Console.WriteLine("15 - Pesquisar consulta por paciente");
                Console.WriteLine("16 - Listar consultas");

                Console.WriteLine("17 - Marcar procedimento");
                Console.WriteLine("18 - Cancelar procedimento");
                Console.WriteLine("19 - Pesquisar procedimento por médico");
                Console.WriteLine("20 - Listar procedimentos");

                Console.WriteLine("21 - Gerar Demonstrativo Ministério");

                Console.WriteLine("22 - Sair");

                opcao = leitoraDados.LerTexto();

                switch (opcao)
                {
                    case "1":
                        Paciente novoPaciente = leitoraDados.LerNovoPaciente();
                        novoPaciente.Cadastrar();
                        break;
                    case "2":
                        Console.WriteLine("Digite o CPF  do Paciente a ser alterado:");
                        String cpfAlterar = leitoraDados.LerTexto();
                        Paciente pacienteAlterar = new Paciente(cpfAlterar);
                        Paciente pacienteAlterarCPF = pacienteAlterar.ConsultarPorCPF();
                        exibidoraDados.ExibirPaciente(pacienteAlterarCPF);
                        Console.WriteLine("Deseja realmente alterar? S/N");
                        String alterar = leitoraDados.LerTexto();
                        if ("S".Equals(alterar, StringComparison.InvariantCultureIgnoreCase))
                        {

                            Paciente pacienteAlterado = leitoraDados.LerPacienteAlteracao(cpfAlterar);
                            pacienteAlterado.Alterar();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Digite o CPF do Paciente a ser excluido:");
                        String cpfExcluir = leitoraDados.LerTexto();
                        Paciente pacienteExcluir = new Paciente(cpfExcluir);
                        Paciente pacienteExcluirCPF = pacienteExcluir.ConsultarPorCPF();
                        pacienteExcluirCPF.Excluir();
                        break;
                    case "4":
                        Console.WriteLine("Digite o CPF  do Paciente:");
                        String cpfConsultar = leitoraDados.LerTexto();
                        Paciente pacienteConsultar = new Paciente(cpfConsultar);
                        Paciente pacienteConsultaCPF = pacienteConsultar.ConsultarPorCPF();
                        exibidoraDados.ExibirPaciente(pacienteConsultaCPF);
                        break;
                    case "5":
                        Paciente pacienteNomeData = leitoraDados.NomeDataPaciente();
                        List<Paciente> pacientes = pacienteNomeData.ConsultarPorNomeDataNascimento();
                        exibidoraDados.ExibirPacientes(pacientes);
                        break;
                    case "6":
                        ReadOnlyCollection<Paciente> pacientesListagem = new Paciente().ListarTodos();
                        exibidoraDados.ExibirPacientes(pacientesListagem);
                        break;
                    case "7":
                        Medico novoMedico = leitoraDados.LerNovoMedico();
                        novoMedico.Cadastrar();
                        break;
                    case "8":
                        Console.WriteLine("Digite o CRM  do médico a ser alterado:");
                        String crmAlterar = leitoraDados.LerTexto();
                        Medico medicoAlterar = new Medico(Int32.Parse(crmAlterar));
                        medicoAlterar = medicoAlterar.ConsultarPorCRM();
                        exibidoraDados.ExibirMedico(medicoAlterar);
                        Console.WriteLine("Deseja realmente alterar? S/N");
                        alterar = leitoraDados.LerTexto();
                        if ("S".Equals(alterar, StringComparison.InvariantCultureIgnoreCase))
                        {

                            Medico medicoAlterado = leitoraDados.LerMedicoAlteracao(crmAlterar);
                            medicoAlterado.Alterar();
                        }
                        break;
                    case "9":
                        Console.WriteLine("Digite o CRM do Médico a ser excluido:");
                        String crmExcluir = leitoraDados.LerTexto();
                        Medico medicoExcluir = new Medico(Int32.Parse(crmExcluir));
                        medicoExcluir = medicoExcluir.ConsultarPorCRM();
                        medicoExcluir.Excluir();
                        break;
                    case "10":
                        Console.WriteLine("Digite o CRM  do Médico:");
                        String crmConsultar = leitoraDados.LerTexto();
                        Medico medicoConsultar = new Medico(Int32.Parse(crmConsultar));
                        medicoConsultar = medicoConsultar.ConsultarPorCRM();
                        exibidoraDados.ExibirMedico(medicoConsultar);
                        break;
                    case "11":
                        Console.WriteLine("Digite o nome do Médico:");
                        String nome = leitoraDados.LerTexto();
                        Medico medicoConsultarNome = new Medico(nome);
                        List<Medico> medicos = medicoConsultarNome.ConsultarPorNome();
                        exibidoraDados.ExibirMedicos(medicos);
                        break;
                    case "12":
                        Medico medicoListar = new Medico();
                        ReadOnlyCollection<Medico> medicosListagem = medicoListar.ListarTodos();
                        exibidoraDados.ExibirMedicos(medicosListagem);
                        break;
                    case "13":
                        Console.WriteLine("Digite o CRM  do Médico:");
                        String crmConsulta = leitoraDados.LerTexto();
                        Console.WriteLine("Digite o CPF  do Paciente:");
                        String cpfConsulta = leitoraDados.LerTexto();
                        Medico medicoConsulta = new Medico(Int32.Parse(crmConsulta));
                        Paciente pacienteConsulta = new Paciente(cpfConsulta);
                        medicoConsulta = medicoConsulta.ConsultarPorCRM();
                        pacienteConsulta = pacienteConsulta.ConsultarPorCPF();
                        Console.WriteLine("Digite a data da consulta(dd/mm/aaaa): ");
                        String dataConsulta = leitoraDados.LerTexto();
                        Consulta consulta = new Consulta();
                        consulta.Marcar(pacienteConsulta, medicoConsulta, ConversoraData.ConverterData(dataConsulta));
                        break;
                    case "14":
                        Console.WriteLine("Digite o código da consulta:");
                        String codigoConsulta = leitoraDados.LerTexto();
                        Consulta consultaDesmarcar = new Consulta(Int32.Parse(codigoConsulta));
                        consultaDesmarcar = consultaDesmarcar.Consultar();
                        exibidoraDados.ExibirConsulta(consultaDesmarcar);
                        Console.WriteLine("Deseja realmente desmarcar? S/N");
                        String desmarcar = leitoraDados.LerTexto();
                        if ("S".Equals(desmarcar, StringComparison.InvariantCultureIgnoreCase))
                        {
                            consultaDesmarcar.Cancelar();
                        }
                        break;
                    case "15":
                        Console.WriteLine("Digite o CPF do paciente da consulta:");
                        String cpfPacienteConsulta = leitoraDados.LerTexto();
                        Paciente pacConsulta = new Paciente(cpfPacienteConsulta);
                        Consulta consultaPorPaciente = new Consulta(pacConsulta);
                        List<Consulta> consultasListagemPesquisa = consultaPorPaciente.PesquisarPorPaciente();
                        exibidoraDados.ExibirConsultas(consultasListagemPesquisa);
                        break;
                    case "16":
                        ReadOnlyCollection<Consulta> consultasListagem = new Consulta().ListarTodos();
                        exibidoraDados.ExibirConsultas(consultasListagem);
                        break;
                    case "17":
                        Console.WriteLine("Digite o CRM de 2 Médicos(separado por vírgula):");
                        String crmProcedimento = leitoraDados.LerTexto();
                        Console.WriteLine("Digite o CPF  do Paciente:");
                        String cpfProcedimento = leitoraDados.LerTexto();

                        String[] crms = crmProcedimento.Split(',');
                        List<Medico> medicosProcedimento = new List<Medico>();
                        foreach (String crm in crms)
                        {

                            Medico medicoProcedimento = new Medico(Int32.Parse(crm)).ConsultarPorCRM();
                            medicosProcedimento.Add(medicoProcedimento);
                        }
                        Paciente pacienteProcedimento = new Paciente(cpfProcedimento).ConsultarPorCPF();
                        Console.WriteLine("Digite a data do procedimento(dd/mm/aaaa): ");
                        String dataProcedimento = leitoraDados.LerTexto();
                        Console.WriteLine("Digite N para Neurologia e F para Faringoplastia: ");
                        String procedimento = leitoraDados.LerTexto();
                        if ("F".Equals(procedimento, StringComparison.InvariantCultureIgnoreCase))
                        {
                            new Faringoplastia().Marcar(medicosProcedimento, pacienteProcedimento, ConversoraData.ConverterData(dataProcedimento));
                        }
                        else
                        {
                            new Neurocirurgia().Marcar(medicosProcedimento, pacienteProcedimento, ConversoraData.ConverterData(dataProcedimento));
                        }
                        break;
                    case "18":
                        Console.WriteLine("Digite o código do procedimento e N para Neurologia e F para Faringoplastia(separado por virgula) para cancelar:");
                        String entrada = leitoraDados.LerTexto();
                        String codigo = entrada.Split(',')[0];
                        String tipo = entrada.Split(',')[1];
                        if ("F".Equals(tipo, StringComparison.InvariantCultureIgnoreCase))
                        {

                            Faringoplastia faringoplastia = new Faringoplastia(Int32.Parse(codigo)).Consultar();

                            exibidoraDados.ExibirFaringoplastia(faringoplastia);
                            Console.WriteLine("Deseja realmente desmarcar? S/N");
                            String desmarcarFaringoplastia = leitoraDados.LerTexto();
                            if ("S".Equals(desmarcarFaringoplastia, StringComparison.InvariantCultureIgnoreCase))
                            {
                                faringoplastia.Cancelar();
                            }
                        }
                        else
                        {

                            Neurocirurgia neurocirurgia = new Neurocirurgia(Int32.Parse(codigo)).Consultar();

                            exibidoraDados.ExibirNeurocirurgia(neurocirurgia);
                            Console.WriteLine("Deseja realmente desmarcar? S/N");
                            String desmarcarNeurocirurgia = leitoraDados.LerTexto();
                            if ("S".Equals(desmarcarNeurocirurgia, StringComparison.InvariantCultureIgnoreCase))
                            {
                                neurocirurgia.Cancelar();
                            }
                        }
                        break;
                    case "19":
                        Console.WriteLine("Digite o CRM dos Médicos(separado por vírgula):");
                        String crmsMedicos = leitoraDados.LerTexto();
                        String[] crmsProcedimentos = crmsMedicos.Split(',');

                        List<Procedimento> procedimentos = new List<Procedimento>();
                        foreach (String crm in crmsProcedimentos)
                        {
                            Medico medico = new Medico(Int32.Parse(crm)).ConsultarPorCRM();
                            procedimentos.AddRange(new Faringoplastia().PesquisarPorMedico(medico));
                            procedimentos.AddRange(new Neurocirurgia().PesquisarPorMedico(medico));
                        }
                        exibidoraDados.ExibirProcedimentos(procedimentos);
                        break;
                    case "20":
                        List<Procedimento> procedimentosListagem = new List<Procedimento>();
                        procedimentosListagem.AddRange(new Faringoplastia().ListarTodos());
                        procedimentosListagem.AddRange(new Neurocirurgia().ListarTodos());
                        exibidoraDados.ExibirProcedimentos(procedimentosListagem);
                        break;
                    case "21":
                        List<Procedimento> procedimentosDemonstrativo = new List<Procedimento>();
                        procedimentosDemonstrativo.AddRange(new Faringoplastia().ListarTodos());
                        procedimentosDemonstrativo.AddRange(new Neurocirurgia().ListarTodos());
                        demonstrativoMinisterio.gerarDados(procedimentosDemonstrativo);
                        break;
                    default:
                        Console.WriteLine("Volte sempre!");
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
