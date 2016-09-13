using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    class Consumer2
    {
        private readonly IMapper mapper;

        public Consumer2()
        {
            Console.WriteLine($"constructor {nameof(Consumer2)}");
            mapper = Extensions.Container.Resolve<IAutoMapperFactory<Consumer2>>().CreateMapper();
        }
    }
}
