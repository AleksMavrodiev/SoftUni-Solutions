using _3.Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        private string name;
        

        public BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public virtual int Power { get; }
        

        public virtual string CastAbility()
        {
            return "Casting spell"; 
        }
    }
}
