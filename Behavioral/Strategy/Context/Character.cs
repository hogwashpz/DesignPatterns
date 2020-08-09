using System;

namespace Strategy
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    public abstract class Character
    {
        private WeaponBehavior weaponBehavior;
        private Random rnd = new Random();

        public void SetStrategy(WeaponBehavior behavior)
        {
            this.weaponBehavior = behavior;
        }

        public abstract void Display();

        public void Fight()
        {
            if (weaponBehavior == null)
                weaponBehavior = new UnarmedBehavior();

            var critHit = rnd.Next(0, 100);
            weaponBehavior.UseWeapon(critHit >= 50);
        }
    }
}
