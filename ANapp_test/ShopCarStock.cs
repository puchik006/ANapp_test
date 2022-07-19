namespace ANapp_test
{
    public class ShopCarStock : CarStock
    {  
        public ShopCarStock()
        {
            CarList.Add(new Car("Lada", "red", 1970));
            CarList.Add(new Car("Volvo", "blue", 1986));
            CarList.Add(new Car("Porsche", "orange", 1995));
        }
    }
}
