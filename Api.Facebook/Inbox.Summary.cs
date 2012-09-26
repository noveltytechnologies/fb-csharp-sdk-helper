using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Inbox summary <seealso cref="Inbox"/>
	/// </summary>
	[DataContract(Name = "summary")]
	public class Summary
	{
		/// <summary>
		/// count of unread messages
		/// </summary>
		[DataMember(Name = "unread_count")]
		public long UnreadCount { get; set; }
		/// <summary>
		/// count of unseen messages
		/// </summary>
		[DataMember(Name = "unseen_count")]
		public long UnseenCount { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
	}
}
