using CasaDoCodigo.LivroOO.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Medico : Pessoa
    {

        private int crm;

        private List<Especialidade> especialidades;

        private double valorHora;

        public Medico()
        {

        }

        public Medico(int CRM)
        {
            this.crm = CRM;
        }

        public Medico(String nome) : base(nome)
        {

        }

        public Medico(String nome, int crm, Endereco endereco, DateTime dataNascimento, double valorHora,
                List<Especialidade> especialidades) : base(nome, dataNascimento, endereco)
        {
            this.crm = crm;
            this.valorHora = valorHora;
            this.especialidades = especialidades;
        }

        public Medico(String nome, int crm, Endereco endereco, double valorHora) : base(nome, endereco)
        {
            this.crm = crm;
            this.valorHora = valorHora;
        }

        public int Crm
        {
            set { crm = value; }
            get { return crm; }
        } 

        public List<Especialidade> Especialidades
        {
            set { especialidades = value; }
            get { return especialidades; }
        }

        public double ValorHora
        {
            set { valorHora = value; }
            get { return valorHora; }
        }

        public void Cadastrar()
        {
            new MedicoBancoDeDados().Adicionar(this);
        }

        public void Alterar()
        {
            new MedicoBancoDeDados().Alterar(this);
        }

        public void Excluir()
        {
            new MedicoBancoDeDados().Excluir(this);
        }

        public Medico ConsultarPorCRM()
        {
            ReadOnlyCollection<Medico> medicos = new MedicoBancoDeDados().ListarTodos();

            foreach (Medico med in medicos)
            {
                if (med.Equals(this))
                {
                    return med;
                }
            }

            return null;
        }

        public List<Medico> ConsultarPorNome()
        {

            ReadOnlyCollection<Medico> medicos = new MedicoBancoDeDados().ListarTodos();

            List<Medico> medicosSelecionados = new List<Medico>();
            foreach (Medico med in medicos)
            {
                if (med.nome.StartsWith(this.nome))
                {
                    medicosSelecionados.Add(med);
                }
            }

            return medicosSelecionados;
        }

        public ReadOnlyCollection<Medico> ListarTodos()
        {
            return new MedicoBancoDeDados().ListarTodos();
        }

        public override int GetHashCode()
        {
            int prime = 5;
            int result = 7;
            result = prime * result + ((nome == null) ? 0 : nome.GetHashCode());
            return result;
        }

        public override bool Equals(Object obj)
        {

            if (obj is Medico) {

                Medico medico = obj as Medico;
                return crm.Equals(medico.Crm);
            }
            return false;
        }

        public override String ToString()
        {
            return "Nome: " + this.nome;
        }
    }
}
