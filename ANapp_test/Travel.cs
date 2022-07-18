using System;

namespace ANapp_test
{
    class Travel
    {
        private Car _currentCar;

        private string _startPoint;
        private string _finishPoint;

        public Travel(Car car, string startPoint, string finishPoint)
        {
            _currentCar = car;
            _startPoint = startPoint;
            _finishPoint = finishPoint;
        }

        public void TravelInfo()
        {
            Console.WriteLine("Car " + _currentCar.ToString() + " is travel from " +  _startPoint + " to " + _finishPoint);
        }
    }


}
