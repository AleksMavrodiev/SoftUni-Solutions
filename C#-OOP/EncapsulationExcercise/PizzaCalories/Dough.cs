using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private readonly string[] flourTypes = { "white", "wholegrain" };
        private readonly string[] bakingTechniques = { "crispy", "chewy", "homemade" };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private double GetCalories()
        {
            double modifier = 0;
            if (this.FlourType.ToLower() == "white")
            {
                modifier = 1.5;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                modifier = 1.0;
            }
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                modifier *= 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                modifier *= 1.1;
            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                modifier *= 1.0;
            }
            return 2 * this.Weight * modifier;
        }

        public double Calories => GetCalories();

        public string FlourType 
        {
            get
            {
                return this.flourType;
            } 
            private set
            {
                if (!flourTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique 
        { 
            get
            {
                return this.bakingTechnique;
            } 
            private set
            {
                if (!this.bakingTechniques.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            } 
        }

        public double Weight 
        { 
            get
            {
                return this.weight;
            } 
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            } 
        }
    }
}
