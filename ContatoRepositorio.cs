using integrador_nectar_crm;
using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Web.Script.Serialization;

namespace integrador_nectar_crm
{
    public class ContatoRepositorio
    {
        HttpClient client = new HttpClient();
        public List<Contato> GetContatosAsyncPaginado(int pagina)
        {
            List<Contato> contatos = new List<Contato>();
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync("https://app.nectarcrm.com.br/crm/api/1/contatos/?api_token=73d0f6ccb9104c35bf4602d0f4b8ac22&page=" + pagina + "&constante=0,1,2,3,4,5)").Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var resultado = response.Content.ReadAsStringAsync().Result;
                        contatos = new JavaScriptSerializer().Deserialize<List<Contato>>(resultado);
                        return contatos;
                    }
                    return null;
                }
            }
        }
    }
}
