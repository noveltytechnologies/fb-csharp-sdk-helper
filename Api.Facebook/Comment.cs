//-----------------------------------------------------------------------
// <copyright file="Comment.cs" company="Novelty Technologies">
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
	[DataContract]
	public class Comment
	{
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object contain id and name
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// long
		/// </summary>
		[DataMember(Name = "likes")]
		public long Likes { get; set; }
		/// <summary>
		/// boolean
		/// </summary>
		[DataMember(Name = "user_likes")]
		public bool UserLikes { get; set; }
		/*/// <summary>
		/// string
		/// </summary>
		//[DataMember(Name = "type")]
		// public string Type { get; set; }*/
		/// <summary>
		/// bool
		/// </summary>
		[DataMember(Name = "can_remove")]
		public bool CanRemove { get; set; }
		/// <summary>
		/// long
		/// </summary>
		[DataMember(Name = "like_count")]
		public long LikeCount { get; set; }
	}
}
