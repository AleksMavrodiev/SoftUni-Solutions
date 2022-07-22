using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Collection_Hierarchy
{
    public class AddCollection : IAddCollection
    {
        private readonly ICollection<string> items;

        public AddCollection()
        {
            this.items = new List<string>();
        }

        public int Add(string item)
        {
            this.items.Add(item);
            return this.items.Count - 1;
        }
    }
}
