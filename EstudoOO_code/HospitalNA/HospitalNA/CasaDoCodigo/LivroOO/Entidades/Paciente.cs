using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Paciente : Pessoa
    {
        private String cpf;

        private Plano plano;

        public Paciente()
        {

        }

        public Paciente(String cpf)
        {
            this.cpf = cpf;
        }

        public Paciente(String cpf, String nome, Endereco endereco) : base(nome, endereco)
        {
            this.cpf = cpf;
        }

        public Paciente(String nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {

        }

        public Paciente(String nome, DateTime dataNascimento, Endereco endereco, String cpf, Plano plano) : base(nome, dataNascimento, endereco)
        {
            this.cpf = cpf;
            this.plano = plano;
        }

        public String Cpf
        {
            get { return cpf; }
        }

        public Plano Plano
        {
            get { return plano; }
        }

        public void Cadastrar()
        {
            new PacienteBancoDeDados().Adicionar(this);
        }

        public void Alterar()
        {
            new PacienteBancoDeDados().Alterar(this);
        }

        public void Excluir()
        {
            new PacienteBancoDeDados().Excluir(this);
        }

        public Paciente ConsultarPorCPF()
        {
            ReadOnlyCollection<Paciente> pacientes = new PacienteBancoDeDados().ListarTodos();

            foreach (Paciente pac in pacientes)
            {
                if (pac.Equals(this))
                {
                    return pac;
                }
            }

            return null;
        }

        public List<Paciente> ConsultarPorNomeDataNascimento()
        {

            ReadOnlyCollection<Paciente> pacientes = new PacienteBancoDeDados().ListarTodos();

            List<Paciente> pacientesSelecionados = new List<Paciente>();
            foreach (Paciente pac in pacientes)
            {
                if (pac.nome.StartsWith(this.nome)
                        && DateTime.Equals(pac.dataNascimento, this.dataNascimento))
                {
                    pacientesSelecionados.Add(pac);
                }
            }

            return pacientesSelecionados;
        }

        public ReadOnlyCollection<Paciente> ListarTodos()
        {
            return new PacienteBancoDeDados().ListarTodos();
        }

        public override int GetHashCode()
        {

            int prime = 17;
            int result = 3;
            result = prime * result + ((cpf == null) ? 0 : cpf.GetHashCode());
            return result;
        }

        public override bool Equals(Object obj)
        {

            if (obj is Paciente) {

                Paciente paciente = obj as Paciente;
                return this.cpf.Equals(paciente.Cpf);
            }
            return false;
        }

        public override String ToString()
        {
            return "Nome: " + nome + " CPF: " + this.cpf;
        }
    }
}
