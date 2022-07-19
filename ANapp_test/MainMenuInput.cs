using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public  class MainMenuInput : IMainMenu
    {
        public static Action OnCustomerPurchaseCar;
        public static Action OnCustomerMaintenanceCar;
        public static Action OnCustomerDriving;
        public static Action OnExit;

        private  Dictionary<string, Action> _menuActions = new Dictionary<string, Action>()
        {
            {"1", OnCustomerPurchaseCar},
            {"2", OnCustomerMaintenanceCar},
            {"3", OnCustomerDriving},
            {"x", OnExit }
        };

        public void MainMenuActions()
        {
            _menuActions[Console.ReadLine()]?.Invoke();
            MainMenuActions();
        }
    }
}
