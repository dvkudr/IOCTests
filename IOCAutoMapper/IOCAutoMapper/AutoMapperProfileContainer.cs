using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IOCAutoMapper
{
    public class AutoMapperProfileContainer<T>
    {
        public AutoMapperProfileContainer(Profile[] profiles)
        {
            Console.WriteLine($"constructor {nameof(AutoMapperProfileContainer<T>)} for {typeof(T).Name}");
            Profiles = new ReadOnlyCollection<Profile>(profiles);
        }
        public IEnumerable<Profile> Profiles { get; }
    }
}
