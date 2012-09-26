using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// The tagged users and their positions in this photo
	/// array of objects, the x and y coordinates are percentages from the left and top edges of the photo, respectively
	/// </summary>
	[DataContract]
	public class PhotoTags
	{
		/// <summary>
		/// array of objects
		/// </summary>
		public PhotoTag[] Items { get; set; }
	}
}
