using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// array of objects containing the name and text
	/// </summary>
	[DataContract]
	public class PostProperty
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "text")]
		public string Text { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "href")]
		public string Href { get; set; }
	}
}
