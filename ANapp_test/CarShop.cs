using System;

namespace ANapp_test
{
    public class CarShop
    {
        private CarStock carsForSale = new CarStock();

        public void ChooseCar()
        {
            Console.WriteLine("Выберите машину для покупки из списка ниже:");

            carsForSale.ShowCarList();

            Console.WriteLine("Введите порядковый номер машины:");

            int choosenCar = int.Parse(Console.ReadLine());

            Console.WriteLine($"Поздравляем, вы купили: {carsForSale.CarList[choosenCar]}");
            BuyCar(choosenCar);
        }

        private void BuyCar(int choosenCar)
        {
            carsForSale.RemoveCarFromList(choosenCar);
        }
    }
}
