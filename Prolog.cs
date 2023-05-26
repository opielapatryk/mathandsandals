namespace swordsandsandals
{
	public class Prolog
	{
		public Prolog()
		{
            Console.WriteLine("Hello! Please enter your name!");
            string name = Console.ReadLine();
            Console.Clear();

            if (string.IsNullOrWhiteSpace(name))
            {
                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Please try again! enter your name!");
                    name = Console.ReadLine();
                    Console.Clear();
                }
            }

            Character OurCharacter = new Character(name, 100, 1, 3, 1);
            Enemy PlaguedDog = new Enemy("Plagued Dog", 50, 10, 10);
            Enemy NightmasterVampire = new Enemy("Nightmaster Vampire", 100, 10, 10);

            Console.WriteLine("Hello {0}! \nYou have {1} health points, you can upgrade your stats to get more..\nYou recived 3 free points,\ngo ahead and spend them on your statistics.\nPress any key to continue..", OurCharacter.Name, OurCharacter.Health);
            Console.ReadKey();
            new StatsManager(OurCharacter, NightmasterVampire, PlaguedDog);
        }
	}
}

