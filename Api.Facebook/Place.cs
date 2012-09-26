using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// object containing id, name, and location object
	/// </summary>
	[DataContract]
	public class Place
	{
		/// <summary>
		/// Form class contains the Id and Name 
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// location includes the specific latitude and longitude along with information about the postal addresses, if available <seealso cref="Location"/>
		/// </summary>
		[DataMember(Name = "location")]
		public Location Location { get; set; }
	}
}
