namespace swordsandsandals
{
    public class Character
    {
        #region FIELDS

        public string Name;          // The name of the character
        public int Health;           // The current health points of the character
        public int Agility;          // The agility (chance to dash of the character)
        public int StatPoints;       // The number of available stat points for the character
        public int Level;            // The level of the character

        #endregion

        #region CONSTRUCTOR

        public Character(string name, int health, int agility, int statPoints, int lvl)
        {
            Name = name;             // Initialize the character's name
            Health = health;         // Initialize the character's health points
            Agility = agility;       // Initialize the character's agility
            StatPoints = statPoints; // Initialize the character's available stat points
            Level = lvl;             // Initialize the character's level
        }

        #endregion
    }
}
