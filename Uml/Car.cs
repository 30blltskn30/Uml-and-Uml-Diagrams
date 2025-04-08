using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void Start()
        {
            Console.WriteLine($"{brand} {model} is starting...");
        }
    }

}
