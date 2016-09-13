using System;
using System.Runtime.Remoting.Messaging;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Extensions.Container.RegisterType<Profile1>(new ContainerControlledLifetimeManager());
            Extensions.Container.RegisterType<Profile2>(new ContainerControlledLifetimeManager());

            Extensions.Container.RegisterType<AutoMapperProfileContainer<Consumer1>>(new ContainerControlledLifetimeManager(),
                new InjectionFactory(c => new AutoMapperProfileContainer<Consumer1>(
                    new Profile[]
                    {
                        c.Resolve<Profile1>(),
                        c.Resolve<Profile2>()
                    })));

            Extensions.Container.RegisterType<AutoMapperProfileContainer<Consumer2>>(new ContainerControlledLifetimeManager(),
                new InjectionFactory(c => new AutoMapperProfileContainer<Consumer2>(
                    new Profile[] { c.Resolve<Profile2>() })));

            Extensions.Container.RegisterType(typeof(IAutoMapperFactory<>), typeof(AutoMapperFactory<>), new ContainerControlledLifetimeManager());

            var c1 = new Consumer1();
            var c2 = new Consumer2();

            var d1 = new Consumer1();
            var d2 = new Consumer2();

            Console.ReadLine();
        }
    }
}
