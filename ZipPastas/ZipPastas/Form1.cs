using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace ZipPastas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //configuração inicial do FolderBrowserDialog
            fdbdlg1.Description = "Selecione a pasta a ser compactada";
            fdbdlg1.RootFolder = Environment.SpecialFolder.MyComputer;
            fdbdlg1.ShowNewFolderButton = true;

            try
            {
                txtDiretorio.Text = Application.StartupPath;
                txtArquivoCompactado.Text = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\pasta_do_macoratti.zip"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vtnLocalizarPasta_Click(object sender, EventArgs e)
        {
            fdbdlg1.SelectedPath = txtDiretorio.Text;
            if (fdbdlg1.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fdbdlg1.SelectedPath;
            }
        }

        private void btnLocalizarArquivo_Click(object sender, EventArgs e)
        {
            svfdlg1.FileName = txtArquivoCompactado.Text;
            if (svfdlg1.ShowDialog() == DialogResult.OK)
            {
                txtArquivoCompactado.Text = svfdlg1.FileName;
            }
        }

        private void btnCompactar_Click(object sender, EventArgs e)
        {
            try
            {
                ZipFile.CreateFromDirectory(txtDiretorio.Text, txtArquivoCompactado.Text);
                MessageBox.Show($"Compactação da pasta : <<{txtDiretorio.Text}>> feita com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDescompactar_Click(object sender, EventArgs e)
        {
            try
            {
                ZipFile.ExtractToDirectory(txtArquivoCompactado.Text, txtDiretorio.Text);
                MessageBox.Show($"Descompactação do arquivo : <<{txtArquivoCompactado.Text}>> feita com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
