using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Collection_Hierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private readonly IList<string> items;

        public AddRemoveCollection()
        {
            this.items = new List<string>();
        }

        public int Add(string item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string itemToRemove = this.items.LastOrDefault();
            if (itemToRemove != null)
            {
                this.items.Remove(itemToRemove);
            }
            return itemToRemove;
        }
    }
}
