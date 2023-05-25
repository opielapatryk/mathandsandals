namespace swordsandsandals
{
    [Serializable]
    public class Character
    {
        #region FIELDS
        public string Name;
        public int Health;
        public int Damage;
        public int Agility;
        public int StatPoints;
        public int Level;
        #endregion
        #region CONSTRUCTOR
        public Character(string name, int health, int agility, int statPoints, int lvl)
        {
            Name = name;
            Health = health;
            Agility = agility; //chance to dash
            StatPoints = statPoints;
            Level = lvl;
        }
        #endregion
    }
}

