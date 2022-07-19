using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class Customer: CarOwner
    {
        private CustomerCarStock _customerCars = new CustomerCarStock();

        public override List<Car> CarList()
        {
            return _customerCars.CarList;
        }

        public static Action<List<Car>> OnCarChoosing;

        public Customer()
        {
            CarShop.OnCarSold += BuyCar;
        }

        public void ChooseCar(List<Car> carList)
        {
            OnCarChoosing?.Invoke(carList);
        }

        private void BuyCar(Car buyedCar)
        {
            _customerCars.CarList.Add(buyedCar);
        }
    }
}
