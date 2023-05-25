namespace swordsandsandals
{
    public class Cipher
    {
        #region FIELDS
        public string Name;
        public int Health;
        public int NextNum;
        public int NextNumSec;
        #endregion
        #region CONSTRUCTOR
        public Cipher(string name, int health, int nextNum, int nextNumSec)
        {
            Name = name;
            Health = health;
            NextNum = nextNum;
            NextNumSec = nextNumSec;
        }
        #endregion

    }
}

