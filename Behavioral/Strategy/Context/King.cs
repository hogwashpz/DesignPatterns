using System;

namespace Strategy
{
    public class King : Character
    {
        public King(WeaponBehavior weaponBehavior)
        {
            this.SetStrategy(weaponBehavior);
        }

        public override void Display()
        {
            Console.WriteLine("I'm king!");
        }
    }
}
