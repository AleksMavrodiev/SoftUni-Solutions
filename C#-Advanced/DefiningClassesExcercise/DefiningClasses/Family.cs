using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family = new List<Person>();

        public List<Person> Familia { get => family; set => family = value; }

        public Family()
        {
            this.Familia = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Familia.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Familia.OrderByDescending(x => x.Age).First();
        }
    }
}
