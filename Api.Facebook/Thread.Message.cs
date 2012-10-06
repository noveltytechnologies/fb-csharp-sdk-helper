//-----------------------------------------------------------------------
// <copyright file="Thread.Message.cs" company="Novelty Technologies">
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
	/// An individual message in the new Facebook messaging system. Every message has a
	/// message ID that represents an object in the Graph. To get access to read a user's messages, you should request the read_mailbox Extended Permission.
	/// </summary>
	[DataContract]
	public class ThreadMessage
	{
		/// <summary>
		///string
		/// The unique ID for this message
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// A timestamp of when this message was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// Object containing name and Facebook id (if available)
		/// The sender of this message
		/// </summary>
		[DataMember(Name = "from")]
		public ParticipantItems From { get; set; }
		/// <summary>
		/// Array of objects each containing name and Facebook id (if available)
		/// A list of the message recipients
		/// </summary>
		[DataMember(Name = "to")]
		public Domain[] To { get; set; }
		/// <summary>
		/// object containing fields whose names are the indexes to where objects are mentioned in the message field; each field in turn is an array containing an object
		/// with id, name, offset, and length fields, where length is the length, within the message field, of the object mentioned
		/// The text of the message
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
	}
}
