using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Profile1();
            var p2 = new Profile2();

            Extensions.Container.RegisterType<IProfileWrapper<Consumer1>, ProfileWrapper<Consumer1>>(
                nameof(p1), new ContainerControlledLifetimeManager(), new InjectionConstructor(p1));

            Extensions.Container.RegisterType<IProfileWrapper<Consumer1>, ProfileWrapper<Consumer1>>(
                nameof(p2), new ContainerControlledLifetimeManager(), new InjectionConstructor(p2));

            Extensions.Container.RegisterType<IProfileWrapper<Consumer2>, ProfileWrapper<Consumer2>>(
                nameof(p2), new ContainerControlledLifetimeManager(), new InjectionConstructor(p2));

            var c1 = new Consumer1();
            var c2 = new Consumer2();
        }
    }
}
