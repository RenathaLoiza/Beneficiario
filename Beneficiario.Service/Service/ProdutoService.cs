using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;

namespace Beneficiario.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

        }
        public async Task<string> DeleteAsync(int ProdutoID)
        {
            return await _produtoRepository.DeleteAsync(ProdutoID);
        }

        public async Task<string> GetActionAsync()
        {
            return await _produtoRepository.GetActionAsync();
        }

        public async Task<string> PostCadastrarAsync(ProdutoCommand command)
        {
            return await _produtoRepository.PostCadastrarAsync(command);
        }

        public async Task<string> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            return await _produtoRepository.PutAtualizarAsync(ProdutoID, command);
        }
    }
}
