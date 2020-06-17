using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name each individual of a team
        /// </summary>
        public string  FirstName { get; set; }
        /// <summary>
        /// Represents the last name each individual of a team
        /// </summary>
        public string  LastName { get; set; }
        /// <summary>
        /// Represents the email address each individual of a team
        /// This is required to send email messages later on
        /// </summary>
        public string  EmailAddress { get; set; }
        /// <summary>
        /// Represents the cellphone number each individual of a team
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
