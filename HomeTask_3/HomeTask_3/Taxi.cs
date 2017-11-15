using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    class Taxi : Vehicle
    {
        
        protected override int PriceCreater()
        {
            Price = 200;
            return Price;
        }
        public override void Moving()
        {
            Console.WriteLine("Воуоуоу-нананана, зеленоглазое такси, воуоуоу-нананана, притормози, притормози");
        }

    }
}
