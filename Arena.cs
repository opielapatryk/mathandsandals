namespace swordsandsandals
{
	public class Arena
	{
        #region FIELDS
        public string TypeOfDuel { get; set; }
        #endregion
        #region CONTRUCTOR
        public Arena(string typeOfDuel)
        {
            TypeOfDuel = typeOfDuel;
        }
        #endregion
        #region METHODS
        public void ChooseDuel()
        {
            if (TypeOfDuel == "1")
            {
                Console.WriteLine("Ejże!.. wybrałeś pojedynek z bossem!");
            }
            else
            {
                Console.WriteLine("Wybrałeś pojedynek ze zwykłym szemranym rzezimieszkiem!");
            }
        }
        #endregion
    }
}

