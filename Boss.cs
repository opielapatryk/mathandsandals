﻿using System;
namespace swordsandsandals
{
	public class Boss
	{
        #region FIELDS
        public string Name;
        public int Health;
        public int Agility;
        public int NextNum;
        public int NextNumSec;
        #endregion
        #region CONSTRUCTOR
        public Boss(string name, int health, int agility, int nextNum, int nextNumSec)
		{
            Name = name;
            Health = health;
            Agility = agility;
            NextNum = nextNum;
            NextNumSec = nextNumSec;

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

