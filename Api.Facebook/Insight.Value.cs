using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Individual data points for the insight <seealso cref="Insight"/>
	/// </summary>
	[DataContract]
	public class InsightValue
	{
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "value")]
		public string Value { get; set; }
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "end_time")]
		public string EndTime { get; set; }
	}
}
