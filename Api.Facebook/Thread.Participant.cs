using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Object contains name, email, and Facebook id (if available)
	/// </summary>
	[DataContract]
	public class Participant
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "email")]
		public string Email { get; set; }
	}
}
