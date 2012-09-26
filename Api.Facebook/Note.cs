using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// A Facebook Note
	/// <example>
	/// Api Query: me/notes?fields=id,from,subject,message,comments,created_time,updated_time,icon
	/// </example>
	/// </summary>
	public class Note
	{
		/// <summary>
		/// The note ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Object containing id and name fields
		/// The profile that created the note
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// The title of the note
		/// </summary>
		[DataMember(Name = "subject")]
		public string Subject { get; set; }
		/// <summary>
		/// string containing HTML text
		/// The content of the note
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Array of Comment objects
		/// Comments made on the note
		/// </summary>
		[DataMember(Name = "comments")]
		public Comments Comments { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the note was initially published
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the note was last updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The icon that Facebook displays with notes
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
	}
}
