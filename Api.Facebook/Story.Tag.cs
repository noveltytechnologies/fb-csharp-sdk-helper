using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class StoryTag
	{
		/*
		///// <summary>
		/////string
		///// </summary>
		public string Object { get; set; }
		*/
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
		[DataMember(Name = "offset")]
		public string Offset { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "length")]
		public string Length { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
