namespace integrador_nectar_crm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exibicaoSobreImportacao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar importação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exibicaoSobreImportacao
            // 
            this.exibicaoSobreImportacao.Location = new System.Drawing.Point(12, 12);
            this.exibicaoSobreImportacao.Name = "exibicaoSobreImportacao";
            this.exibicaoSobreImportacao.Size = new System.Drawing.Size(455, 165);
            this.exibicaoSobreImportacao.TabIndex = 4;
            this.exibicaoSobreImportacao.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 219);
            this.Controls.Add(this.exibicaoSobreImportacao);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Integrador Nectar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox exibicaoSobreImportacao;
    }
}

