using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
         
        public List<MatchupEntriesModel> Entries { get; set; }
        /// <summary>
        /// Represents winner team of the tournament
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round of the game
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
