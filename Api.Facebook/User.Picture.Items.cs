using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
	public class PictureItems
	{
		[DataMember(Name = "data")]
		public Picture Item { get; set; }
	}
}
