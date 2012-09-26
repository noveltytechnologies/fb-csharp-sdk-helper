using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
