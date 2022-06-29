using StrategyExample;
using StrategyExample.Classes;


/*
 * Cyclomatic complixty: 18 (total 18)
 *
GoodMorning("Door");
GoodMorning("Window");
GoodMorning("TV");
GoodMorning("Lights");

GoodNight("Door");
GoodNight("Window");
GoodNight("TV");
GoodNight("Lights");

void GoodNight(string thingToAutomate)
{
    switch (thingToAutomate)
    {
        case "Door":
            Console.WriteLine("Lock");
            break;

        case "Window":
            Console.WriteLine("Close");
            break;

        case "TV":
            Console.WriteLine("Turn off");
            break;

        case "Lights":
            Console.WriteLine("Turn off");
            break;
    }    
}

void GoodMorning(string thingToAutomate)
{
    switch (thingToAutomate)
    {
        case "Door":
            Console.WriteLine("Unlock");
            break;

        case "Window":
            Console.WriteLine("Open");
            break;

        case "TV":            
        case "Lights":
            break;
    }
}
*/

/*
 * Cyclomatic complexity: 6 (total 16)
 */
var automationList = new List<IHomeAutomation>();
automationList.Add(new TVAutomation());
automationList.Add(new LightsAutomation());
automationList.Add(new WindowAutomation());
automationList.Add(new DoorAutomation());

foreach (var item in automationList)
{
    item.GoodMorning();
}

foreach (var item in automationList)
{
    item.GoodNight();
}

