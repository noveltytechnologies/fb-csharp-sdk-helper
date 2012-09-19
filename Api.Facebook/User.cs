using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace Api.Facebook
{
	/// <summary>
	/// A user profile as represented in the Graph API.
	/// </summary>
	public class User
	{
		/// <summary>
		/// id is contain string
		/// The user's Facebook ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// name is contain string
		/// The user's full name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// first_name is contain string
		/// The user's first name
		/// </summary>
		[DataMember(Name = "first_name")]
		public string FirstName { get; set; }
		/// <summary>
		/// middle_name is contain string
		/// The user's middle name
		/// </summary>
		[DataMember(Name = "middle_name")]
		public string MiddleName { get; set; }
		/// <summary>
		/// last_name is contain string
		/// The user's last name
		/// </summary>
		[DataMember(Name = "last_name")]
		public string LastName { get; set; }
		/// <summary>
		/// gender is contain string
		/// The user's gender: female or male
		/// </summary>
		[DataMember(Name = "gender")]
		public string Gender { get; set; }
		/// <summary>
		/// string containing the ISO Language Code and ISO Country Code
		/// The user's locale
		/// </summary>
		[DataMember(Name = "locale")]
		public Locale Locale { get; set; }
		/// <summary>
		/// array of objects containing language id and name
		/// The user's languages
		/// </summary>
		[DataMember(Name = "languages")]
		public Domain[] Languages { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The URL of the profile for the user on Facebook
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// username is contain string
		/// The user's Facebook username
		/// </summary>
		[DataMember(Name = "username")]
		public string UserName { get; set; }
		/// <summary>
		/// third_party_id is contain string
		/// An anonymous, but unique identifier for the user; only returned if specifically requested via the fields URL parameter
		/// </summary>
		[DataMember(Name = "third_party_id")]
		public string ThirdPartyId { get; set; }
		/// <summary>
		/// object containing type (this is always "user"), id (the ID of the user), and optional installed field (always true if returned); The installed field is only
		/// returned if the user has installed the application, otherwise it is not part of the returned object
		/// Specifies whether the user has installed the application associated with the app access token that is 
		/// used to make the request; only returned if specifically requested via the fields URL parameter
		/// </summary>
		[DataMember(Name = "installed")]
		public bool Installed { get; set; }
		/// <summary>
		/// timezone is contain number
		/// The user's timezone offset from UTC
		/// </summary>
		[DataMember(Name = "timezone")]
		public float Timezone { get; set; }
		/// <summary>
		/// string containing an ISO-8601 datetime
		/// The last time the user's profile was updated; changes to the languages, link, timezone, 
		/// verified, interested_in, favorite_athletes, favorite_teams, and video_upload_limits are not not reflected in this value
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// verified is contain boolean
		/// The user's account verification status, either true or false (see below)
		/// </summary>
		[DataMember(Name = "verified")]
		public bool Verified { get; set; }
		/// <summary>
		/// bio is contain string
		/// The user's biography
		/// </summary>
		[DataMember(Name = "bio")]
		public string Bio { get; set; }
		/// <summary>
		/// Date string in MM/DD/YYYY format
		/// The user's birthday
		/// </summary>
		[DataMember(Name = "birthday")]
		public string Birthday { get; set; }
		/// <summary>
		/// array of fields id, source, and offset_y
		/// The user's cover photo (must be explicitly requested using fields=cover parameter)
		/// </summary>
		[DataMember(Name = "cover")]
		public Cover Cover { get; set; }
		/// <summary>
		/// object with fields currency (detailed here), id
		/// The user's currency settings (must be explicitly requested using a fields=currency URL parameter)
		/// </summary>
		[DataMember(Name = "currency")]
		public Currency Currency { get; set; }
		/// <summary>
		/// array of objects containing os which may be a value of 'iOS' or 'Android', along with an additional field hardware which may be
		/// a value of 'iPad' or 'iPhone' if present, however may not be returned if we are
		/// unable to determine the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
		/// </summary>
		[DataMember(Name = "devices")]
		public Device[] Devices { get; set; }
		/// <summary>
		/// array of objects containing year and type fields, and school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
		/// A list of the user's education history
		/// </summary>
		[DataMember(Name = "education")]
		public Education[] Education { get; set; }
		/// <summary>
		/// string containing a valid RFC822 email address
		/// The proxied or contact email address granted by the user
		/// </summary>
		[DataMember(Name = "email")]
		public string Email { get; set; }
		/// <summary>
		/// object containing name and id
		/// The user's hometown
		/// </summary>
		[DataMember(Name = "hometown")]
		public Domain HomeTown { get; set; }
		/// <summary>
		/// array containing strings
		/// The genders the user is interested in
		/// </summary>
		[DataMember(Name = "interested_in")]
		public string[] InterestedIn { get; set; }
		/// <summary>
		/// object containing name and id
		/// The user's current city
		/// </summary>
		[DataMember(Name = "location")]
		public Domain Location { get; set; }
		/// <summary>
		/// political is contain string
		/// The user's political view
		/// </summary>
		[DataMember(Name = "political")]
		public string Political { get; set; }
		/// <summary>
		/// array of objects containing id and name fields
		/// The user's favorite athletes; this field is deprecated and will be removed in the near future
		/// </summary>
		[DataMember(Name = "favorite_athletes")]
		public Domain[] FavoriteAthletes { get; set; }
		/// <summary>
		/// array of objects containing id and name fields
		/// The user's favorite teams; this field is deprecated and will be removed in the near future
		/// </summary>
		[DataMember(Name = "favorite_teams")]
		public Domain[] FavoriteTeam { get; set; }
		/// <summary>
		/// string; If the "October 2012 Breaking Changes" migration setting is enabled for your app, this field will be
		/// an object with the url and is_silhouette fields; is_silhouette is true if the user has not uploaded a profile picture
		/// The URL of the user's profile pic (only returned if you explicitly specify a 'fields=picture' param)
		/// </summary>
		[DataMember(Name = "picture")]
		public UserPicture Picture { get; set; }
		/// <summary>
		/// quotes is contain string
		/// The user's favorite quotes
		/// </summary>
		[DataMember(Name = "quotes")]
		public string Quotes { get; set; }
		///<summary>
		///this is contain string
		/// The user's relationship status: Single, In a relationship, Engaged, Married,
		/// It's complicated, In an open relationship, Widowed, Separated, Divorced, In a civil union, In a domestic partnership
		/// </summary>
		[DataMember(Name = "relationship_status")]
		public string RelationalshipStatus { get; set; }
		/// <summary>
		/// religion is contain string
		/// The user's religion
		/// </summary>
		[DataMember(Name = "religion")]
		public string Religion { get; set; }
		/// <summary>
		/// object containing secure_browsing (an object with a single field, enabled, which indicates whether Secure Browsing is enabled)
		/// Information about security settings enabled on the user's account (must be explicitly requested using a fields=security_settings URL parameter)
		/// </summary>
		[DataMember(Name = "security_settings")]
		public SecuritySetting SecuritySettings { get; set; }
		/// <summary>
		/// object containing name and id
		/// The user's significant other
		/// </summary>
		[DataMember(Name = "significant_other")]
		public Domain SignificantOther { get; set; }
		/// <summary>
		/// object containing length and size of video
		///the size of the video file and the length of the video that a user can upload; only returned if specifically requested via the
		/// </summary>
		[DataMember(Name = "video_upload_limits")]
		public VideoUploadLimit VideoUploadLimits { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The URL of the user's personal website
		/// </summary>
		[DataMember(Name = "website")]
		public string Website { get; set; }
		/// <summary>
		/// array of objects containing employer, location, position, start_date and end_date fields
		///A list of the user's work history
		/// </summary>
		[DataMember(Name = "work")]
		public UserWork[] Work { get; set; }
	}
}
