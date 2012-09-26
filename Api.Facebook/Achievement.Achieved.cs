using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// contains  id,url,type,title
	/// </summary>
	public class Achieved
	{
		/// <summary>
		/// id - string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// url - strring
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; }
		/// <summary>
		/// type - string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// title - string
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; }
	}
}
