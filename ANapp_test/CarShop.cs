using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public class CarShop: CarOwner
    {
        private ShopCarStock _carsForSale = new ShopCarStock();

        public static Action<Car> OnCarPurachaseApproving;
        public static Action<Car> OnCarSold;

        public CarShop()
        {
            UserInputSystem.OnCarChoosed += ApproveCarPurchase;
            UserInputSystem.OnCarSaleApproved += SellCar;
        }

        private void ApproveCarPurchase(Car sellingCar)
        {
            OnCarPurachaseApproving?.Invoke(sellingCar);
        }

        private void SellCar(Car sellingCar)
        {
            OnCarSold?.Invoke(sellingCar);
            _carsForSale.CarList.Remove(sellingCar);
        }

        public override List<Car> CarList()
        {
            return _carsForSale.CarList;
        }
    }
}
