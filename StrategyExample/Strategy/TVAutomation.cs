using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Classes
{
    public class TVAutomation : IHomeAutomation
    {
        public void GoodMorning()
        {            
        }

        public void GoodNight()
        {
            Console.WriteLine("Turn off");
        }
    }
}
