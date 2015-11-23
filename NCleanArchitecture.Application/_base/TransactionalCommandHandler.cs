namespace NCleanArchitecture.Application._base
{
    public class TransactionalCommandHandler<TCommand> : CommandHandler<TCommand> where TCommand : Command
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly CommandHandler<TCommand> _commandHandler;

        public TransactionalCommandHandler(UnitOfWork unitOfWork, CommandHandler<TCommand> commandHandler)
        {
            _unitOfWork = unitOfWork;
            _commandHandler = commandHandler;
        }

        public void Executar(TCommand cmd)
        {
            _unitOfWork.BeginTransaction();

            try
            {
                _commandHandler.Executar(cmd);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}