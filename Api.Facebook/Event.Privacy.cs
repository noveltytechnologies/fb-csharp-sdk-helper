using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class EventPrivacy
	{
		public static readonly string OPEN = "OPEN", SECRET = "SECRET", FRIENDS = "FRIENDS", CLOSED = "CLOSED";
		/// <summary>
		///type - string
		/// </summary>
		[DataMember(Name = "privacy")]
		public string Privacy { get; set; }
	}
}
