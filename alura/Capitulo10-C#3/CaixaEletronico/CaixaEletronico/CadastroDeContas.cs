using Caelum.CaixaEletronico.Modelo.Contas;
using Caelum.CaixaEletronico.Modelo.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeContas(Form1 aplicacaoPrincipal) : this()
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
        }
        
        public CadastroDeContas()
        {
            InitializeComponent();
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            this.tipoDeConta.Items.Add("Conta Corrente");
            this.tipoDeConta.Items.Add("Conta Poupança");
            this.tipoDeConta.Items.Add("Conta Investimento");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c;
            if (tipoDeConta.Text.Equals("Conta Poupança"))
            {
                c = new ContaPoupanca();
            }
            else if(tipoDeConta.Text.Equals("Conta Corrente"))
            {
                c = new ContaCorrente();
            }
            else
            {
                c = new ContaInvestimento();
            }

            c.Numero = Convert.ToInt32(numeroDaConta.Text);
            c.Titular = new Cliente();
            c.Titular.Nome = titularConta.Text;
            this.aplicacaoPrincipal.AdicionaConta(c);
        }
    }
}
