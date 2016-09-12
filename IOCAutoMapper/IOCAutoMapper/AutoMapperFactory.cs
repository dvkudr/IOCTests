using System;
using AutoMapper;

namespace IOCAutoMapper
{
    public class AutoMapperFactory<T>
    {
        private readonly AutoMapperProfileContainer<T> _profileContainer;
        private IMapper _mapper;
        public AutoMapperFactory(AutoMapperProfileContainer<T> profileContainer)
        {
            Console.WriteLine($"constructor {nameof(AutoMapperFactory<T>)} for {typeof(T).Name}");
            _profileContainer = profileContainer;
        }

        public IMapper GenerateMapper()
        {
            if (_mapper == null)
            {
                var consumerType = typeof(T);
                Console.WriteLine($"{nameof(AutoMapperFactory<T>)}.{nameof(GenerateMapper)} for {consumerType.Name}");

                var config = new MapperConfiguration(cfg =>
                {
                    foreach (var p in _profileContainer.Profiles)
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
