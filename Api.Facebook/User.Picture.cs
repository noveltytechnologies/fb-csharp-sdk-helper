using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	public class UserPicture
	{
		/// <summary>
		/// url contain the string
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; }
		/// <summary>
		/// issilhouette contain the bollean
		/// </summary>
		[DataMember(Name = "is_silhouette")]
		public bool IsSilhouette { get; set; }
	}
}
