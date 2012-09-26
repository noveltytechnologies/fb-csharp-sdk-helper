using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An album of photos.
	///<example>
	/// Api Query : me/albums?fields=id,from,name,description,location,link,cover_photo,privacy,count,type,created_time,updated_time,can_upload
	///</example>
	/// </summary>
	public class Album
	{
		/// <summary>
		/// ID - string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing id and name fields
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// name - string
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// string
		/// The description of the album 
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// string
		/// The location of the album
		/// </summary>
		[DataMember(Name = "location")]
		public string Location { get; set; }
		/// <summary>
		/// URL string
		/// A link to this album on Facebook
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// string
		/// The album cover photo ID
		/// </summary>
		[DataMember(Name = "cover_photo")]
		public string CoverPhoto { get; set; }
		/// <summary>
		/// Privacy contain string
		/// The privacy settings for the album
		/// </summary>
		[DataMember(Name = "privacy")]
		public string Privacy { get; set; }
		/// <summary>
		/// The number of photos in this album
		/// </summary>
		[DataMember(Name = "count")]
		public long Count { get; set; }
		/// <summary>
		/// string
		/// The type of the album: profile, mobile, wall, normal or album
		/// </summary>
		[DataMember(Name = "type")]
		public AlbumType Type { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the photo album was initially created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The last time the photo album was updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// Determines whether the UID can upload to the album. 
		/// Returns true if the user owns the album, the album is not full, and the app can add photos to the album
		/// </summary>
		[DataMember(Name = "can_upload")]
		public bool CanUpload { get; set; }
	}
}
