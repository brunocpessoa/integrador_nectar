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
            OportunidadeRepositorio listaOportunidades = new OportunidadeRepositorio();
            int paginaBuscada = 1;
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

