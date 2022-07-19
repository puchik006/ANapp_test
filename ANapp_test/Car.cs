using System;

namespace ANapp_test
{
    public class Car
    {
        public CarDamageController DamageController = new CarDamageController();

        private string _model;
        private string _color;
        private int _yearOfManufacture;

        public static Action OnCarStartMovement;

        public Car(string model, string color, int yearOfManufacture)
        {
            _model = model;
            _color = color;
            _yearOfManufacture = yearOfManufacture; 
        }

        public void Movement(IMovable CarMover)
        {
            OnCarStartMovement?.Invoke();
            CarMover.Move();
        }

        public override string ToString()
        {
            return (_model + " " + _color + " " + _yearOfManufacture);
        }

    }
}
