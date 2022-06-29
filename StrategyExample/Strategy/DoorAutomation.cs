using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Classes
{
    public class DoorAutomation : IHomeAutomation
    {
        public void GoodMorning()
        {
            Console.WriteLine("Lock");
        }

        public void GoodNight()
        {
            Console.WriteLine("Unlock");
        }
    }
}
