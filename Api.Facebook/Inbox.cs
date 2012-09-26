using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// Inbox - threads collection
	/// <example>Api Queyr: me/inbox - me/outbox</example>
	/// </summary>
	[DataContract]
	public class Inbox
	{
		[DataMember(Name = "data")]
		public InboxThread[] Thread { get; set; }
		[DataMember(Name = "summary")]
		public Summary Summary { get; set; }
	}
}
