using System;

namespace Animals.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return $"I am {name} and my favorite food is {favouriteFood}{Environment.NewLine}BORK";
        }
    }
}
