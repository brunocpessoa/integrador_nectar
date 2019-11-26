using integrador_nectar_crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador_nectar_crm
{
    public class Responsavel
    {
        public int id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }
    }

    public class Autor
    {
        public int id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
    }
    public class AutorAtualizacao
    {
        public int id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
    }

    public class Cliente
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string telefonePrincipal { get; set; }
        public string telefone { get; set; }
        public string emailPrincipal { get; set; }
        public string email { get; set; }
    }

    public class FunilVenda
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool padrao { get; set; }
    }

    public class Produto
    {
        public int id { get; set; }
        public int refId { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }
        public double desconto { get; set; }
        public bool isDescontoPorcentual { get; set; }
        public double comissao { get; set; }
        public bool isComissaoPorcentual { get; set; }
        public int recorrencia { get; set; }
        public double quantidade { get; set; }
        public int quantidadeRecorrencia { get; set; }
        public string nome { get; set; }
    }

    public class Origem
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool ativo { get; set; }
    }

    public class CamposPersonalizados
    {
        public string Indicador_Trier_Mais_1 { get; set; }
        public string campanha { get; set; }
        public string agente { get; set; }
        public string Software_Concorrente { get; set; }
        public string Status_da_negociacao { get; set; }
    }

    public class Campanha
    {
        public object idRelacionado { get; set; }
        public string valor { get; set; }
        public int id { get; set; }
    }

    public class Agente
    {
        public object idRelacionado { get; set; }
        public string valor { get; set; }
        public int id { get; set; }
    }


    public class Oportunidade
    {
        public int id { get; set; }
        public Responsavel responsavel { get; set; }
        public Autor autor { get; set; }
        public AutorAtualizacao autorAtualizacao { get; set; }
        public string nome { get; set; }
        public Cliente cliente { get; set; }
        public CamposPersonalizados camposPersonalizados { get; set; }
        public string codigo { get; set; }
        public Agente agente { get; set; }
        public int status { get; set; }
        public int tarefas { get; set; }
        public int compromissos { get; set; }
        public int atividadesAtrasadas { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataConclusao { get; set; }
        public DateTime dataAtualizacao { get; set; }
        public DateTime dataLimite { get; set; }
        public string pipeline { get; set; }
        public FunilVenda funilVenda { get; set; }
        public int etapa { get; set; }
        public string etapaNome { get; set; }
        public int probabilidade { get; set; }
        public string temperatura { get; set; }
        public double valorAvulso { get; set; }
        public double valorMensal { get; set; }
        public double valorTotal { get; set; }
        public double valorTotalDescontos { get; set; }
        public List<Produto> produtos { get; set; }
        public Origem origem { get; set; }
        public List<object> justificativas { get; set; }
        public List<object> justificativasOpcoes { get; set; }
        public int diasEstagnacaoNaEtapa { get; set; }
        public int diasSemInteracao { get; set; }
        public int quantidadeProdutos { get; set; }
    }
}
