//-----------------------------------------------------------------------
// <copyright file="Post.cs" company="Novelty Technologies">
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
	/// <example>Api Query: me/posts</example>
	/// </summary>
	[DataContract]
	public class Post
	{
		/// <summary>
		/// The post ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the name and Facebook id of the user who posted the message
		/// Information about the user who posted the message
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// Contains in data an array of objects, each with the name and Facebook id of the user
		/// Profiles mentioned or targeted in this post
		/// </summary>
		[DataMember(Name = "to")]
		public Domain[] To { get; set; }
		/// <summary>
		/// The message
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Objects tagged in the message (Users, Pages, etc)
		/// </summary>
		[DataMember(Name = "message_tags")]
		public MessageTags MessageTags { get; set; }
		/// <summary>
		/// string containing the URL
		/// If available, a link to the picture included with this post
		/// </summary>
		[DataMember(Name = "picture")]
		public string Picture { get; set; }
		/// <summary>
		/// string containing the URL
		/// The link attached to this post
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// The name of the link
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// The caption of the link (appears beneath the link name)
		/// </summary>
		[DataMember(Name = "caption")]
		public string Caption { get; set; }
		/// <summary>
		/// A description of the link (appears beneath the link caption)
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// string containing the URL
		/// A URL to a Flash movie or video file to be embedded within the post
		/// </summary>
		[DataMember(Name = "source")]
		public string Source { get; set; }
		/// <summary>
		/// array of objects containing the name and text
		/// A list of properties for an uploaded video, for example, the length of the video
		/// </summary>
		[DataMember(Name = "properties")]
		public PostProperty[] Properties { get; set; }
		/// <summary>
		/// A link to an icon representing the type of this post
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
		/// <summary>
		/// array of objects containing the name and link
		/// A list of available actions on the post (including commenting, liking, and an optional app-specified action)
		/// </summary>
		[DataMember(Name = "actions")]
		public Action[] Actions { get; set; }
		/// <summary>
		/// object containing the value field and optional friends, networks, allow, deny and description fields.
		/// </summary>
		[DataMember(Name = "privacy")]
		public PostPrivacy Privacy { get; set; }
		/// <summary>
		///string
		/// A string indicating the type for this post (including link, photo, video)
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// Likes for this post
		/// </summary>
		[DataMember(Name = "likes")]
		public LikeItems Likes { get; set; }
		/// <summary>
		/// Location associated with a Post, if any
		/// </summary>
		[DataMember(Name = "place")]
		public Place Place { get; set; }
		/// <summary>
		/// Text of stories 
		/// </summary>
		[DataMember(Name = "story")]
		public string Story { get; set; }
		/// <summary>
		/// Objects (Users, Pages, etc) tagged in a non-intentional story
		/// </summary>
		[DataMember(Name = "story_tags")]
		public MessageTags StoryTags { get; set; }
		/// <summary>
		/// Objects (Users, Pages, etc) tagged as being with the publisher of the post ("Who are you with?" on Facebook)
		/// </summary>
		[DataMember(Name = "with_tags")]
		public Domain[] WithTags { get; set; }
		/// <summary>
		/// The Facebook object id for an uploaded photo or video
		/// </summary>
		[DataMember(Name = "object_id")]
		public long ObjectId { get; set; }
		/// <summary>
		/// object containing the name and id of the application
		/// Information about the application this post came from
		/// </summary>
		[DataMember(Name = "application")]
		public Domain Application { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the post was initially published
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreateTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time of the last comment on this post
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdateTime { get; set; }
	}
}
