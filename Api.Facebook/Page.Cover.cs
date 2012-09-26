using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// <seealso cref="Page"/>
	/// </summary>
	[DataContract]
	public class PageCover
	{
		/// <summary>
		/// The Page's ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The Page's name
		/// </summary>
		[DataMember(Name = "source")]
		public string Source { get; set; }
		/// <summary>
		/// Link to the page on Facebook
		/// string containing a valid URL
		/// </summary>
		[DataMember(Name = "offset_y")]
		public int OffsetY { get; set; }
	}
}
