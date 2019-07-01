using System;

namespace Farmacia.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
