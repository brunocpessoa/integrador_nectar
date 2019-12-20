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

    public class RegiaoPais
    {
        public string nome { get; set; }
        public int id { get; set; }
    }

    public class Pais
    {
        public string nome { get; set; }
        public int id { get; set; }
    }

    public class RegiaoEstado
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public Pais pais { get; set; }
    }

    public class RegiaoMunicipio
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int codigoUnidadeGeografica { get; set; }
        public int codigoMunicipioIbge { get; set; }
        public bool isCapital { get; set; }
    }
    public class EstadoObject
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
    }

    public class PaisObject
    {
        public string nome { get; set; }
        public int id { get; set; }
    }

    public class Estado
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
    }

    public class MunicipioObject
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Estado estado { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int codigoUnidadeGeografica { get; set; }
        public int codigoMunicipioIbge { get; set; }
        public bool isCapital { get; set; }
    }

    public class Endereco
    {
        public int id { get; set; }
        public string cep { get; set; }
        public string tipo { get; set; }
        public bool principal { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public string endereco { get; set; }
        public string estado { get; set; }
        public EstadoObject estadoObject { get; set; }
        public string pais { get; set; }
        public PaisObject paisObject { get; set; }
        public string municipio { get; set; }
        public MunicipioObject municipioObject { get; set; }
        public int? codigoMunicipioIbge { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
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

    public class Contato
    {
        public int id { get; set; }
        public Autor autor { get; set; }
        public AutorAtualizacao autorAtualizacao { get; set; }
        public Responsavel responsavel { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string rg { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAtualizacao { get; set; }
        public string observacao { get; set; }
        public string cargo { get; set; }
        public string indicadoPor { get; set; }
        public string facebook { get; set; }
        public string linkedin { get; set; }
        public string twitter { get; set; }
        public string skype { get; set; }
        public string segmento { get; set; }
        public RegiaoPais regiaoPais { get; set; }
        public RegiaoEstado regiaoEstado { get; set; }
        public bool ativo { get; set; }
        public bool empresa { get; set; }
        public int constante { get; set; }
        public int tarefas { get; set; }
        public int compromissos { get; set; }
        public int oportunidades { get; set; }
        public List<object> telefones { get; set; }
        public string telefonePrincipal { get; set; }
        public string telefone { get; set; }
        public List<string> emails { get; set; }
        public string emailPrincipal { get; set; }
        public string email { get; set; }
        public List<object> contatos { get; set; }
        public List<Endereco> enderecos { get; set; }
        public CamposPersonalizados camposPersonalizados { get; set; }
        public List<object> listas { get; set; }
        public bool isEmpresa { get; set; }
        public RegiaoMunicipio regiaoMunicipio { get; set; }
        public string cnpj { get; set; }
    }
}
