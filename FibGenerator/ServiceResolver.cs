using Castle.Windsor;
using Castle.Windsor.Installer;

namespace FibGenerator;

public static class ServiceResolver
{
    private static IWindsorContainer _container;

    public static void Initialize()
    {
        _container = new WindsorContainer();
        _container.Install(new DomainInstaller());
    }

    public static TService Resolve<TService>()
    {
        return _container.Resolve<TService>();
    }

    public static void DisposeContainer()
    {
        _container.Dispose();
    }
}
