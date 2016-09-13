using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;

namespace IOCAutoMapper
{
    public class AutoMapperFactory<T> : IAutoMapperFactory<T>
    {
        private readonly IEnumerable<Profile> _profiles;
        private IMapper _mapper;
        public AutoMapperFactory(params Profile[] profiles)
        {
            Console.WriteLine($"constructor {nameof(AutoMapperFactory<T>)} for {typeof(T).Name}");
            _profiles = new ReadOnlyCollection<Profile>(profiles);
        }

        public IMapper CreateMapper()
        {
            if (_mapper == null)
            {
                var consumerType = typeof(T);
                Console.WriteLine($"{nameof(AutoMapperFactory<T>)}.{nameof(CreateMapper)} for {consumerType.Name}");

                var config = new MapperConfiguration(cfg =>
                {
                    foreach (var p in _profiles)
                    {
                        cfg.AddProfile(p);
                    }
                });

                _mapper = config.CreateMapper();
            }

            return _mapper;
        }
    }
}
