using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// object containing secure_browsing (an object with a single field, enabled, which indicates whether Secure Browsing is enabled)
	/// Information about security settings enabled on the user's account (must be explicitly requested using a fields=security_settings URL parameter)
	/// </summary>
	[DataContract]
	public class SecuritySetting
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "secure_browsing")]
		public SecureBrowsing SecureBrowsing { get; set; }
	}
}
