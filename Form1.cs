using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integrador_nectar_crm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibicaoSobreImportacao.Text = "Importação iniciada em: " + DateTime.Now;

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas a serem buscadas..";
            DAL conexao = new DAL();

            Utilitario utilitario = new Utilitario();
            int qtdPaginas = utilitario.GetQuantidadePaginasSeremImportadas();

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas buscadas: " + qtdPaginas;


            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação iniciada";

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação concluída. " 
                + "\n" + "Total de oportunidades importadas: "
                + conexao.ImportacaoGeral(qtdPaginas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime HorarioAtual = DateTime.Now;

            if ((HorarioAtual.Hour == 18) && (HorarioAtual.Minute == 31))
            {
                exibicaoSobreImportacao.Text = "Importação iniciada em: " + DateTime.Now;

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas a serem buscadas..";
                DAL conexao = new DAL();

                Utilitario utilitario = new Utilitario();
                int qtdPaginas = utilitario.GetQuantidadePaginasSeremImportadas();

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação iniciada";

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas buscadas: " + qtdPaginas;

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação concluída. "
                    + "\n" + "Total de oportunidades importadas: "
                    + conexao.ImportacaoGeral(qtdPaginas);
            }
        }
    }
}
