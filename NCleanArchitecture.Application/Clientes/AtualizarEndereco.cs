using NCleanArchitecture.Application._base;

namespace NCleanArchitecture.Application.Clientes
{
    public class AtualizarEndereco : Command
    {
        public int IdDoCliente { get; private set; }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }

        public AtualizarEndereco(int idDoCliente, string logradouro, string bairro, string cep)
        {
            IdDoCliente = idDoCliente;
            Logradouro = logradouro;
            Bairro = bairro;
            Cep = cep;
        }
    }
}