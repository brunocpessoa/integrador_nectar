using System;
using System.Collections.Generic;
using System.IO;
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
            DAL conexao = new DAL();

            Utilitario utilitario = new Utilitario();

            string nomeArquivoLog = "\\integrador_nectar\\logs\\importacao_data_" + DateTime.Now + ".txt";
            string texoLogCompleto;
            nomeArquivoLog = nomeArquivoLog.Replace("/", "_");

            nomeArquivoLog = nomeArquivoLog.Replace(":", "_");

            nomeArquivoLog = "C:" + nomeArquivoLog;

            exibicaoSobreImportacao.Text = "Importação de oportunidades iniciada em: " + DateTime.Now;
            texoLogCompleto = "Importação de oportunidades iniciada em: " + DateTime.Now;

            //Oportunidades
            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de oportunidades a serem buscadas.";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de oportunidades a serem buscadas.";

            int qtdPaginas = utilitario.GetQuantidadePaginasSeremImportadas();

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de oportunidades buscadas: " + qtdPaginas;
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de oportunidades buscadas: " + qtdPaginas;

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de oportunidades iniciada";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de oportunidades iniciada";

            int qtdOportunidades = conexao.ImportacaoGeral(qtdPaginas);

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação concluída. "
                + "\n" + "Total de oportunidades importadas: "
                + qtdOportunidades;

            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de oportunidades concluída. "
                + "\n" + "Total de oportunidades importadas: "
                + qtdOportunidades;

            //Contatos
            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de contatos a serem buscadas.";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de contatos a serem buscadas.";

            int qtdPaginasContatos = utilitario.GetQuantidadePaginasContatosSeremImportadas();

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de contatos buscadas: " + qtdPaginasContatos;
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de contatos buscadas: " + qtdPaginasContatos;

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de contatos iniciada";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de contatos iniciada";

            int qtdContatos = conexao.ImportacaoContatos(qtdPaginasContatos);

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de contatos concluída. "
                + "\n" + "Total de contatos importados: "
                + qtdContatos;

            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de contatos concluída. "
                + "\n" + "Total de contatos importados: "
                + qtdContatos;

            //Tarefas
            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de tarefas a serem buscadas.";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de tarefas a serem buscadas.";

            int qtdPaginasTarefas = utilitario.GetQuantidadePaginasTarefasSeremImportadas();

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de tarefas buscadas: " + qtdPaginasTarefas;
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de tarefas buscadas: " + qtdPaginasTarefas;

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de tarefas iniciada";
            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de tarefas iniciada";

            int qtdTarefas = conexao.ImportacaoTarefas(qtdPaginasTarefas);

            exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de tarefas concluída. "
                + "\n" + "Total de tarefas importadas: "
                + qtdTarefas;

            texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de tarefas concluída. "
                + "\n" + "Total de tarefas importadas: "
                + qtdTarefas;

            using (StreamWriter writer = new StreamWriter(@nomeArquivoLog, true))
            {
                writer.WriteLine(texoLogCompleto);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime HorarioAtual = DateTime.Now;

            if ((HorarioAtual.Hour == 03) && (HorarioAtual.Minute == 00))
            {
                DAL conexao = new DAL();

                Utilitario utilitario = new Utilitario();

                string nomeArquivoLog = "\\integrador_nectar\\logs\\importacao_data_" + DateTime.Now + ".txt";
                string texoLogCompleto;
                nomeArquivoLog = nomeArquivoLog.Replace("/", "_");

                nomeArquivoLog = nomeArquivoLog.Replace(":", "_");

                nomeArquivoLog = "C:" + nomeArquivoLog;

                exibicaoSobreImportacao.Text = "Importação de oportunidades iniciada em: " + DateTime.Now;
                texoLogCompleto = "Importação de oportunidades iniciada em: " + DateTime.Now;

                //Oportunidades
                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de oportunidades a serem buscadas.";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de oportunidades a serem buscadas.";

                int qtdPaginas = utilitario.GetQuantidadePaginasSeremImportadas();

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de oportunidades buscadas: " + qtdPaginas;
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de oportunidades buscadas: " + qtdPaginas;

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de oportunidades iniciada";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de oportunidades iniciada";

                int qtdOportunidades = conexao.ImportacaoGeral(qtdPaginas);

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação concluída. "
                    + "\n" + "Total de oportunidades importadas: "
                    + qtdOportunidades;

                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de oportunidades concluída. "
                    + "\n" + "Total de oportunidades importadas: "
                    + qtdOportunidades;

                //Contatos
                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de contatos a serem buscadas.";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de contatos a serem buscadas.";

                int qtdPaginasContatos = utilitario.GetQuantidadePaginasContatosSeremImportadas();

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de contatos buscadas: " + qtdPaginasContatos;
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de contatos buscadas: " + qtdPaginasContatos;

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de contatos iniciada";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de contatos iniciada";

                int qtdContatos = conexao.ImportacaoContatos(qtdPaginasContatos);

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de contatos concluída. "
                    + "\n" + "Total de contatos importados: "
                    + qtdContatos;

                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de contatos concluída. "
                    + "\n" + "Total de contatos importados: "
                    + qtdContatos;

                //Tarefas
                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Iniciando contagem de páginas de tarefas a serem buscadas.";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Iniciando contagem de páginas de tarefas a serem buscadas.";

                int qtdPaginasTarefas = utilitario.GetQuantidadePaginasTarefasSeremImportadas();

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Quantidade de páginas de tarefas buscadas: " + qtdPaginasTarefas;
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Quantidade de páginas de tarefas buscadas: " + qtdPaginasTarefas;

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de tarefas iniciada";
                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de tarefas iniciada";

                int qtdTarefas = conexao.ImportacaoTarefas(qtdPaginasTarefas);

                exibicaoSobreImportacao.Text = exibicaoSobreImportacao.Text + "\n" + "Importação de tarefas concluída. "
                    + "\n" + "Total de tarefas importadas: "
                    + qtdTarefas;

                texoLogCompleto = "\n" + texoLogCompleto + "\n" + "Importação de tarefas concluída. "
                    + "\n" + "Total de tarefas importadas: "
                    + qtdTarefas;

                using (StreamWriter writer = new StreamWriter(@nomeArquivoLog, true))
                {
                    writer.WriteLine(texoLogCompleto);
                }
            }
        }
    }
}
