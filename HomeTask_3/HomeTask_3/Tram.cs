using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    class Tram : Vehicle
    {
        private double Price;
        public Tram()
        {
            Console.WriteLine("Оплачуємо за проїзд");
        }

        public override void Moving()
        {
            Console.WriteLine("Рейси-рейси, шпалы-шпалы, ехал поезд опоздалый");
        }

    }
}
