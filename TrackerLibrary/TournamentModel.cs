using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournamet 
        /// (ex. "Basketball Tournament"....)
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the amount of money 
        /// each competing team gives 
        /// to attend the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represent all of the teams 
        /// registered for the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents all prizes the administrator
        /// has decided to give for winners
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents all team pairs that 
        /// are competing in one round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
