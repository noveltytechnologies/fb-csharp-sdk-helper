//-----------------------------------------------------------------------
// <copyright file="Note.cs" company="Novelty Technologies">
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
	/// A Facebook Note
	/// <example>
	/// Api Query: me/notes?fields=id,from,subject,message,comments,created_time,updated_time,icon
	/// </example>
	/// </summary>
	[DataContract]
	public class Note
	{
		/// <summary>
		/// The note ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Object containing id and name fields
		/// The profile that created the note
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// The title of the note
		/// </summary>
		[DataMember(Name = "subject")]
		public string Subject { get; set; }
		/// <summary>
		/// string containing HTML text
		/// The content of the note
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// Array of Comment objects
		/// Comments made on the note
		/// </summary>
		[DataMember(Name = "comments")]
		public CommentItems Comments { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the note was initially published
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The time the note was last updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// string containing a valid URL
		/// The icon that Facebook displays with notes
		/// </summary>
		[DataMember(Name = "icon")]
		public string Icon { get; set; }
	}
}
