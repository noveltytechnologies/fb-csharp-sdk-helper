﻿//-----------------------------------------------------------------------
// <copyright file="Thread.cs" company="Novelty Technologies">
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
	/// A message thread in the new Facebook messaging system . The User object has a threads connections.
	/// <example>Api Query: me/threads</example>
	/// </summary>
	[DataContract]
	public class Thread
	{
		/// <summary>
		///string
		/// The unique ID for this message thread
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		///string
		/// Fragment of the thread for use in thread lists
		/// </summary>
		[DataMember(Name = "snippet")]
		public string Snippet { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// Timestamp of when the thread was last updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		///integer
		/// Number of messages in the thread
		/// </summary>
		[DataMember(Name = "message_count")]
		public int MessageCount { get; set; }
		/// <summary>
		///string
		/// Number of unread messages in the thread
		/// </summary>
		[DataMember(Name = "unread_count")]
		public int UnreadCount { get; set; }
		/// <summary>
		/// array of objects containing name
		/// Thread tags
		/// </summary>
		[DataMember(Name = "tags")]
		public Domain[] Tags { get; set; }
		/// <summary>
		/// array of objects each containing name, email, and Facebook id (if available)
		/// List of the thread participants
		/// </summary>
		[DataMember(Name = "participants")]
		public ParticipantItems Participants { get; set; }
		/// <summary>
		/// Note : 
		/// array of objects each containing name, email, and Facebook id (if available)
		/// List of former thread participants who have unsubscribed from the thread
		/// </summary>
		[DataMember(Name = "former_participants")]
		public ParticipantItems FormerParticipant { get; set; }
		/// <summary>
		/// array of objects each containing name, email, and Facebook id (if available)
		/// List of participants who have sent a message in the thread
		/// </summary>.
		[DataMember(Name = "senders")]
		public ParticipantItems Senders { get; set; }
		/// <summary>
		/// array of message objects
		/// List of the message objects contained in this thread
		/// </summary>
		[DataMember(Name = "messages")]
		public ThreadMessage[] Messages { get; set; }
	}
}
