using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represent the place of the winner
        /// </summary>
        public string PlaceNumber { get; set; }
        /// <summary>
        /// Represents name of winner 
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of money administrator
        /// decides to give to the winner
        /// </summary>
        public decimal PrizeAmout { get; set; }
        /// <summary>
        /// Represents the alternative to the PrizeAmount variable
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
