//-----------------------------------------------------------------------
// <copyright file="Inbox.Thread.cs" company="Novelty Technologies">
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
	/// A message thread in the new inbox.
	/// <example>Api Queyr: me/inbox me/outbox</example>
	/// </summary>
	[DataContract]
	public class InboxThread
	{
		/// <summary>
		/// The unique ID for this message thread
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Fragment of the thread for use in thread lists
		/// </summary>
		[DataMember(Name = "to")]
		public ParticipantItems To { get; set; }
		/// <summary>
		/// object with id, name 
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// Timestamp of when the thread was last updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// Number of messages in the thread
		/// </summary>
		[DataMember(Name = "unseen")]
		public long Unseen { get; set; }
		/// <summary>
		/// Number of unread messages in the thread
		/// </summary>
		[DataMember(Name = "unread")]
		public long Unread { get; set; }
		/// <summary>
		/// array of messages with id, name
		/// </summary>
		[DataMember(Name = "comments")]
		public InboxThreadItems Comments { get; set; }
		/// <summary>
		/// subject line
		/// </summary>
		[DataMember(Name = "subject")]
		public string Subject { get; set; }
		/// <summary>
		/// string
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
	}
}
