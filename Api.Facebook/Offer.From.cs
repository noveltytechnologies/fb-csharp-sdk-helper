using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// <seealso cref="Offer"/>
	/// </summary>
	[DataContract]
	public class OfferFrom
	{
		[DataMember(Name = "id")]
		public string Id { get; set; }
		[DataMember(Name = "name")]
		public string Name { get; set; }
		[DataMember(Name = "category")]
		public string Category { get; set; }
	}
}
