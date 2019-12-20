using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Npgsql;
using NpgsqlTypes;

namespace integrador_nectar_crm
{
    public class DAL
    {
        static string serverName = "dbneo.triersistemas.com.br";
        static string port = "5432";
        static string userName = "postgres";
        static string password = "postgres!@09042003";
        static string databaseName = "nectar";
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;

        public DAL()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        serverName, port, userName, password, databaseName);
        }

        //Oportunidades
        public DataTable GetTodasOportunidades()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from oportunidade order by id";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

        public DataTable GetOportunidadePorId(int id)
        {

            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from oportunidade Where id = " + id;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }

        public void InserirOportunidades(int idOportunidade, string nome, string responsavel, string autor,
            string autorAtualizacao, int? codFarmacia, string funilDeVendas, string origem, string agente,
            string software_concorrente, string campanha, string indicador_trier_mais_1, double? valor_total,
            DateTime dataCriacao, DateTime dataConclusao, int status)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();

                    string cmdInserir = $"Insert Into oportunidade(id,nome,responsavel,autor," +
                        $" autor_atualizacao,  cod_farmacia,  funil_vendas, origem, agente, " +
                        $"software_concorrente, campanha, indicador_trier_mais_1, valor_total," +
                        $"data_criacao, data_conclusao, status) " +
                        $"values({idOportunidade},'{nome}','{responsavel}','{autor}','{autorAtualizacao}'," +
                        $"{codFarmacia},'{funilDeVendas}','{origem}','{agente}','{software_concorrente}','{campanha}'," +
                        $"'{indicador_trier_mais_1}','{valor_total}','{dataCriacao}', '{dataConclusao}',{status})";

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public void AtualizarOportunidade(int codigo, string email, int idade)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdAtualiza = String.Format("Update oportunidades Set email = '" + email + "' , idade = " + idade + " Where id = " + codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public void DeletarTodasOportunidades()
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("DELETE FROM oportunidade");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Contatos
        public void InserirContatos(int idContato, string nomeContato, string autorContato,
            DateTime dataCriacaoContato)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();

                    string cmdInserir = $"Insert Into contato(id_contato,nome_contato,autor_contato,data_criacao_contato)"+
                        $"values({idContato},'{nomeContato}','{autorContato}','{dataCriacaoContato}')";

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public DataTable GetTodosContatos()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from contato order by id_contato";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        public void DeletarTodosContatos()
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("DELETE FROM contato");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Configuracao
        public DataTable GetQuantidadePaginasSeremBuscadas(string nomeConfiguracao)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select valor from configuracao Where nome_configuracao = '" + nomeConfiguracao + "'";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }

        public void DeletarConfiguracaoPaginasBuscadas()
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("DELETE FROM configuracao");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public void InserirConfiguracao(string nomeConfiguracao, string novoValorPaginasBuscadas)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();

                    string cmdInserir = $"Insert Into configuracao(nome_configuracao, valor)" +
                        $"values('{nomeConfiguracao}','{novoValorPaginasBuscadas}')";

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Produto
        public void InserirProduto(int idProduto, int refId, double valorUnitario, double valorTotal, double quantidade,
            string nomeProduto, int idOportunidade)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();

                    string cmdInserir = $"Insert Into produto(id,ref_id,valor_unitario,valor_total," +
                        $" quantidade,  nome, id_oportunidade) " +
                        $"values({idProduto},'{refId}','{valorUnitario}','{valorTotal}','{quantidade}'," +
                        $"'{nomeProduto}',{idOportunidade})";

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public void DeletarTodosProdutos()
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("DELETE FROM produto");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        public DataTable GetTodosProdutos()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from oportunidade order by id";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        public int ImportacaoGeral(int qtdPaginas)
        {
            CultureInfo cultures = new CultureInfo("pt-BR");

            int paginaBuscada = 1;
            int qtdRegistros = 0;

            DAL conexao = new DAL();

            var todosRegistros = conexao.GetTodasOportunidades();
            var todosProdutos = conexao.GetTodosProdutos();

            if (todosRegistros != null)
                conexao.DeletarTodasOportunidades();
            if (todosProdutos != null)
                conexao.DeletarTodosProdutos();

            OportunidadeRepositorio listaOportunidades = new OportunidadeRepositorio();

            for (int a = 0; a <= qtdPaginas; a++)

            {
                List<Oportunidade> lista = listaOportunidades.GetOportunidadesAsyncPaginado(paginaBuscada);

                qtdRegistros = qtdRegistros + lista.Count;

                lista.ForEach(item =>
                {
                    string nomeAjustado = item.nome.Replace("'", "_");

                    conexao.InserirOportunidades(item.id, nomeAjustado, item.responsavel.nome, item.autor.nome,
                        item.autorAtualizacao.nome, String.IsNullOrEmpty(item.cliente.codigo) ? 0 : Convert.ToInt32(item.cliente.codigo), item.funilVenda.nome, item.origem.nome, item.camposPersonalizados.agente,
                       item.camposPersonalizados.Software_Concorrente, item.camposPersonalizados.campanha,
                       item.camposPersonalizados.Indicador_Trier_Mais_1, item.valorTotal, item.dataCriacao,
                       item.dataConclusao, item.status);
                    var qtdProdutos = item.produtos.Count;
                    for (int i = 0; i < qtdProdutos; i++)
                    {
                        string valorUnitarioProduto = Convert.ToString(item.produtos[i].valorUnitario);
                        valorUnitarioProduto = valorUnitarioProduto.Replace(",", ".");
                        string valorTotalProduto = Convert.ToString(item.produtos[i].valorTotal);
                        valorTotalProduto = valorTotalProduto.Replace(",", ".");

                        conexao.InserirProduto(item.produtos[i].id, item.produtos[i].refId,
                            Convert.ToDouble(valorUnitarioProduto),
                            Convert.ToDouble(valorTotalProduto), item.produtos[i].quantidade, item.produtos[i].nome, item.id);
                    }
                });
                paginaBuscada = paginaBuscada + 1;
            }
            return qtdRegistros;
        }

        public int ImportacaoContatos(int qtdPaginas)
        {
            CultureInfo cultures = new CultureInfo("pt-BR");

            int paginaBuscada = 1;
            int qtdRegistros = 0;

            DAL conexao = new DAL();

            var todosContatos = conexao.GetTodosContatos();

            if (todosContatos != null)
                conexao.DeletarTodosContatos();
            

            ContatoRepositorio listaContatos = new ContatoRepositorio();

            for (int a = 0; a <= qtdPaginas; a++)

            {
                List<Contato> lista = listaContatos.GetContatosAsyncPaginado(paginaBuscada);

                qtdRegistros = qtdRegistros + lista.Count;

                lista.ForEach(item =>
                {
                    string nomeAjustado = item.nome.Replace("'", "_");

                    conexao.InserirContatos(item.id, nomeAjustado, item.autor.nome, item.dataCriacao);
                });
                paginaBuscada = paginaBuscada + 1;
            }
            return qtdRegistros;
        }
    }
}