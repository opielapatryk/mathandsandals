using System;
namespace swordsandsandals
{

	public class Prolog
	{
		public Prolog()
		{
            Console.WriteLine("Witaj przywoływaczu! Podaj swoje imię!");
            string name = Console.ReadLine();
            Console.Clear();

            Character OurCharacter = new Character(name, 100, 1, 3, 1);
            Boss Andrzej = new Boss("Mechanik Andrzej", 100, 1, 10, 10);

            Console.WriteLine("Witaj {0}! Na początek masz {1} puntków życia, lecz możesz zdobyć go więcej przez ulepszanie statystyk. Otrzymałeś 10 punktów, śmiało rozdaj je w wybrane przez siebie statystyki..", OurCharacter.Name, OurCharacter.Health);
            
            new StatsManager(OurCharacter, Andrzej);
            

           
            
        }
	}
}

