using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// contains latitude, longitude and country
	/// </summary>
	[DataContract]
	public class Location
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "latitude")]
		public double Latitude { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "longitude")]
		public double Longitude { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "country")]
		public string Country { get; set; }
	}
}
