//-----------------------------------------------------------------------
// <copyright file="Photo.cs" company="Novelty Technologies">
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
	/// An individual photo as represented in the Graph API.
	/// With that granted, you can upload a photo by issuing an
	/// HTTP POST request with the photo content and an optional description to one these to Graph API connections:
	/// <example>
	/// me/photos?fields=id,from,tags,name,name_tags,icon,picture,source,height,width,images,link,place,created_time,updated_time,position
	/// </example>
	/// </summary>
	[DataContract]
	public class Photo
	{
		/// <summary>
		///string
		/// The photo ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing id and name fields
		/// The profile (user or page) that posted this photo
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// array of objects, the x and y coordinates are percentages from the left and top edges of the photo, respectively
		/// The tagged users and their positions in this photo
		/// </summary>
		[DataMember(Name = "tags")]
		public PhotoTags Tags { get; set; }
		/// <summary>
		///string
		/// The user provided caption given to this photo - do not include advertising in this field
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		///array
		/// An array containing an array of objects mentioned in the name field which contain the id, name, and type of each object as well as the offset 
		/// and length which can be used to match it up with its corresponding string in the name field
		/// </summary>
		[DataMember(Name = "name_tags")]
		public NameTags NameTags { get; set; }
		/// <summary>
		/// string representing a valid URL
		/// The icon that Facebook displays when photos are published to the Feed
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
		/// <summary>
		/// string representing a valid URL
		/// The thumbnail-sized source of the photo
		/// </summary>
		[DataMember(Name = "picture")]
		public string Picture { get; set; }
		/// <summary>
		/// string representing a valid URL
		/// The source image of the photo - currently this can have a maximum width or height of 720px, increasing to 960px on 1st March 2012
		/// </summary>
		[DataMember(Name = "source")]
		public string Source { get; set; }
		/// <summary>
		///number
		/// The height of the photo in pixels
		/// </summary>
		[DataMember(Name = "height")]
		public float Height { get; set; }
		/// <summary>
		///number
		/// The width of the photo in pixels
		/// </summary>
		[DataMember(Name = "width")]
		public int Width { get; set; }
		/// <summary>
		/// array of objects, containing height, width, and source fields
		/// The 4 different stored representations of the photo
		/// </summary>
		[DataMember(Name = "images")]
		public PhotoImage[] Images { get; set; }
		/// <summary>
		/// string representing a valid URL
		/// A link to the photo on Facebook
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// object containing id and name of Page associated with this location, and a location field 
		/// containing geographic information such as latitude, longitude, country, 
		/// and other fields (fields will vary based on geography and availability of information)
		/// Location associated with a Photo, if any
		/// </summary>
		[DataMember(Name = "place")]
		public Place Place { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the photo was initially published
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The last time the photo or its caption was updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		///number
		/// The position of this photo in the album
		/// </summary>
		[DataMember(Name = "position")]
		public int Position { get; set; }
	}
}
