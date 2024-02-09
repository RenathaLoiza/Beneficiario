using Dapper;
using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using System.Data.SqlClient;

namespace Beneficiario.Repository.Repository
{

    public class ProdutoRepository : IProdutoRepository
    {
        string banco = @"Server=(localdb)\mssqllocaldb;Database=CadastroBeneficiario;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> DeleteAsync(int ProdutoID)
        {
            string queryDeleteProduto = "DELETE FROM Produto WHERE ProdutoID=@ProdutoID";
            using (SqlConnection conn = new SqlConnection(banco))
            {
                await conn.ExecuteAsync(queryDeleteProduto, new { ProdutoID = ProdutoID });
                return $"Exclusão do {queryDeleteProduto} realizado com sucesso";
            }


        }
        public Task<string> GetActionAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostCadastrarAsync(ProdutoCommand command)
        {
            string queryInsertProduto = @"
             insert into Produto (ProdutoNome ,descricao ,categoria,NomeDoDoador,QuantidadeDisponivelParaDoacao ) 
             values (@produtoNome ,@descricao ,@categoria,@NomeDoDoador,@QuantidadeDisponivelParaDoacao ) ";

            using (SqlConnection conn = new SqlConnection(banco))
            {
                await conn.ExecuteAsync(queryInsertProduto, new
                {
                    ProdutoNome = command.ProdutoNome,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    NomeDoDoador = command.NomeDoDoador,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,


                });

                return "Cadastro realizado com sucesso";
            }
        }

        public async Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            string queryUpdateProduto = "UPDATE Produto SET  (produtoNome ,descricao ,categoria,NomeDoDoador,QuantidadeDisponivelParaDoacao )" +
          "WHERE (@produtoNome ,@descricao ,@categoria,@NomeDoDoador,@QuantidadeDisponivelParaDoacao)";
            using (SqlConnection conn = new SqlConnection(banco))
            {

                conn.Execute(queryUpdateProduto, new
                {
                    ProdutoNome = command.ProdutoNome,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    NomeDoDoador = command.NomeDoDoador,
                    QuantidadeDisponivelParaDoacao = command.QuantidadeDisponivelParaDoacao,

                });
                return "Atualização realizado com sucesso";

            }
        }
    }
}