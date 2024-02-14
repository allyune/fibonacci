using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FibGenerator.CommandHandlers;
using FibGenerator.CommandHandlers.FibCommandHandler;
using FibGenerator.CommandHandlers.FibGenerator;
using FibGenerator.CommandHandlers.HelpCommandHandler;

public class DomainInstaller : IWindsorInstaller
{
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(Component.For<IFibGenerator>().ImplementedBy<RecursiveFibGenerator>());
        container.Register(Component.For<IFibCommandHandler>().ImplementedBy<FibCommandHandler>());
        container.Register(Component.For<IHelpCommandHandler>().ImplementedBy<HelpCommandHandler>());
    }
}

