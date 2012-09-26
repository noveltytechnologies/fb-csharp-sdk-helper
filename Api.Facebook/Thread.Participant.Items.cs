using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract(Name = "data")]
	public class ParticipantItems
	{
		[DataMember(Name = "data")]
		public Participant[] Items {get;set;}
	}
}
