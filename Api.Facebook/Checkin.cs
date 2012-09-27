//-----------------------------------------------------------------------
// <copyright file="Checkin.cs" company="Novelty Technologies">
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
	/// The behavior of Checkins is affected by the "Include Checkins with Statuses" migration setting.
	/// A Checkin represents a single visit to a location. The User and Page objects have checkin connections
	/// To read a Checkin object, issue an HTTP GET request to /CHECKIN_ID with one of the above permissions.
	/// Publishing a Checkin object is deprecated in favor of creating a Post with a location attached.
	/// </summary>
	[DataContract]
	public class Checkin
	{
		/// <summary>
		/// The checkin ID  
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Contains id and name fields
		/// The ID and name of the user who made the checkin
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// array of objects containing the id and name fields
		/// The users the author tagged in the checkin
		/// </summary>
		[DataMember(Name = "tags")]
		public Domain[] Tags { get; set; }
		/// <summary>
		/// object containing the Page id, name, and location;
		/// location includes the specific latitude and longitude along with information about the postal addresses, if available
		/// Information about the Facebook Page that represents the location of the checkin
		/// </summary>
		[DataMember(Name = "place")]
		public Place Place { get; set; }
		/// <summary>
		/// Information about the application that made the checkin
		/// object that contains the name and id, canvas_name, and namespace of the application
		/// </summary>
		[DataMember(Name = "application")]
		public ApplicationCheckin Application { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time datetime
		/// The time the checkin was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// array of objects containing id and name fields
		/// Users who like the checkin
		/// </summary>
		[DataMember(Name = "likes")]
		public LikeItems Likes { get; set; }
		/// <summary>
		/// The message the user added to the checkin
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Array of objects containing id, from, message and created_time fields
		/// All of the comments on this link
		/// </summary>
		[DataMember(Name = "comments")]
		public CommentItems Comments { get; set; }
		/// <summary>
		/// The type of this object; always returns checkin
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
