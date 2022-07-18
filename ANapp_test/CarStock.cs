using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class CarStock 
    {
        public readonly List<Car> CarList = new List<Car>();
        
        public CarStock()
        {
            CarList.Add(new Car("Lada", "red", 1970));
            CarList.Add(new Car("Volvo", "blue", 1986));
            CarList.Add(new Car("Porsche", "orange", 1995));
        }

        public void RemoveCarFromList(int carNumber)
        {
            CarList.RemoveAt(carNumber);
        }

        public void ShowCarList()
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                Console.WriteLine(i + " " + CarList[i]);
            }
        }

    }

}
