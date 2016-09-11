using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    public class ProfileWrapper<T>
    {
        public ProfileWrapper(Profile profile)
        {
            Console.WriteLine($"{nameof(ProfileWrapper<T>)} {profile.GetType().Name}");
            Profile = profile;
        }
        public Profile Profile { get; }
    }
}
