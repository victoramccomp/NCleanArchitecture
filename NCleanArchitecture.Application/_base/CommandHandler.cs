namespace NCleanArchitecture.Application._base
{
    public interface CommandHandler<in TCommand> where TCommand : Command
    {
        void Executar(TCommand cmd);
    }
}