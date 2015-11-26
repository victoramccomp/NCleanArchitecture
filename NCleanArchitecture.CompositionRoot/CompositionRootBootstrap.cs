using NCleanArchitecture.Application._base;
using NCleanArchitecture.Domain.Clientes;
using NCleanArchitecture.Infrastructure;
using SimpleInjector;

namespace NCleanArchitecture.CompositionRoot
{
    public static class CompositionRootBootstrap
    {
        public static Container Compose()
        {
            var container = new Container();

            // TODO: configuracao manual temporaria
            container.Register<RepositorioDeCliente, RepositorioDeClienteEmMemoria>();
            container.Register<Transactional, FakeTransactional>();

            // registrando commandhandlers e seus decorators
            container.Register(typeof(CommandHandler<>), new[] { typeof(CommandHandler<>).Assembly });
            container.RegisterDecorator(typeof(CommandHandler<>), typeof(TransactionalCommandHandler<>));

            return container;
        }
    }
}