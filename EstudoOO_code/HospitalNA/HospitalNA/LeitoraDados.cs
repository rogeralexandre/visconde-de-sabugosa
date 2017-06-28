using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Util
{
    public class LeitoraDados
    {

        public LeitoraDados()
        {

        }

        public String LerTexto()
        {
            String texto = Console.ReadLine();

            return texto;
        }

        public Paciente LerNovoPaciente()
        {
            Console.WriteLine("Digite o CPF: ");
            String cpf = Console.ReadLine();

            Console.WriteLine("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:(separado por virgula sem espaço entre virgula. Ex: Rua 1 2 3 de oliveira 4,n 20,centro,60529837)");
            String endereco = Console.ReadLine();
            Endereco enderecoConvertido = ConversorEndereco.ConverterEndereco(endereco);

            Console.WriteLine("Digite a data de nascimento(dd/mm/aaaa): ");
            String data = Console.ReadLine();
            DateTime dataConvertida = ConversoraData.ConverterData(data);

            Console.WriteLine("Digite o nome do plano e sua mensalidade separados por virgula(valores separador por .): ");
            String plano = Console.ReadLine();
            Plano plan = new Plano();
            plan.Nome = plano.Split(',')[0];
            plan.Mensalidade = Double.Parse(plano.Split(',')[1]);

            Paciente paciente = new Paciente(nome, dataConvertida, enderecoConvertido, cpf, plan);

            return paciente;
        }

        public Paciente LerPacienteAlteracao(String cpf)
        {
            Console.WriteLine("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:(separado por virgula. Ex: Rua 1 2 3 de oliveira 4, n 20, centro, 60529837)");
            String endereco = Console.ReadLine();
            Endereco enderecoConvertido = ConversorEndereco.ConverterEndereco(endereco);

            Paciente paciente = new Paciente(cpf, nome, enderecoConvertido);

            return paciente;
        }

        public Paciente NomeDataPaciente()
        {
            Console.WriteLine("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento(dd/mm/aaaa): ");
            String data = Console.ReadLine();
            DateTime dataConvertida = ConversoraData.ConverterData(data);

            Paciente paciente = new Paciente(nome, dataConvertida);

            return paciente;
        }

        public Medico LerNovoMedico()
        {
            Console.WriteLine("Digite o CRM: ");
            String crm = Console.ReadLine();

            Console.WriteLine("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:(separado por virgula sem espaço entre virgula. Ex: Rua 1 2 3 de oliveira 4,n 20,centro,60529837)");
            String endereco = Console.ReadLine();
            Endereco enderecoConvertido = ConversorEndereco.ConverterEndereco(endereco);

            Console.WriteLine("Digite a data de nascimento(dd/mm/aaaa): ");
            String data = Console.ReadLine();
            DateTime dataConvertida = ConversoraData.ConverterData(data);

            Console.WriteLine("Digite o valor da hora(separado por ponto): ");
            String valor = Console.ReadLine();
            double valorHora = Double.Parse(valor);

            Console.WriteLine("Digite até 3 especialidades(somente o nome e separadas por virgula): ");
            String especialidadesTexto = Console.ReadLine();
            List<Especialidade> especialidades = ConversoraEspecialidade.ConverterEspecialidades(especialidadesTexto);

            Medico medico = new Medico(nome, Int32.Parse(crm), enderecoConvertido, dataConvertida, valorHora, especialidades);

            return medico;
        }

        public Medico LerMedicoAlteracao(String crm)
        {
            Console.WriteLine("Digite o nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:(separado por virgula. Ex: Rua 1 2 3 de oliveira 4, n 20, centro, 60529837)");
            String endereco = Console.ReadLine();
            Endereco enderecoConvertido = ConversorEndereco.ConverterEndereco(endereco);

            Console.WriteLine("Digite o valor da hora(separado por ponto): ");
            String valor = Console.ReadLine();
            double valorHora = Double.Parse(valor);

            Medico medico = new Medico(nome, Int32.Parse(crm), enderecoConvertido, valorHora);

            return medico;
        }
    }
}
