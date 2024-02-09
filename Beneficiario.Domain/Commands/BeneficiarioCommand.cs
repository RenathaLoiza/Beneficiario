namespace Beneficiario.Domain.Commands
{
    public class BeneficiarioCommand
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cep { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
    }
}
