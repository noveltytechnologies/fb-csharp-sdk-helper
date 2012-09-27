//-----------------------------------------------------------------------
// <copyright file="Post.Privacy.cs" company="Novelty Technologies">
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
    /// object containing the value field and optional friends, networks, allow, deny and description fields.
    /// </summary>
    [DataContract]
	public class PostPrivacy
    {
        /// <summary>
        /// The description field may contain a comma-separated lists of valid country, city and language if a Page's post targeting by location/language is specified.
        /// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// The value field may specify one of the following strings: EVERYONE, ALL_FRIENDS, NETWORKS_FRIENDS, FRIENDS_OF_FRIENDS, CUSTOM .
		/// </summary>
		[DataMember(Name = "value")]
		public string Value { get; set; }
		/// <summary>
		/// The friends field must be specified if value is set to CUSTOM and contain one of the following strings:
		/// EVERYONE, NETWORKS_FRIENDS (when the object can be seen by networks and friends),
		/// FRIENDS_OF_FRIENDS, ALL_FRIENDS, SOME_FRIENDS, SELF, or NO_FRIENDS (when the object can be seen by a network only).
		/// </summary>
		[DataMember(Name = "friends")]
		public string Friends { get; set; }
		/// <summary>
		/// The networks field may contain a comma-separated list of network IDs that can see the object, or 1 for all of a user's network.
		/// </summary>
		[DataMember(Name = "networks")]
		public string Networks { get; set; }
		/// <summary>
		/// The allow field must be specified when the friends value is set to
		/// SOME_FRIENDS and must specify a comma-separated list of user IDs and friend list IDs that 'can' see the post.
		/// </summary>
		[DataMember(Name = "allow")]
		public string Allow { get; set; }
		/// <summary>
		/// The deny field may be specified if the friends field is set to SOME_FRIENDS and must specify a comma-separated list of
		/// user IDs and friend list IDs that 'cannot' see the post.
		/// </summary>
		[DataMember(Name = "deny")]
		public string Deny { get; set; }
    }
}
