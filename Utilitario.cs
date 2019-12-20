using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace integrador_nectar_crm
{
    public class Utilitario
    {
        public DateTime buscaUltimoDiaDoMes(DateTime inicio)
        {
            DateTime ultimoDiaDoMes = new DateTime(inicio.Year, inicio.Month, DateTime.DaysInMonth(inicio.Year, inicio.Month));
            return ultimoDiaDoMes;
        }

        public int qtdDiasASeremBuscadosNaAPI(DateTime dataInicio)
        {
            TimeSpan date = Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(dataInicio);

            int totalDias = date.Days;

            return totalDias;
        }

        public int GetQuantidadePaginasSeremImportadas()
        {
            DAL paginacao = new DAL();
            string parametro = "ultima_pagina";
            var aux = paginacao.GetQuantidadePaginasSeremBuscadas(parametro);
            int paginaBuscada = Convert.ToInt32(aux.Rows[0]["valor"].ToString());
            int valorInicial = paginaBuscada;
            OportunidadeRepositorio listaOportunidades = new OportunidadeRepositorio();
            bool existeMaisPagina = true;

            while (existeMaisPagina)
            {
                List<Oportunidade> lista = listaOportunidades.GetOportunidadesAsyncPaginado(paginaBuscada);

                if (lista.Count > 0)
                {
                    paginaBuscada = paginaBuscada + 1;
                }
                else
                {
                    if (valorInicial != paginaBuscada)
                    {
                        paginacao.DeletarConfiguracaoPaginasBuscadas();
                        paginacao.InserirConfiguracao("ultima_pagina", Convert.ToString(paginaBuscada));
                    }
                        
                existeMaisPagina = false;
                    return paginaBuscada;
                }
                
            }
            return paginaBuscada;
        }

        public int GetQuantidadePaginasContatosSeremImportadas()
        {
            DAL paginacao = new DAL();
            string parametro = "ultima_pagina_contatos";
            var aux = paginacao.GetQuantidadePaginasSeremBuscadas(parametro);
            int paginaBuscada = Convert.ToInt32(aux.Rows[0]["valor"].ToString());
            int valorInicial = paginaBuscada;
            OportunidadeRepositorio listaOportunidades = new OportunidadeRepositorio();
            bool existeMaisPagina = true;

            while (existeMaisPagina)
            {
                List<Oportunidade> lista = listaOportunidades.GetOportunidadesAsyncPaginado(paginaBuscada);

                if (lista.Count > 0)
                {
                    paginaBuscada = paginaBuscada + 1;
                }
                else
                {
                    if (valorInicial != paginaBuscada)
                    {
                        paginacao.DeletarConfiguracaoPaginasBuscadas();
                        paginacao.InserirConfiguracao("ultima_pagina", Convert.ToString(paginaBuscada));
                    }

                    existeMaisPagina = false;
                    return paginaBuscada;
                }

            }
            return paginaBuscada;
        }
    }
}

