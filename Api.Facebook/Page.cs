//-----------------------------------------------------------------------
// <copyright file="Page.cs" company="Novelty Technologies">
// Copyright (c) 2011, Novelty Technologies.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Novelty Technologies (info@noveltytechnologies.com)</author>
// <website>https://github.com/noveltytechnologies/fb-csharp-sdk-helper</website>
//-----------------------------------------------------------------------
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	///<example>Api Query : me/accounts => list pages = > single id</example>
	/// </summary>
	[DataContract]
	public class Page
	{
		/// <summary>
		/// The Page's ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The Page's name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Link to the page on Facebook
		/// string containing a valid URL
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// The Page's category
		/// </summary>
		[DataMember(Name = "category")]
		public string Category { get; set; }
		/// <summary>
		/// Indicates whether the page is published and visible to non-admins
		/// </summary>
		[DataMember(Name = "is_published")]
		public bool IsPublished { get; set; }
		/// <summary>
		/// Indicates whether the current session user can post on this Page
		/// </summary>
		[DataMember(Name = "can_post")]
		public bool CanPost { get; set; }
		/// <summary>
		/// The number of users who like the Page
		/// </summary>
		[DataMember(Name = "likes")]
		public string Likes { get; set; }
		/// <summary>
		///dictionary
		/// The Page's street address, latitude, and longitude (when available)
		/// </summary>
		[DataMember(Name = "location")]
		public string Location { get; set; }
		/// <summary>
		/// The phone number (not always normalized for country code) for the Page
		/// </summary>
		[DataMember(Name = "phone")]
		public string Phone { get; set; }
		/// <summary>
		/// The total number of users who have checked in to the Page
		/// </summary>
		[DataMember(Name = "checkins")]
		public long Checkins { get; set; }
		/// <summary>
		/// Link to the Page's profile picture
		/// </summary>
		[DataMember(Name = "picture")]
		public string Picture { get; set; }
		/// <summary>
		/// Object including cover_id (the ID of the photo), 
		/// source (the URL for the cover photo) and offset_y (the percentage offset from top [0-100])
		/// </summary>
		[DataMember(Name = "cover")]
		public PageCover Cover { get; set; }
		/// <summary>
		/// Link to the external website for the page
		/// </summary>
		[DataMember(Name = "website")]
		public string Website { get; set; }
		/// <summary>
		/// The number of people that are talking about this page (last seven days)
		/// </summary>
		[DataMember(Name = "talking_about_count")]
		public long TalkingAboutCount { get; set; }
		/// <summary>
		/// A Page admin access_token for this page.
		/// </summary>
		[DataMember(Name = "access_token")]
		public string AccessToken { get; set; }
	}
}
