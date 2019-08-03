using System;

namespace Strategy
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class SwordBehavior : WeaponBehavior
    {
        public override void UseWeapon(bool criticalRole)
        {
            Console.WriteLine($"Using sword, {(criticalRole ? "critical" : "normal")} hit.");
        }
    }
}
