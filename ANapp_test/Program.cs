using System;
using System.Collections;
using System.Collections.Generic;

namespace ANapp_test
{
    class Program
    {
        private static CarShop JoeyUsedCar = new CarShop();

        private const string MAIN_MENU_TEXT =
            "1.Управление автомобилем. \r\n" +
            "2.Поездка на автомобиле. \r\n" +
            "3.Повреждение автомобиля.\r\n" +
            "4.Выбор автомобиля для покупки.\r\n" +
            "5.Диагностика неисправленности и ремонт автомобиля";

        static void Main(string[] args)
        {
            Console.WriteLine(MAIN_MENU_TEXT);


            JoeyUsedCar.ChooseCar();

            JoeyUsedCar.

        }

        public static void UserAction()
        {
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("sadas");
            }
        }
    }


    public class Car
    {
        private string _model;
        private string _color;
        private int _yearOfManufacture;

        public CarDamageController DamageController = new CarDamageController();

        public Car(string model, string color, int yearOfManufacture)
        {
            _model = model;
            _color = color;
            _yearOfManufacture = yearOfManufacture;
        }

        public void Move() 
        {
        }

        public override string ToString()
        {
            return (_model + " " + _color + " " + _yearOfManufacture);
        }

    }
}
