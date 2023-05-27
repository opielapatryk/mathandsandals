namespace swordsandsandals
{
    public class Enemy
    {
        #region FIELDS

        public string Name;          // The name of the enemy
        public int Health;           // The current health points of the enemy
        public int NextNum;          // Some integer value which will be needed lated
        public int NextNumSec;       // Another integer value which will be needed lated

        #endregion

        #region CONSTRUCTOR

        public Enemy(string name, int health, int nextNum, int nextNumSec)
        {
            Name = name;             // Initialize the enemy's name
            Health = health;         // Initialize the enemy's health points
            NextNum = nextNum;       // Initialize the enemy's nextNum 
            NextNumSec = nextNumSec; // Initialize the enemy's nextNumSec 
        }

        #endregion
    }
}
