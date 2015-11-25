using NCleanArchitecture.Application._base;
using NCleanArchitecture.Domain.Clientes;

namespace NCleanArchitecture.Application.Clientes
{
    public class AtualizacaoDeEndereco : CommandHandler<AtualizarEndereco>
    {
        private readonly RepositorioDeCliente _repositorioDeCliente;

        public AtualizacaoDeEndereco(RepositorioDeCliente repositorioDeCliente)
        {
            _repositorioDeCliente = repositorioDeCliente;
        }

        public void Executar(AtualizarEndereco cmd)
        {
            var cliente = _repositorioDeCliente.ObterPor(cmd.IdDoCliente);
            var novoEndereco = new Endereco(cmd.Logradouro, cmd.Bairro, cmd.Cep);
            cliente.AtualizarEndereco(novoEndereco);
        }
    }
}
