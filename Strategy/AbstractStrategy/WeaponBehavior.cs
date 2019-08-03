using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// Encapsulated behavior
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    public abstract class WeaponBehavior
    {
        public abstract void UseWeapon(bool criticalRole);
    }
}
