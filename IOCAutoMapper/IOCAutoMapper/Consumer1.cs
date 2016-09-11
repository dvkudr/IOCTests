using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;

namespace IOCAutoMapper
{
    public class Consumer1
    {
        private readonly IMapper mapper;

        public Consumer1()
        {
            mapper = Extensions.Container.Resolve<AMFactory>().GenerateMapper<Consumer1>();
        }
    }
}
