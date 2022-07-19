using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class UserInputSystem
    {
        public static Action<Car> OnCarChoosed;
        public static Action<Car> OnCarSaleApproved;

        public UserInputSystem()
        {
            Customer.OnCarChoosing += GetChosenCar;
            CarShop.OnCarPurachaseApproving += GetPurchaseApprovement;
        }

        private void GetChosenCar(List<Car> carList)
        {
            int choosenCar = int.Parse(Console.ReadLine());

            OnCarChoosed?.Invoke(carList[choosenCar]);
        }

        private void GetPurchaseApprovement(Car soldCar)
        {
            if (Console.ReadLine() == "y")
            {
                OnCarSaleApproved?.Invoke(soldCar);
            }
            else if (Console.ReadLine() == "n")
            {
                //TODO
            }
            else
            {
                //TODO
            }
        }

    }
}
