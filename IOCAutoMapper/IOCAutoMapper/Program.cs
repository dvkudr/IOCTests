using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Profile1();
            var p2 = new Profile2();

            Extensions.Container.RegisterType<AutoMapperProfileContainer<Consumer1>>(
                new ContainerControlledLifetimeManager(), new InjectionConstructor(new object[] {new Profile[]{ p1, p2 }}));

            Extensions.Container.RegisterType<AutoMapperProfileContainer<Consumer2>>(
                new ContainerControlledLifetimeManager(), new InjectionConstructor(new object[] { new Profile[] { p1 } }));

            Extensions.Container.RegisterType<AutoMapperFactory>(new ContainerControlledLifetimeManager());

            var c1 = new Consumer1();
            var c2 = new Consumer2();

            var d1 = new Consumer1();
            var d2 = new Consumer2();

            Console.ReadLine();
        }
    }
}
