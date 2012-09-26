using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract(Name = "data")]
	public class InboxThreadItems
	{
		/// <summary>
		/// constructor
		/// </summary>
		public InboxThreadItems() { }
		/// <summary>
		/// Array of messages
		/// </summary>
		[DataMember(Name = "data")]
		public InboxMessage[] Items { get; set; }
		/// <summary>
		/// Paging
		/// </summary>
		[DataMember(Name = "paging")]
		public Paging paging { get; set; }
	}
}
