using System;
using System.Windows.Forms;
using System.IO;

namespace Aula8_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.WriteLine(tbxEditor.Text);
            }
            
            MessageBox.Show("Arquivo texto.txt salvo!", "Gravar arquivo");

        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                Stream entrada = File.Open("texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);

                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    tbxEditor.Text += linha;
                    linha = leitor.ReadLine();
                }

                leitor.Close();
                entrada.Close();
            }
            else
            {
                MessageBox.Show("Arquivo entrada.txt não existe!","Ler arquivo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    tbxEditor.Text = leitor.ReadToEnd();
                }
            }
        }
    }
}
