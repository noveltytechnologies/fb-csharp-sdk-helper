using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class Shares
	{
		[DataMember(Name = "count")]
		public int Count { get; set; }
	}
}
