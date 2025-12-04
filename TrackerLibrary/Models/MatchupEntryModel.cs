using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {

        public int id {  get; set; }

        public int TeamCompetingId { get; set; }
        
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }


        /// <summary>
        /// Represents the score for a particular team.
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup that a team came from.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
