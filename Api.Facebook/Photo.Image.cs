using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Image containing height, width, and source fields <seealso cref="Photo"/>
	/// </summary>
	[DataContract]
	public class PhotoImage
	{
		/// <summary>
		/// height contains float
		/// </summary>
		[DataMember(Name = "heisht")]
		public float Height { get; set; }
		/// <summary>
		/// width contains float
		/// </summary>
		[DataMember(Name = "width")]
		public float Width { get; set; }
		/// <summary>
		/// source - url string
		/// </summary>
		[DataMember(Name = "souce")]
		public string Source { get; set; }
	}
}
