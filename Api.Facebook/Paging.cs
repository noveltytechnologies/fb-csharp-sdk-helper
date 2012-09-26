using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Paging
	/// </summary>
	[DataContract]
	public class Paging
	{
		/// <summary>
		/// Previous
		/// </summary>
		[DataMember(Name = "previous")]
		public string Previous { get; set; }
		/// <summary>
		/// Next
		/// </summary>
		[DataMember(Name = "next")]
		public string Next { get; set; }
	}
}
