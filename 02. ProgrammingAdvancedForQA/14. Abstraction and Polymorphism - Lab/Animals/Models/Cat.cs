using System;

namespace Animals.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return $"I am {name} and my favorite food is {favouriteFood}{Environment.NewLine}MEEOW";
        }
    }
}
