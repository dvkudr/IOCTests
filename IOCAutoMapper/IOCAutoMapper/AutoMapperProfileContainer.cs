using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;

namespace IOCAutoMapper
{
    public class AutoMapperProfileContainer<T>
    {
        public AutoMapperProfileContainer(IList<Profile> profiles)
        {
            Console.WriteLine($"constructor {nameof(AutoMapperProfileContainer<T>)} for {typeof(T).Name}");
            Profiles = new ReadOnlyCollection<Profile>(profiles);
        }
        public IEnumerable<Profile> Profiles { get; }
    }
}
