using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Classes
{
    public class WindowAutomation : IHomeAutomation
    {
        public void GoodMorning()
        {
            Console.WriteLine("Unlock");
        }

        public void GoodNight()
        {
            Console.WriteLine("Lock");
        }
    }
}
