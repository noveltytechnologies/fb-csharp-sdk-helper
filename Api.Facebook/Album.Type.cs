using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Associated type for album.<seealso cref="Album"/>
	/// </summary>
	[DataContract]
	public class AlbumType
	{
		public static readonly string Profile = "profile", Mobile = "mobile", Wall = "wall", Normal = "normal", Album = "album";
		/// <summary>
		///The type of the album: profile, mobile, wall, normal or album
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
