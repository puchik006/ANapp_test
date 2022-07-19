using System;
using System.Collections.Generic;

namespace ANapp_test
{
    public abstract class CarOwner
    {
        public virtual List<Car> CarList()
        {
            return new List<Car>();
        }
    }
}
