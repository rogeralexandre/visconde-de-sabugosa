using Caelum.CaixaEletronico.Modelo;
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
    public partial class Form1 : Form
    {
        List<Conta> contas;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();

            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Numero = 1;
            contas.Add(contaDoVictor);

            Conta contaDoGuilherme = new ContaPoupanca();
            contaDoGuilherme.Titular = new Cliente();
            contaDoGuilherme.Titular.Nome = "Guilherme";
            contaDoGuilherme.Numero = 2;
            contas.Add(contaDoGuilherme);

            Conta contaDoMauricio = new ContaInvestimento();
            contaDoMauricio.Titular = new Cliente();
            contaDoMauricio.Titular.Nome = "Mauricio";
            contaDoMauricio.Numero = 3;
            contas.Add(contaDoMauricio);

            foreach (Conta conta in this.contas)
            {
                if (conta != null) {
                    comboContas.Items.Add(conta);
                    destinoDaTransferencia.Items.Add(conta);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoValorSaque = valorOperacao.Text;

            double valorDeposito = Convert.ToDouble(textoValorSaque);

            int indiceSelecionado = comboContas.SelectedIndex;

            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Deposita(valorDeposito);

            MostraConta(contaSelecionada);
        }

        private void button2_Click(object sender, EventArgs eA)
        {
            string textoValorSaque = valorOperacao.Text;

            double valorSaque = Convert.ToDouble(textoValorSaque);
            Conta contaSelecionada = this.BuscaContaSelecionada();

            try {
                contaSelecionada.Saca(valorSaque);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException e)
            {
                MessageBox.Show("Saldo insuficiente. " + e.Message);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Não é possível sacar um valor negativo. " + e.Message);
            }

            this.MostraConta(contaSelecionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];

            string textoValor = valorOperacao.Text;
            double valorTransferencia = Convert.ToDouble(textoValor);

            contaSelecionada.TransferePara(contaDestino, valorTransferencia);

            this.MostraConta(contaSelecionada);

        }

        public void AdicionaConta(Conta c)
        {
            this.contas.Add(c);

            comboContas.Items.Add(c);
        }

        public void RemoveConta(Conta c)
        {
            this.contas.Remove(c);
        }
    

    private void MostraConta(Conta conta)
    {
        textoTitular.Text = conta.Titular.Nome;
        textoSaldo.Text = Convert.ToString(conta.Saldo);
        textoNumero.Text = Convert.ToString(conta.Numero);
    }

    private Conta BuscaContaSelecionada()
    {
        int indiceSelecionado = comboContas.SelectedIndex;
        return this.contas[indiceSelecionado];
    }


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string titularSelecionado = comboContas.Text;
        Conta contaSelecionada = this.BuscaContaSelecionada();
        this.MostraConta(contaSelecionada);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        CadastroDeContas formularioDeCadastro = new CadastroDeContas(this);
        formularioDeCadastro.ShowDialog();
    }

    private void testeEquals_click(object sender, EventArgs e)
    {
        Cliente guilherme = new Cliente("Guilherme");
        guilherme.Rg = "12345678-9";

        Cliente paulo = new Cliente("Paulo");
        paulo.Rg = "12345678-9";
        //paulo.Rg = "98765432-1"; teste diferente
        MessageBox.Show(guilherme.ToString() + "\n é igual a \n" + paulo.ToString() + " ? \n\n" + guilherme.Equals(paulo));
    }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta conta = BuscaContaSelecionada();
            this.RemoveConta(conta);
        }

        private void btn6Conjuntos_Click(object sender, EventArgs e)
        {
            var conjunto = new HashSet<Conta>();
            var c1 = new ContaCorrente();

            c1.Numero = 456;
            Cliente roger = new Cliente();
            roger.cpf = "2222222";
            roger.Nome = "Roger";
            c1.Titular = roger;


            // só adicionará uma vez.
            conjunto.Add(c1);
            conjunto.Add(c1);

            foreach (var c in conjunto)
            {
                Console.Write("Saldo:");
                Console.WriteLine(c.Saldo);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // testes usando LINQ
            List<Conta> lista = new List<Conta>();
            var roger = new Cliente("Roger");

            Conta conta1 = new ContaCorrente();
            conta1.Titular = roger;
            conta1.Numero = 1;
            conta1.Deposita(1000);

            Conta conta2 = new ContaCorrente();
            conta2.Titular = roger;
            conta2.Numero = 2;
            conta2.Deposita(500);

            Conta conta3 = new ContaCorrente();
            conta3.Titular = roger;
            conta3.Numero = 3;
            conta3.Deposita(1500);

            lista.Add(conta1);
            lista.Add(conta2);
            lista.Add(conta3);

            // filtrando as contas corrente que tem saldo maior que o valor estipulado no where
            var filtrados = from c in lista
                            where c.Saldo >= 1000
                            select c;

            Console.WriteLine("Resultado dos filtrados:");
            foreach (Conta c in filtrados)
            {
                Console.WriteLine($"Conta: {c.Numero.ToString()} o saldo atual é {c.Saldo.ToString()}");
            }

            // somando os valores do saldo
            double total = lista.Sum(c => c.Saldo);
            Console.WriteLine($"O total dos saldos é: {total.ToString()}");

            filtrados = from c in lista
                        where c.Titular.Nome.StartsWith("R")
                        select c;

            Console.WriteLine("Resultado dos filtrados pelo nome do titular:");
            foreach (Conta c in filtrados)
            {
                Console.WriteLine($"Conta: {c.Numero.ToString()} o nome do titular é {c.Titular.Nome}");
            }

            Console.WriteLine("Filtros com AND");
            filtrados = lista.Where(c => c.Numero < 3 && c.Saldo >= 1000);
            foreach (Conta c in filtrados)
            {
                Console.WriteLine($"Conta: {c.Numero.ToString()} o saldo atual é {c.Saldo.ToString()}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}

