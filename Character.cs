namespace swordsandsandals
{
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
        public Character(string name, int health, int damage, int agility, int statPoints, int lvl)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Agility = agility;
            StatPoints = statPoints;
            Level = lvl;
        }
        #endregion
        #region METHODS
        public void Attack()
       {
            //wypisz generate new math task
            //odliczanie(time)
            //odpowiedz
            //poprawna odp = odejmij hp przeciwnika
            //blad = przeciwnik robi dash
            //jezeli hp przeciwnika < 0 to LvlUp()
            //jezeli twoje hp < 0 to sprobuj ponownie lub odpocznij

        }

        public void LvlUp()
        {
            //character.level += 1 
            //character.statPoints += 1 
        }
        #endregion

    }
}

