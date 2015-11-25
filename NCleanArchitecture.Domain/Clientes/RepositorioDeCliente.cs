namespace NCleanArchitecture.Domain.Clientes
{
    public interface RepositorioDeCliente
    {
        Cliente ObterPor(int id);
    }
}