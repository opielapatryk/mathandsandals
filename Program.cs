namespace swordsandsandals
{
    public class Game
    {
        static void Main()
        {
            Character Character1 = new Character("Leopold", 6);
            Console.WriteLine("Character1 Name = {0} Age = {1}", Character1.Name, Character1.Age);

            // Declare new Character, assign Character1 to it.
            Character Character2 = Character1;

            // Change the name of Character2, and Character1 also changes.
            Character2.Name = "Molly";
            Character2.Age = 16;

            Console.WriteLine("Character2 Name = {0} Age = {1}", Character2.Name, Character2.Age);
            Console.WriteLine("Character1 Name = {0} Age = {1}", Character1.Name, Character1.Age);
        }
    }
}