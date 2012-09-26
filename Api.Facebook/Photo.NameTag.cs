using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class NameTag
	{
		/// <summary>
		/// name contains string
		/// </summary>
		[DataMember(Name = "name")]
		public Domain[] Name { get; set; }
		/// <summary>
		/// type contains string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// offset contains string
		/// </summary>
		[DataMember(Name = "offset")]
		public string Offset { get; set; }
		/// <summary>
		/// length contains string
		/// </summary>
		[DataMember(Name = "length")]
		public string Length { get; set; }
	}
}
