namespace Beneficiario.Domain.Entities
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string ProdutoNome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string NomeDoDoador { get; set; }
        public string QuantidadeDisponivelParaDoacao { get; set; }
    }
}
