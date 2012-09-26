using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Friend list. 
	/// <example>
	/// Api Query: me/friendlists?fields=id,name,list_type
	/// </example>
	/// </summary>
	[DataContract]
	public class FriendList
	{
		/// <summary>
		/// The friend list ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The name of the friend list
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// The type of the friends list
		/// Possible values are: close_friends, acquaintances, restricted,user_created, education, work, current_city or family
		/// </summary>
		[DataMember(Name = "list_type")]
		public FriendListType ListType { get; set; }
	}
}
