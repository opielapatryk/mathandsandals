namespace swordsandsandals
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int MagicDamage { get; set; }
        public int Agility { get; set; }
        public int StatPoints { get; set; }
        public int Level { get; set; }

        public Character(string name, int health, int mana, int damage, int magicDamage, int agility, int statPoints, int lvl)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Damage = damage;
            MagicDamage = magicDamage;
            Agility = agility;
            StatPoints = statPoints;
            Level = lvl;
        }
    }
}

