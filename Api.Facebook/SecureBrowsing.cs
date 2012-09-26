using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class SecureBrowsing
	{
		/// <summary>
		/// enabled contain string
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }
	}
}
