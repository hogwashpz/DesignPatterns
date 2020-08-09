using System;

namespace Strategy
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class ClubBehavior : WeaponBehavior
    {
        public override void UseWeapon(bool criticalRole)
        {
            Console.WriteLine($"Using club, {(criticalRole ? "critical" : "normal")} hit.");
        }
    }
}
