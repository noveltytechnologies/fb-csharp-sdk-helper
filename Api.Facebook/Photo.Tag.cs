using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Tag the x and y coordinates are percentages from the left and top edges of the photo, respectively
	/// </summary>
	[DataContract]
	public class PhotoTag
	{
		/// <summary>
		/// id contain string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// name contain string
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// x contain double
		/// </summary>
		[DataMember(Name = "X")]
		public double X { get; set; }
		/// <summary>
		/// y contain double
		/// </summary>
		[DataMember(Name = "Y")]
		public double Y { get; set; }
		/// <summary>
		/// left contin string
		/// </summary>
		[DataMember(Name = "left")]
		public int Left { get; set; }
		/// <summary>
		/// top contain string
		/// </summary>
		[DataMember(Name = "top")]
		public int Top { get; set; }
		/// <summary>
		/// created_time contain string
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
	}
}
