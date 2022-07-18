using System;

namespace ANapp_test
{
    static class WorkShop
    {
        public static void Diagnostic(Car car)
        {
            if (car.DamageController.DamageHistory.Count == 0)
            {
                Console.WriteLine($"Машина {car} в порядке");
            }
            else
            {
                Console.WriteLine("У машины повреждены: ");

                foreach (var damage in car.DamageController.DamageHistory)
                {
                    Console.WriteLine(damage);
                }
            }
        }

        public static void Repair(Car car) 
        {
            car.DamageController.DamageHistory.Clear();

            Console.WriteLine($"Машина {car} полностью отремонтирована");
        }
    }
}
