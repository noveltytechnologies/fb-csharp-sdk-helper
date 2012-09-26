using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Most seen tags are covered listed uncomment the class if needed.
	/// </summary>
	[DataContract]
	public class StoryTags
	{
		/// <summary>
		/// Work arround property
		/// Tags or specific tag arrays are returned.
		/// </summary>
		[DataMember]
		public StoryTag[] Items { get; set; }
		/// <summary>
		/// Dynamic property
		/// </summary>
		[DataMember(Name = "0")]
		public StoryTag[] _0 { get; set; }

		// Further can be extended as below
		/*
		[DataMember(Name = "18")]
		public StoryTag _18 { get; set; }
		[DataMember(Name = "19")]
		public StoryTag _19 { get; set; }
		[DataMember(Name = "20")]
		public StoryTag _20 { get; set; }
		[DataMember(Name = "24")]
		public StoryTag _24 { get; set; }
		[DataMember(Name = "26")]
		public StoryTag _26 { get; set; }
		[DataMember(Name = "27")]
		public StoryTag _27 { get; set; }
		[DataMember(Name = "30")]
		public StoryTag _30 { get; set; }
		*/
	}
}
