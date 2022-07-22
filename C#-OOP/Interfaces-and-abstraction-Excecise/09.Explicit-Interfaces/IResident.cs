using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Explicit_Interfaces
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }

        void GetName();
    }
}
