namespace ZipPastas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtArquivoCompactado = new System.Windows.Forms.TextBox();
            this.btnLocalizarPasta = new System.Windows.Forms.Button();
            this.btnLocalizarArquivo = new System.Windows.Forms.Button();
            this.btnCompactar = new System.Windows.Forms.Button();
            this.btnDescompactar = new System.Windows.Forms.Button();
            this.fdbdlg1 = new System.Windows.Forms.FolderBrowserDialog();
            this.svfdlg1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a pasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo Compactado";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(16, 42);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(626, 20);
            this.txtDiretorio.TabIndex = 2;
            // 
            // txtArquivoCompactado
            // 
            this.txtArquivoCompactado.Location = new System.Drawing.Point(16, 89);
            this.txtArquivoCompactado.Name = "txtArquivoCompactado";
            this.txtArquivoCompactado.Size = new System.Drawing.Size(626, 20);
            this.txtArquivoCompactado.TabIndex = 3;
            // 
            // btnLocalizarPasta
            // 
            this.btnLocalizarPasta.Location = new System.Drawing.Point(648, 40);
            this.btnLocalizarPasta.Name = "btnLocalizarPasta";
            this.btnLocalizarPasta.Size = new System.Drawing.Size(48, 23);
            this.btnLocalizarPasta.TabIndex = 4;
            this.btnLocalizarPasta.Text = "...";
            this.btnLocalizarPasta.UseVisualStyleBackColor = true;
            this.btnLocalizarPasta.Click += new System.EventHandler(this.vtnLocalizarPasta_Click);
            // 
            // btnLocalizarArquivo
            // 
            this.btnLocalizarArquivo.Location = new System.Drawing.Point(648, 87);
            this.btnLocalizarArquivo.Name = "btnLocalizarArquivo";
            this.btnLocalizarArquivo.Size = new System.Drawing.Size(48, 23);
            this.btnLocalizarArquivo.TabIndex = 5;
            this.btnLocalizarArquivo.Text = "...";
            this.btnLocalizarArquivo.UseVisualStyleBackColor = true;
            this.btnLocalizarArquivo.Click += new System.EventHandler(this.btnLocalizarArquivo_Click);
            // 
            // btnCompactar
            // 
            this.btnCompactar.Location = new System.Drawing.Point(16, 116);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(159, 45);
            this.btnCompactar.TabIndex = 6;
            this.btnCompactar.Text = "&Compactar";
            this.btnCompactar.UseVisualStyleBackColor = true;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // btnDescompactar
            // 
            this.btnDescompactar.Location = new System.Drawing.Point(483, 116);
            this.btnDescompactar.Name = "btnDescompactar";
            this.btnDescompactar.Size = new System.Drawing.Size(159, 45);
            this.btnDescompactar.TabIndex = 7;
            this.btnDescompactar.Text = "&Descompactar";
            this.btnDescompactar.UseVisualStyleBackColor = true;
            this.btnDescompactar.Click += new System.EventHandler(this.btnDescompactar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDescompactar);
            this.Controls.Add(this.btnCompactar);
            this.Controls.Add(this.btnLocalizarArquivo);
            this.Controls.Add(this.btnLocalizarPasta);
            this.Controls.Add(this.txtArquivoCompactado);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtArquivoCompactado;
        private System.Windows.Forms.Button btnLocalizarPasta;
        private System.Windows.Forms.Button btnLocalizarArquivo;
        private System.Windows.Forms.Button btnCompactar;
        private System.Windows.Forms.Button btnDescompactar;
        private System.Windows.Forms.FolderBrowserDialog fdbdlg1;
        private System.Windows.Forms.SaveFileDialog svfdlg1;
    }
}

