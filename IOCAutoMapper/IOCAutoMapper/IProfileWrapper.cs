using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    public interface IProfileWrapper<T>
    {
        Profile Profile { get; }
    }
}
