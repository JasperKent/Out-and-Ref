using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndRef
{
    public class Car
    {
        private Person _driver;

        public Car(Person driver)
        {
            if (!driver.Licensed)
                throw new ArgumentException("Driver not licensed");
            _driver = driver;
        }

        public ref Person Driver => ref _driver; 

        public override string ToString() => $"Car is driven by {_driver}";


    }
}
