using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract(Name = "data")]
	public class ToItems
	{
		[DataMember(Name = "data")]
		public Domain[] Items { get; set; }
	}
}
