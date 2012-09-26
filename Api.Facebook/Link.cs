using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// A link shared on a user's wall. 
	/// The User, Application, and Page objects have a links connection.
	/// <example>
	/// Api Query: me/links?fields=id,from,link,name,comments,description,icon,picture,message,created_time
	/// </example>
	/// </summary>
	[DataContract]
	public class Link
	{
		/// <summary>
		/// The link ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the id and name field
		/// The user that created the link
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The URL that was shared
		/// </summary>
		[DataMember(Name = "link")]
		public string LinkUrl { get; set; }
		/// <summary>
		/// The name of the link
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Array of objects containing id, from, message and created_time fields
		/// All of the comments on this link
		/// </summary>
		[DataMember(Name = "comments")]
		public Comments Comments { get; set; }
		/// <summary>
		/// A description of the link (appears beneath the link caption)
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// A URL to the link icon that Facebook displays in the news feed
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// A URL to the thumbnail image used in the link post
		/// </summary>
		[DataMember(Name = "picture")]
		public string Picture { get; set; }
		/// <summary>
		///string
		/// The optional message from the user about this link
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the message was published
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/*/// <summary>
		///string
		/// The type of this object; always returns link
		/// </summary>
		//[DataMember(Name = "type")]
		// public string Type { get; set; }*/
	}
}
