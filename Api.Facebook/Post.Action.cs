using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// array of objects containing the name and link
	/// </summary>
	[DataContract]
	public class Action
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
	}
}
