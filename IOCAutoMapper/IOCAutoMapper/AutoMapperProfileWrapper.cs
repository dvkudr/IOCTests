using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    public class AutoMapperProfileWrapper<T>
    {
        public AutoMapperProfileWrapper(Profile profile)
        {
            Console.WriteLine($"constructor {nameof(AutoMapperProfileWrapper<T>)} for {typeof(T).Name} and {profile.GetType().Name}");
            Profile = profile;
        }
        public Profile Profile { get; }
    }
}
