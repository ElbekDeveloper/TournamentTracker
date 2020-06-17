﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntriesModel
    {
        ///<summary>
        /// Represents one team in the matchup
        /// </summary> 
        public TeamModel TeamCompeting { get; set; }
        public double  Score { get; set; }
        public MatchupModel ParentMatchup { get; set; } = new MatchupModel();
    }
}