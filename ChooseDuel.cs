using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace swordsandsandals
{
    public class ChooseDuel
    {

        public ChooseDuel(Arena MainArena)
        {
            if (MainArena.TypeOfDuel == "1")
            {
                Console.WriteLine("Ejże!.. wybrałeś pojedynek z bossem!");
            }
            else
            {
                Console.WriteLine("Wybrałeś pojedynek ze zwykłym szemranym rzezimieszkiem!");
            }
        }
    }
}

