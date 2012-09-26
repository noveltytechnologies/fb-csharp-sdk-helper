using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class Comment
	{
		/// <summary>
		/// id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Contains id and name
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// long
		/// </summary>
		[DataMember(Name = "likes")]
		public long Likes { get; set; }
		/// <summary>
		/// boolean
		/// </summary>
		[DataMember(Name = "user_likes")]
		public bool UserLikes { get; set; }
		/*
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		 */
		/// <summary>
		/// bool
		/// </summary>
		[DataMember(Name = "can_remove")]
		public bool CanRemove { get; set; }
		/// <summary>
		/// long
		/// </summary>
		[DataMember(Name = "like_count")]
		public long LikeCount { get; set; }
	}
}
