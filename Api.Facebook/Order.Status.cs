using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// string - possible values are placed, settled, disputed, refunded, cancelled
	/// </summary>
	[DataContract]
	public class Status
	{
		public static readonly string Placed = "placed", Settled = "settled", Disputed = "disputed", Refunded = "refunded", Cancelled = "cancelled";
		/// <summary>
		///type - string
		/// </summary>
		[DataMember(Name = "status")]
		public string Type { get; set; }
	}
}
