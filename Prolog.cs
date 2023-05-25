namespace swordsandsandals
{
	public class Prolog
	{
		public Prolog()
		{
            string name;
            do
            {
                Console.WriteLine("Please enter your name!");
                name = Console.ReadLine();
                Console.Clear();
            } while (string.IsNullOrEmpty(name));

            Console.Clear(); 

            Character OurCharacter = new Character(name, 100, 1, 3, 1);
            Enemy PlaguedDog = new Enemy("Plagued Dog", 50, 10, 10);
            Enemy NightmasterVampire = new Enemy("Nightmaster Vampire", 100, 10, 10);

            Console.WriteLine("Hello {0}! \nYou have {1} health points, you can upgrade your stats to get more..\nYou recived 3 free points,\ngo ahead and spend them on your statistics.\nPress any key to continue..", OurCharacter.Name, OurCharacter.Health);
            Console.ReadLine();
            new StatsManager(OurCharacter, NightmasterVampire, PlaguedDog);
        }
	}
}

