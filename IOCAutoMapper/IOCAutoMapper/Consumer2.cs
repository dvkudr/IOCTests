using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    class Consumer2
    {
        private readonly IMapper mapper;

        public Consumer2()
        {
            mapper = AMFactory.GenerateMapper<Consumer2>();
        }
    }
}
