using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// string which is one of: SELF, EVERYONE, ALL_FRIENDS or NONE
	/// </summary>
	[DataContract]
	public class Privacy
	{
		public static readonly string SELF = "SELF", EVERYONE = "EVERYONE", ALL_FRIENDS = "ALL_FRIENDS", NONE = "NONE";
		/// <summary>
		///type contain string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
