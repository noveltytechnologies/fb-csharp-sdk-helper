using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Optional page associated with this option
	/// </summary>
	[DataContract]
	public class OptionObject
	{
		/// <summary>
		///string
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		///string
		/// </summary>
		public string Category { get; set; }
		/// <summary>
		///string
		/// </summary>
		public string Id { get; set; }
	}
}
