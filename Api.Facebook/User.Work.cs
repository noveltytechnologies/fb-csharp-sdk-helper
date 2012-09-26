using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// array of objects containing employer, location, position, start_date and end_date fields
    /// </summary>
    public class Work
    {
        /// <summary>
        /// employer contains string
        /// </summary>
        [DataMember(Name = "employe")]
        public Domain Employer { get; set; }
        /// <summary>
        /// location contains string
        /// </summary>
        [DataMember(Name = "location")]
		public Domain Location { get; set; }
        /// <summary>
        /// position contains string
        /// </summary>
        [DataMember(Name = "position")]
        public Domain Position { get; set; }
        /// <summary>
        /// startdate contains string
        /// </summary>
        [DataMember(Name = "start_date")]
        public string StartDate { get; set; }
        /// <summary>
        /// Enddate contains string
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
