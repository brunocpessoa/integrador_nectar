using integrador_nectar_crm;
using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Web.Script.Serialization;

namespace integrador_nectar_crm
{
    public class TarefaRepositorio
    {
        HttpClient client = new HttpClient();
        public List<Tarefa> GetTarefasAsyncPaginado(int pagina)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync("https://app.nectarcrm.com.br/crm/api/1/tarefas/?api_token=73d0f6ccb9104c35bf4602d0f4b8ac22&page=" + pagina).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var resultado = response.Content.ReadAsStringAsync().Result;
                        tarefas = new JavaScriptSerializer().Deserialize<List<Tarefa>>(resultado);
                        return tarefas;
                    }
                    return null;
                }
            }
        }
    }
}
