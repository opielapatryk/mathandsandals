namespace swordsandsandals
{
    public class StatsManager
    {
        #region CONSTRUCTOR

        public StatsManager(Character MyCharacter, Enemy Boss, Enemy Cipher)
        {
            Console.Clear(); // Clear the console screen
            ConsoleKeyInfo chinput; // Declare a variable to store user input (key)

            if (MyCharacter.StatPoints > 0) // Check if the character has stat points to use
            {
                do
                {
                    // Display the available stat points and current statistics of the character
                    Console.WriteLine("You have {0} points left.\n1. Health: {1} | 2. Agility: {2} | 0. Exit", MyCharacter.StatPoints, MyCharacter.Health, MyCharacter.Agility);
                    chinput = Console.ReadKey(); // Read user input (key) without displaying it on the console

                    switch (chinput.Key) // Check the user's chosen key
                    {
                        case ConsoleKey.D1: // If the user chose key '1'
                            MyCharacter.StatPoints -= 1; // Decrease the available stat points by 1
                            MyCharacter.Health += 1; // Increase the character's health by 1
                            break;
                        case ConsoleKey.D2: // If the user chose key '2'
                            MyCharacter.StatPoints -= 1; // Decrease the available stat points by 1
                            MyCharacter.Agility += 1; // Increase the character's agility by 1
                            break;
                        default:
                            Console.WriteLine("Fight!"); // If the user chose any other key, display "Fight!"
                            break;
                    }
                    Console.Clear(); // Clear the console screen
                }
                while ((MyCharacter.StatPoints > 0) && ((chinput.Key == ConsoleKey.D1) || (chinput.Key == ConsoleKey.D2))); // Continue the loop as long as there are available stat points and the user chose either key '1' or '2'

                Console.WriteLine("Fight!"); // Display "Fight!" after using all available stat points
            }
            else // If the character has no stat points
            {
                Console.WriteLine("You don't have enough points.\n1. Health: {0} | 2. Agility: {1}.\nFight!", MyCharacter.Health, MyCharacter.Agility); // Display the character's current health and agility, and prompt them to fight
            }

            do // Loop until the user chooses either '1' or '2' for the enemy type
            {
                Console.WriteLine("Choose type of enemy!\n1. Boss | 2. Cipher.");
                chinput = Console.ReadKey(); // Read user input (key) without displaying it on the console
                Console.Clear(); // Clear the console screen
            } while ((chinput.Key == ConsoleKey.D1) && (chinput.Key == ConsoleKey.D2)); // Continue the loop as long as the user has not chosen either key '1' or '2' for the enemy type

            // place for save

            Arena MainArena = new Arena(chinput); // Create a new instance of the Arena class, passing in the chosen enemy type
            MainArena.ChooseDuel(MyCharacter, Boss, Cipher, MainArena); // Call the ChooseDuel method in the Arena instance to initiate the duel
        }

        #endregion
    }
}
