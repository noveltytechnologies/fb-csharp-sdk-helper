using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// array of objects containing employer, location, position, start_date and end_date fields
    /// </summary>
    public class UserWork
    {
        /// <summary>
        /// employer is contain string
        /// </summary>
        [DataMember(Name = "employe")]
        public Domain Employer { get; set; }
        /// <summary>
        /// location is contain string
        /// </summary>
        [DataMember(Name = "location")]
        public string Location { get; set; }
        /// <summary>
        /// position is contain string
        /// </summary>
        [DataMember(Name = "position")]
        public Domain Position { get; set; }
        /// <summary>
        /// startdate is contain string
        /// </summary>
        [DataMember(Name = "start_date")]
        public string StartDate { get; set; }
        /// <summary>
        /// Enddate is contain string
        /// </summary>
        [DataMember(Name = "end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// description contain string
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
