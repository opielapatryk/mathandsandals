namespace swordsandsandals
{
	public class StatsManager
	{
        #region CONSTRUCTOR
        public StatsManager(Character MyCharacter, Enemy Boss, Enemy Cipher)
		{
            Console.Clear();
            ConsoleKeyInfo chinput;

            if (MyCharacter.StatPoints > 0)
            {
                do
                {
                    Console.WriteLine("You have {0} points left.\n1. Health: {1} | 2. Agility: {2} | 0. Exit", MyCharacter.StatPoints, MyCharacter.Health, MyCharacter.Agility);
                    chinput = Console.ReadKey();

                    switch (chinput.Key)
                    {
                        case ConsoleKey.D1:
                            MyCharacter.StatPoints -= 1;
                            MyCharacter.Health += 1;
                            break;
                        case ConsoleKey.D2:
                            MyCharacter.StatPoints -= 1;
                            MyCharacter.Agility += 1;
                            break;
                        default:
                            Console.WriteLine("Fight!");
                            break;
                    }
                    Console.Clear();
                }
                while ((MyCharacter.StatPoints > 0) && ((chinput.Key == ConsoleKey.D1) || (chinput.Key == ConsoleKey.D2)));
                Console.WriteLine("Fight!");
            }
            else
            {
                Console.WriteLine("You don't have enough points.\n1. Health: {0} | 2. Agility: {1}.\nFight!", MyCharacter.Health, MyCharacter.Agility);
            }
            
            do
            {
                Console.WriteLine("Choose type of enemy!\n1. Boss | 2. Cipher.");
                chinput = Console.ReadKey();
                Console.Clear();
            } while ((chinput.Key == ConsoleKey.D1) && (chinput.Key == ConsoleKey.D2));
            //place for save
            Arena MainArena = new Arena(chinput);
            MainArena.ChooseDuel(MyCharacter, Boss, Cipher, MainArena);
        }
#endregion
    }
}