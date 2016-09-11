using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    public class AMFactory
    {
        public static IMapper GenerateMapper<T>()
        {
            var profiles = Extensions.Container.ResolveAll<IProfileWrapper<T>>();

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var p in profiles)
                {
                    cfg.AddProfile(p.Profile);
                }
            });

            return config.CreateMapper();
        }
    }
}
