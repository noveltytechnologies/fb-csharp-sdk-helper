using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Like class contain a count and Form(where form contain a id and name)
	/// </summary>
	[DataContract()]
	public class Likes
	{
		/// <summary>
		/// count - string
		/// </summary>
		[DataMember(Name = "count")]
		public long Count { get; set; }
		/// <summary>
		/// Array of name and id of users 
		/// </summary>
		[DataMember(Name = "data")]
		public Domain[] Items { get; set; }
	}
}
