using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract(Name = "cover")]
	public class Cover
	{
		/// <summary>
		/// id contains string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// source contains string
		/// </summary>
		[DataMember(Name = "source")]
		public string Source { get; set; }
		/// <summary>
		/// offsety contains string
		/// </summary>
		[DataMember(Name = "offset_y")]
		public int OffsetY { get; set; }
	}
}
