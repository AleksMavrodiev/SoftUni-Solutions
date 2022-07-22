using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Collection_Hierarchy
{
    public interface IMyList : IAddRemoveCollection
    {
        public int Used { get;}
    }
}
