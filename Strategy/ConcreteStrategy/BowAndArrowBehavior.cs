using System;

namespace Strategy
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public override void UseWeapon(bool criticalRole)
        {
            Console.WriteLine($"Using bow and arrow, {(criticalRole ? "critical" : "normal")} hit.");
        }
    }
}
