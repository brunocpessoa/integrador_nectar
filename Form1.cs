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
            //DAL conexao = new DAL();

            //var todosRegistros = conexao.GetTodasOportunidades();
            //var todosProdutos = conexao.GetTodosProdutos();

            //if (todosRegistros != null)
            //    conexao.DeletarTodasOportunidades();
            //if (todosProdutos != null)
            //    conexao.DeletarTodosProdutos();

            //OportunidadeRepositorio listaOportunidades = new OportunidadeRepositorio();
            //List<Oportunidade> lista = listaOportunidades.GetOportunidadesAsync();


            //lista.ForEach(item =>
            //{
            //    conexao.InserirOportunidades(item.id, item.nome, item.responsavel.nome, item.autor.nome,
            //        item.autorAtualizacao.nome, Convert.ToInt32(item.cliente.codigo), item.funilVenda.nome, item.origem.nome, item.camposPersonalizados.agente,
            //       item.camposPersonalizados.Software_Concorrente, item.camposPersonalizados.campanha,
            //       item.camposPersonalizados.Indicador_Trier_Mais_1, item.valorTotal);
            //    var qtdProdutos = item.produtos.Count;
            //    for (int i = 0; i < qtdProdutos; i++)
            //    {
            //        conexao.InserirProduto(item.produtos[i].id, item.produtos[i].refId, item.produtos[i].valorUnitario,
            //            item.produtos[i].valorTotal, item.produtos[i].quantidade, item.produtos[i].nome, item.id);
            //    }
            //});

            DAL conexao = new DAL();
            //conexao.ImportacaoGeral();

            conexao.ImportacaoGeral();

            txtStatusImportacao.Text = "Quantidade de registros importados: " + conexao.ImportacaoGeral();
            //dataGridView1.DataSource = todosRegistros;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime HorarioAtual = DateTime.Now;

            if ((HorarioAtual.Hour == 20) && (HorarioAtual.Minute == 00))
            {
                DAL conexao = new DAL();

                var todosRegistros = conexao.GetTodasOportunidades();

                if (todosRegistros != null)
                    conexao.DeletarTodasOportunidades();
            }
        }
    }
}
