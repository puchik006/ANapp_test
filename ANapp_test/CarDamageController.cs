using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class CarDamageController
    {
        public List<CarDamage> DamageHistory = new List<CarDamage>();

        public void TakeDamage(string carPart, int damagePecent)
        {
            CarDamage damage = new CarDamage(carPart, damagePecent);
            DamageHistory.Add(damage);

            Console.WriteLine($"Damage taken {carPart}: {damagePecent}%");
        }
    }


}
