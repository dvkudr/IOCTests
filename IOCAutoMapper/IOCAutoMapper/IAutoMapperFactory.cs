using System;
using AutoMapper;

namespace IOCAutoMapper
{
    interface IAutoMapperFactory<T>
    {
        IMapper CreateMapper();
    }
}
