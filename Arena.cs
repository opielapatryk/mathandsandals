using System;
namespace swordsandsandals
{
	public class Arena
	{
        public string TypeOfDuel { get; set; }

        public Arena(string typeOfDuel)
        {
            TypeOfDuel = typeOfDuel;
        }

        public void ChooseDuel()
        {
            if (TypeOfDuel == "1")
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

