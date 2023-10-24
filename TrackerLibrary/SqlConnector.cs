namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - make the CreatePrize method actually save to the database
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information</param>
        /// <returns>the prize information including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }

    }
}
