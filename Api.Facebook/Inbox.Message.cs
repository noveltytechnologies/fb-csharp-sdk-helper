using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// <seealso cref="Inbox"/>
	/// </summary>
	[DataContract]
	public class InboxMessage
	{
		/// <summary>
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
		public Domain From { get; set; }
		/// <summary>
		/// Array of objects each containing name and Facebook id (if available)
		/// A list of the message recipients
		/// </summary>
		[DataMember(Name = "to")]
		public Domain[] To { get; set; }
		/// <summary>
		/// The text of the message
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
	}
}
