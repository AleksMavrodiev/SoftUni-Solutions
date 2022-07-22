using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Explicit_Interfaces
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }

        void GetName();
    }
}
