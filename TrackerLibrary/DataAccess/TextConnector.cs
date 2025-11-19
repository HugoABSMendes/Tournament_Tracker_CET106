using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the Text File
            //Convert to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find Max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            //currentId += 1;

            //Add new record with new ID
            prizes.Add(model);

            //Convert the prizes to List<string>
            //Save List<string> to .txt
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

            //Load the Text File
            //Convert to List<PrizeModel>
            //Find Max ID
            //Add new record with new ID
            //Convert the prizes to List<string>
            //Save List<string> to .txt
        }


    }
}
