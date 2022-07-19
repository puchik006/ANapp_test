using System;
using System.Collections;
using System.Collections.Generic;

namespace ANapp_test
{
    class Program
    {
        private static IMainMenu _mainMenu = new MainMenuInput();

        private static CarShop JoeyUsedCar = new CarShop();
        private static Customer Mikle = new Customer();
        private static UserInterface UI = new UserInterface();
        private static UserInputSystem Input = new UserInputSystem();

        private static void Main(string[] args)
        {
            MainMenuInput.OnCustomerPurchaseCar += CustomerPurchaseCar;
            MainMenuInput.OnCustomerDriving += CustomerDriveCar;
            MainMenuInput.OnExit += Exit;

            _mainMenu.MainMenuActions();



        }


        private static void CustomerPurchaseCar()
        {
            Mikle.ChooseCar(JoeyUsedCar.CarList());
        }

        private static void CustomerDriveCar()
        {
            if (Mikle.CarList().Count == 0)
            {
                Console.WriteLine("У вас пока нет машины - купите её в магазине Джоуи");
            }
            else
            {
                Console.WriteLine("На какой машине будете ездить?");
                UI.ShowCarList(Mikle.CarList());

                int carNumber = int.Parse(Console.ReadLine());

                Mikle.CarList()[carNumber].Movement(new Mover());
            }
        }

        private static void Exit() => Environment.Exit(0);

    }
}
