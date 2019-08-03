using System;

namespace Strategy
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    public class UnarmedBehavior : WeaponBehavior
    {
        public override void UseWeapon(bool criticalRole)
        {
            Console.WriteLine($"Using unarmed, {(criticalRole ? "critical" : "normal")} hit.");
        }
    }
}
