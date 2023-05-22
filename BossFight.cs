using System;
namespace swordsandsandals
{
	public class BossFight
	{
        List<Boss> BossList = new List<Boss>()
        {
            new Boss("Mechanik Andrzej", 120, 10, 1, 1),
        };
        public BossFight()
		{
			Console.WriteLine(BossList[0].Name);
			Console.WriteLine(BossList[0].Health);
			Console.ReadLine();
			//wyswietl swoje fields
			//"rozwiazuj dzialania matematyczne aby zadawac obrazenia"
			//BossAttack() 

		}
	}
}

