using System;
namespace swordsandsandals
{
	public class Boss
	{
        #region FIELDS
        public string Name;
        public int Health;
        public int Damage;
        public int Agility;
        public int Bounty;
        #endregion
        #region CONSTRUCTOR
        public Boss(string name, int health, int damage, int agility, int bounty)
		{
            Name = name;
            Health = health;
            Damage = damage;
            Agility = agility;
            Bounty = bounty;
		}
        #endregion
        #region METHODS
        public void BossAttack()
        {
            //wypisz generate new math task
            //odliczanie(time)
            //odpowiedz
            //poprawna odp = dash
            //blad = odejmij hp
        }

        public void GiveBounty()
        {

        }
        #endregion

    }
}

