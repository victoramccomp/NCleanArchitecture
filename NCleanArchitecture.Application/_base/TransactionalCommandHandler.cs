namespace NCleanArchitecture.Application._base
{
    public class TransactionalCommandHandler<TCommand> : CommandHandler<TCommand> where TCommand : Command
    {
        private readonly Transactional _transactional;
        private readonly CommandHandler<TCommand> _commandHandler;

        public TransactionalCommandHandler(Transactional transactional, CommandHandler<TCommand> commandHandler)
        {
            _transactional = transactional;
            _commandHandler = commandHandler;
        }

        public void Executar(TCommand cmd)
        {
            _transactional.BeginTransaction();

            try
            {
                _commandHandler.Executar(cmd);
                _transactional.Commit();
            }
            catch
            {
                _transactional.Rollback();
                throw;
            }
        }
    }
}