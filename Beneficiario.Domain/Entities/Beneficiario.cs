﻿namespace Beneficiario.Domain.Entities
{
    public class Beneficiario
    {
        public int BeneficiarioId{ get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cep { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
       
    }
}
