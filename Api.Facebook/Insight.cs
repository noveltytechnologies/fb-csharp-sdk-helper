using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An object containing statistics about applications, pages, and domains.
	/// Available metrics include application and page hits, adds, removes, and likes.
	/// </summary>
	[DataContract]
	public class Insight
	{
		/// <summary>
		/// ID of the insight
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Name of the metric
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Length of the period during which the insights were collected
		/// </summary>
		[DataMember(Name = "period")]
		public string Period { get; set; }
		/// <summary>
		/// array of objects containing value and end_time
		/// Individual data points for the insight
		/// </summary>
		[DataMember(Name = "values")]
		public InsightValue[] Values { get; set; }
		/// <summary>
		/// The full description of the metric
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
	}
}
