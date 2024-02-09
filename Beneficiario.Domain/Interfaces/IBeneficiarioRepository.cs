using Beneficiario.Domain.Commands;

namespace Beneficiario.Domain.Interfaces
{
    public interface IBeneficiarioRepository
    {
        Task<string> PostCadastrarAsync(BeneficiarioCommand command);
        Task<string> GetActionAsync();
        Task<string> PutAtualizarAsync(int BeneficiarioID, BeneficiarioCommand command);
        Task<string> DeleteAsync(int BeneficiarioID);
    }
}
