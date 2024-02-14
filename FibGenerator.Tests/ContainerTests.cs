using FibGenerator.CommandHandlers.FibCommandHandler;
using FibGenerator.CommandHandlers.FibGenerator;
using FibGenerator.CommandHandlers.HelpCommandHandler;
using Shouldly;

namespace FibGenerator.Tests
{
    [TestFixture]
    public class ServiceResolverTests
    {
        [SetUp]
        public void SetUp()
        {
            //Arrange
            ServiceResolver.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            ServiceResolver.DisposeContainer();
        }

        [Test]
        public void Resolve_IFibGenerator_IsCorrectType()
        {
            // Act
            var fibGenerator = ServiceResolver.Resolve<IFibGenerator>();

            // Assert
            fibGenerator.ShouldBeOfType<RecursiveFibGenerator>();

            // Clean up
            ServiceResolver.DisposeContainer();
        }

        [Test]
        public void Resolve_IFibCommandHandler_IsCorrectType()
        {

            // Act
            var fibCommandHandler = ServiceResolver.Resolve<IFibCommandHandler>();

            // Assert
            fibCommandHandler.ShouldBeOfType<FibCommandHandler>();

            // Clean up
            ServiceResolver.DisposeContainer();
        }

        [Test]
        public void Resolve_IHelpCommandHandler_IsCorrectType()
        {

            // Act
            var helpCommandHandler = ServiceResolver.Resolve<IHelpCommandHandler>();

            // Assert
            helpCommandHandler.ShouldBeOfType<HelpCommandHandler>();

            // Clean up
            ServiceResolver.DisposeContainer();
        }
    }
}
