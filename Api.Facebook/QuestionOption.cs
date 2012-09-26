using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An option allowed as an answer to a Question, .
	/// </summary>
	public class QuestionOption
	{
		/// <summary>
		/// QuestionOption ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Object containing id and name fields
		/// User who asked the question
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// Text name of the option
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Number of votes this option has received
		/// </summary>
		[DataMember(Name = "votes")]
		public int Votes { get; set; }
		/// <summary>
		/// object containing name, category, and id of a Page associated with this option
		/// Optional page associated with this 
		/// </summary>
		[DataMember(Name = "object")]
		public OptionObject Object { get; set; }
		/// <summary>
		/// Time when option was created
		/// string containing ISO-8601 datetime
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
	}
}
