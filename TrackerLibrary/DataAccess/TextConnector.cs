using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    internal class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        // TODO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load text file
            // Convert text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add new record with new ID (max + 1)
            prizes.Add(model);

            // convert prizes to List<string>
            // save List<string> to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
