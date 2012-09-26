using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// which is one of: code or token <seealso cref="Application"/>
	/// </summary>
	public class ResponseType
	{
		public static readonly string Code = "code", Token = "token";
		/// <summary>
		///The type of the album: profile, mobile, wall, normal or album
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
