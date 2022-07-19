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
            CarShop.OnCarSold += ShowCongratulations;

            Car.OnCarStartMovement += ShowInstructionsBeforeMovement;

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

        public void ShowCarList(List<Car> carList)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine(i + " " + carList[i]);
            }
        }

        private void ShowWarningBeforePurchase(Car sellingCar)
        {
            Console.WriteLine($"Вы уверены что хотите купить: '{sellingCar}' ? [y/n]");
        }

        private void ShowCongratulations(Car sellingCar)
        {
            Console.WriteLine($"Поздравляем с покупкой '{sellingCar}' !!!"); 
        }

        private void ShowInstructionsBeforeMovement() => Console.WriteLine("Для движения используйте 'w,a,s,d' для выхода из режима вождения нажмите 'x'"); 

        private void ShowBackwardMovement() => Console.WriteLine("Вы движетесь назад");
        private void ShowForwardMovement() => Console.WriteLine("Вы движетесь прямо");
        private void ShowLeftMovement() => Console.WriteLine("Вы движетесь влево");
        private void ShowRightMovement() => Console.WriteLine("Вы движетесь вправо");
        private void ShowExitMovement() => Console.WriteLine("Вы прекратили жвижение");
    }
}
