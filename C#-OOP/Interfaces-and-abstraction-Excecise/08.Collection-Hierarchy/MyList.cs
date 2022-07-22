using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Collection_Hierarchy
{
    public class MyList : IMyList
    {
        private readonly IList<string> items;

        public MyList()
        {
            this.items = new List<string>();
        }

        public int Used => this.items.Count;

        public int Add(string item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string elementToRemove = this.items.FirstOrDefault();
            if (elementToRemove != null)
            {
                this.items.Remove(elementToRemove);
            }
            return elementToRemove;
        }
    }
}
