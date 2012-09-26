using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Contains the Id and Name. One of the base object. 
	/// </summary>
	[DataContract]
	public class Domain
	{
		/// <summary>
		/// Id 
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Name 
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
	}
}
