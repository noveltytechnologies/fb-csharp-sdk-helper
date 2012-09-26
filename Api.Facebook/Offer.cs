using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An Offer represents an offer that is published by a page. 
	/// Only Page objects have offers connections.
	/// </summary>
	public class Offer
	{
		/// <summary>
		/// The offer ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the id, category, and name fields
		/// The ID, category, and name of the page that published the offer
		/// </summary>
		[DataMember(Name = "from")]
		public OfferFrom From { get; set; }
		/// <summary>
		/// The title of the offer
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time datetime
		/// The time the offer was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time datetime
		/// The expiration time of the offer (for display purposes)
		/// </summary>
		[DataMember(Name = "expiration_time")]
		public string ExpirationTime { get; set; }
		/// <summary>
		/// The terms of the offer
		/// </summary>
		[DataMember(Name = "terms")]
		public string Terms { get; set; }
	}
}
