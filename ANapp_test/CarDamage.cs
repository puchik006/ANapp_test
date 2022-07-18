namespace ANapp_test
{
    public class CarDamage
    {
        private string _damagePart;
        private int _damagePercent;

        public CarDamage(string damagePart, int damagePercent)
        {
            _damagePart = damagePart;
            _damagePercent = damagePercent;
        }

        public override string ToString()
        {
            return (_damagePart + " " + _damagePercent + "%");
        }
    }


}
