using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// array of objects containing year and type fields and
	/// school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
	/// </summary>
	[DataContract(Name = "school")]
	public class Education
	{
		/// <summary>
		/// year is contin string
		/// </summary>
		[DataMember(Name = "year")]
		public Domain Year { get; set; }
		/// <summary>
		/// type is contin string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// school object
		/// </summary>
		[DataMember(Name = "school")]
		public Domain School { get; set; }
		/// <summary>
		/// concentration contains array
		/// </summary>
		[DataMember(Name = "concentration")]
		public Domain[] Concentration { get; set; }
		/// <summary>
		/// classes contains array
		/// </summary>
		[DataMember(Name = "classes")]
		public Domain[] Classes { get; set; }
		/// <summary>
		///  width contains array
		/// </summary>
		[DataMember(Name = "width")]
		public Domain[] Width { get; set; }
	}
}
