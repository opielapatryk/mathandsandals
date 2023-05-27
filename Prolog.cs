namespace swordsandsandals
{
    public class Prolog
    {
        public Prolog()
        {
            // Prompt the user to enter their name
            Console.WriteLine("Hello! Please enter your name!");
            string name = Console.ReadLine(); // Read the name from user input
            Console.Clear(); // Clear the console screen

            if (string.IsNullOrWhiteSpace(name)) // Check if the name is empty or contains only white spaces
            {
                while (string.IsNullOrWhiteSpace(name))
                {
                    // Prompt the user to enter their name again until a non-empty name is provided
                    Console.WriteLine("Please try again! Enter your name!");
                    name = Console.ReadLine();
                    Console.Clear(); // Clear the console screen
                }
            }

            // Create a new character object with the provided name and initial statistics
            Character OurCharacter = new Character(name, 100, 1, 3, 1);

            // Create enemy objects with their respective names and initial statistics
            Enemy PlaguedDog = new Enemy("Plagued Dog", 50, 10, 10);
            Enemy NightmasterVampire = new Enemy("Nightmaster Vampire", 100, 10, 10);

            // Display a welcome message to the player, showing their name and initial health points
            Console.WriteLine("Hello {0}! \nYou have {1} health points, you can upgrade your stats to get more..\nYou received 3 free points,\ngo ahead and spend them on your statistics.\nPress any key to continue..", OurCharacter.Name, OurCharacter.Health);
            Console.ReadKey(); // Wait for user input (any key press) to continue

            // Create a new instance of the StatsManager, passing in the character and enemy objects
            new StatsManager(OurCharacter, NightmasterVampire, PlaguedDog);
        }
    }
}
