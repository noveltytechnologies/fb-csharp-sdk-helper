using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// One or more of the following fields: type, location, age, and age_distr
	/// </summary>
	public class ApplicationRestriction
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "location")]
		public string Location { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "age")]
		public string Age { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "age_distr")]
		public string AgeDistr { get; set; }
	}
}
