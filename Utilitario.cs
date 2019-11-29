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
            DAL ultimaPagina = new DAL();
            string parametro = "ultima_pagina";
            var aux = ultimaPagina.GetQuantidadePaginasSeremBuscadas(parametro);
            int paginaBuscada = Convert.ToInt32(aux.Rows[0]["valor"].ToString());
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
                    existeMaisPagina = false;
                    return paginaBuscada;
                }
                
            }
            return paginaBuscada;
        }
    }
}

