using System;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An object representing a review for an application.
	/// </summary>
	[DataContract]
	public class Review
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the id and name of the creating user
		/// The user that created the review
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// object containing the id and name of the application
		/// The application to which this review applies
		/// </summary>
		[DataMember(Name = "to")]
		public Domain To { get; set; }
		/// <summary>
		/// Review - Facebook Developers
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// int between 1 and 5
		/// The review rating
		/// </summary>
		[DataMember(Name = "rating")]
		public int Rating { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The timedate the review was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public String CreatedTime { get; set; }

	}
}
