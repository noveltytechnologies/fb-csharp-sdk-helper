using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// A status message on a user's wall .
	/// <example>
	/// Api Query: me/statuses?fields=id,from,message,place,updated_time
	/// </example>
	/// </summary>
	[DataContract]
	public class StatusMessage
	{
		/// <summary>
		/// The status message ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing id and name fields
		/// The user who posted the message
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// The status message content
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Location associated with a Status, if any
		/// </summary>
		[DataMember(Name = "place")]
		public Place Place { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the message was published
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/*/// <summary>
		/// The object type which is set to status
		/// </summary>
		// [DataMember(Name = "type")]
		// public string Type { get; set; }*/
	}
}
