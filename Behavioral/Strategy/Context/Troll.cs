using System;

namespace Strategy
{
    public class Troll : Character
    {
        public Troll() : base()
        { }

        public Troll(WeaponBehavior weaponBehavior)
        {
            this.SetStrategy(weaponBehavior);
        }

        public override void Display()
        {
            Console.WriteLine("Trooollllllll!");
        }
    }
}
