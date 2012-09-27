//-----------------------------------------------------------------------
// <copyright file="StatusMessage.cs" company="Novelty Technologies">
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
	/// A status message on a user's wall .
	/// <example>
	/// Api Query: me/statuses?fields=id,from,message,place,updated_time
	/// </example>
	/// </summary>
	[DataContract]
	public class StatusMessage
	{
		/// <summary>
		/// The status message ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing id and name fields
		/// The user who posted the message
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// The status message content
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Location associated with a Status, if any
		/// </summary>
		[DataMember(Name = "place")]
		public Place Place { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the message was published
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/*/// <summary>
		/// The object type which is set to status
		/// </summary>
		// [DataMember(Name = "type")]
		// public string Type { get; set; }*/
	}
}
