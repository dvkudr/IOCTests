using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    public class AutoMapperFactory
    {
        private readonly Dictionary<Type, IMapper> _mappers;
        public AutoMapperFactory()
        {
            Console.WriteLine($"constructor {nameof(AutoMapperFactory)}");

            _mappers = new Dictionary<Type, IMapper>();
        }

        public IMapper GenerateMapper<T>()
        {
            var consumerType = typeof(T);
            IMapper mapper;
            if (_mappers.TryGetValue(consumerType, out mapper))
            {
                return mapper;
            }

            Console.WriteLine($"{nameof(AutoMapperFactory)}.{nameof(GenerateMapper)} for {consumerType.Name}");

            var profiles = Extensions.Container.ResolveAll<AutoMapperProfileWrapper<T>>();

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var p in profiles)
                {
                    cfg.AddProfile(p.Profile);
                }
            });

            mapper = config.CreateMapper();

            _mappers.Add(consumerType, mapper);

            return mapper;
        }
    }
}
