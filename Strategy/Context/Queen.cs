using System;

namespace Strategy
{
    public class Queen : Character
    {
        public Queen(WeaponBehavior weaponBehavior)
        {
            this.SetStrategy(weaponBehavior);
        }

        public override void Display()
        {
            Console.WriteLine("I'm queen!");
        }
    }
}
