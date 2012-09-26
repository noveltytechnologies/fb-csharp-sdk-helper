using System.Runtime.Serialization;

namespace Api.Facebook
{
/// <summary>
/// <seealso cref="Photo"/>
/// </summary>
	[DataContract]
	public class NameTags
	{
		public NameTag[] NameTag { get; set; }
	}
}
