using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    public class ProfileWrapper<T> : IProfileWrapper<T>
    {
        public ProfileWrapper(Profile profile)
        {
            Profile = profile;
        }
        public Profile Profile { get; }
    }
}
