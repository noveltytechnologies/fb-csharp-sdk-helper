﻿//-----------------------------------------------------------------------
// <copyright file="Group.cs" company="Novelty Technologies">
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
	/// Connected with User and Page objects. <seealso cref="User"/> <seealso cref="Page"/>
	/// <example>
	/// Api Query: me/groups?fields=id,version,icon,owner,name,description,link,privacy,updated_time
	/// </example>
	/// </summary>
	[DataContract]
	public class Group
	{
		/// <summary>
		/// The group ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// int where 0 = Old type Group, 1 = Current Group, 3 = Top-level school group
		/// A flag which indicates if the group was created prior to launch of the current groups product in October 2010
		/// </summary>
		[DataMember(Name = "version")]
		public GroupVersion Version { get; set; }
		/// <summary>
		/// The URL for the group's icon
		/// string containing a valid URL
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
		/// <summary>
		/// object containing the id and name fields
		/// The profile that created this group
		/// </summary>
		[DataMember(Name = "owner")]
		public Domain Owner { get; set; }
		/// <summary>
		/// The name of the group
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// A brief description of the group
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The URL for the group's website
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// string containing OPEN, CLOSED, or SECRET
		/// The privacy setting of the group
		/// </summary>
		[DataMember(Name = "privacy")]
		public GroupPrivacy Privacy { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The last time the group was updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
	}
}
