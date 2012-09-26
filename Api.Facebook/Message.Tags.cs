using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Most seen tags are covered listed uncomment the approporiates.
	/// </summary>
	[DataContract]
	public class MessageTags
	{
		/// <summary>
		/// Work arround property
		/// Tags or specific tag arrays are returned.
		/// </summary>
		[DataMember]
		public StoryTag[] Items {get;set;}
		/// <summary>
		/// Dynamic property
		/// </summary>
		[DataMember(Name = "3")]
		public StoryTag[] _3 { get; set; }
		
		//Further can be exdend as below
		/*
		[DataMember(Name = "36")]
		public StoryTag _36 { get; set; }
		[DataMember(Name = "54")]
		public StoryTag _54 { get; set; }
		[DataMember(Name = "80")]
		public StoryTag _80 { get; set; }
		[DataMember(Name = "87")]
		public StoryTag _87 { get; set; }
		[DataMember(Name = "114")]
		public StoryTag _114 { get; set; }
		[DataMember(Name = "124")]
		public StoryTag _124 { get; set; }
		[DataMember(Name = "125")]
		public StoryTag _125 { get; set; }
		[DataMember(Name = "171")]
		public StoryTag _171 { get; set; }
		[DataMember(Name = "225")]
		public StoryTag _225 { get; set; }
		[DataMember(Name = "1258")]
		public StoryTag _1258 { get; set; }
		*/
	}
}
