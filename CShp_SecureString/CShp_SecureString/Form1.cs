using System;
using System.Security;
using System.Windows.Forms;

namespace CShp_SecureString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarStringSegura_Click(object sender, EventArgs e)
        {
            SecureString senhaSegura = null;

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Informe a senha");
            }
            else
            {
                try
                {
                    string strSenha = txtSenha.Text;
                    senhaSegura = TratandoStringSegura.ConverterParaSecureString(txtSenha.Text);
                    txtResultado.Text = txtResultado.Text + "Senha digitada (armazenada na variavel string) : " + strSenha.ToString() + Environment.NewLine + Environment.NewLine;
                    txtResultado.Text = txtResultado.Text + "Senha Convertida para SecureString : " + senhaSegura.ToString() + Environment.NewLine + Environment.NewLine;
                    strSenha = string.Empty;
                    txtResultado.Text = txtResultado.Text + "Senha atual Limpa : " + strSenha.ToString() + Environment.NewLine;
                    //le securestring
                    strSenha = TratandoStringSegura.LerSecureString(senhaSegura);
                    txtResultado.Text = txtResultado.Text + "SecureString convertida para String : " + strSenha.ToString() + Environment.NewLine;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }
    }
}
