using NCleanArchitecture.CompositionRoot;
using NUnit.Framework;

namespace NCleanArchitecture.UnitTests
{
    [TestFixture]
    public class CompositionRootBootstrapTests
    {
        [Test]
        public void Deve_obter_container_configurado_corretamente()
        {
            var container = CompositionRootBootstrap.Compose();
            container.Verify();
        }
    }
}
