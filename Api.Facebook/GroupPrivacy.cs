using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Group privacy setting
	/// <seealso cref="Group"/>
	/// </summary>
	[DataContract]
	public class GroupPrivacy
	{
		public static readonly string OPEN = "OPEN", CLOSED = "CLOSED", SECRET = "SECRET";
		/// <summary>
		///type - string
		/// </summary>
		[DataMember(Name = "privacy")]
		public string Type { get; set; }
	}
}
