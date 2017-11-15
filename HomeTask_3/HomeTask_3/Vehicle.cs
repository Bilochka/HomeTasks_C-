using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        protected int Price { get; set; } 
        private string City = "Vinnitsa";

        private void Driver()
        {
            Console.WriteLine("Припустимо тут ми рандомно обираємо водія");
        }
        protected virtual int PriceCreater()
        {
            Price = 3;
            return Price;
        }

        public abstract void Moving();

        public void Clone(Vehicle source, Vehicle result)
        {
            result.Name = source.Name;
        }
    }
}
