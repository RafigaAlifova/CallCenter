using Ninject;
using Ninject.Modules;

namespace Core.DependencyResolvers.Ninject
{
    public static class InstanceFactory
    {
        public static T GetInstance<T>(NinjectModule module)
        {
            var kernel= new StandardKernel(module);
            return kernel.Get<T>();
        }
        public static T GetInstance<T>(NinjectModule[] modules)
        {
            var kernel = new StandardKernel(modules);
            return kernel.Get<T>();
        }
    }
}
