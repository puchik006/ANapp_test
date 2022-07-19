using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class UserInterface
    {
        public UserInterface()
        {
            Customer.OnCarChoosing += ShowSellingCarsList;
            CarShop.OnCarPurachaseApproving += ShowWarningBeforePurchase;

            Mover.OnMoveBackward += ShowBackwardMovement;
            Mover.OnMoveForward += ShowForwardMovement;
            Mover.OnMoveLeft += ShowLeftMovement;
            Mover.OnMoveRight += ShowRightMovement;
            Mover.OnExitMovement += ShowExitMovement;
        }

        private void ShowSellingCarsList(List<Car> carList)
        {
            Console.WriteLine("Выберите машину для покупки из списка ниже:");
            ShowCarList(carList);
            Console.WriteLine("Введите порядковый номер машины:");
        }

        private void ShowWarningBeforePurchase(Car sellingCar)
        {
            Console.WriteLine($"Вы уверены что хотите купить: '{sellingCar}' ? [y/n]");
        }

        public void ShowCarList(List<Car> carList)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine(i + " " + carList[i]);
            }
        }

        public void ShowBackwardMovement() => Console.WriteLine("Вы движетесь назад");
        public void ShowForwardMovement() => Console.WriteLine("Вы движетесь прямо");
        public void ShowLeftMovement() => Console.WriteLine("Вы движетесь влево");
        public void ShowRightMovement() => Console.WriteLine("Вы движетесь вправо");
        public void ShowExitMovement() => Console.WriteLine("Вы прекратили жвижение");
    }
}
