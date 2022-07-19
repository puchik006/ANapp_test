using System;
using System.Collections;
using System.Collections.Generic;

namespace ANapp_test
{
    class Program
    {
        private static CarShop JoeyUsedCar = new CarShop();
        private static Customer Mikle = new Customer();
        private static UserInterface UI = new UserInterface();
        private static UserInputSystem Input = new UserInputSystem();

        private static Car asd = new Car("asd","asd",12);

        private const string MAIN_MENU_TEXT =
            "1.Управление автомобилем. \r\n" +
            "2.Поездка на автомобиле. \r\n" +
            "3.Повреждение автомобиля.\r\n" +
            "4.Выбор автомобиля для покупки.\r\n" +
            "5.Диагностика неисправленности и ремонт автомобиля";

        static void Main(string[] args)
        {
            Console.WriteLine(MAIN_MENU_TEXT);

            asd.StartMovement(new Mover());

            //Mikle.ChooseCar(JoeyUsedCar.CarList());

            //UI.ShowCarList(JoeyUsedCar.CarList());

            //UI.ShowCarList(Mikle.CarList());

        }
    }
}
