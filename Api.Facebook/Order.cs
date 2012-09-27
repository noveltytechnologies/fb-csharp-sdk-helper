//-----------------------------------------------------------------------
// <copyright file="Order.cs" company="Novelty Technologies">
// Copyright (c) 2011, Novelty Technologies.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Novelty Technologies (info@noveltytechnologies.com)</author>
// <website>https://github.com/noveltytechnologies/fb-csharp-sdk-helper</website>
//-----------------------------------------------------------------------
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// You can use the order object to interact with orders created by the application using Facebook credits to view and update orders as needed.
	/// </summary>
	[DataContract]
	public class Order
	{
		/// <summary>
		/// name and id of the user
		/// id for the order
		/// </summary>
		[DataMember(Name = "id")]
		public Domain Id { get; set; }
		/// <summary>
		/// user associated with the order
		/// </summary>
		[DataMember(Name = "from")]
		public string From { get; set; }
		/// <summary>
		/// amount for the order
		/// </summary>
		[DataMember(Name = "amount")]
		public int Amount { get; set; }
		/// <summary>
		/// string - possible values are placed, settled, disputed, refunded, cancelled
		/// status the order
		/// </summary>
		[DataMember(Name = "status")]
		public Status Status { get; set; }
		/// <summary>
		/// name and id of the application
		/// application associated with the order
		/// </summary>
		[DataMember(Name = "application")]
		public Domain Application { get; set; }
		/// <summary>
		/// String containing ISO 3166 alpha 2 code representing the country
		/// country associated with the order
		/// </summary>
		[DataMember(Name = "country")]
		public string Country { get; set; }
		/// <summary>
		/// refund reason code if the order was refunded by Facebook
		/// </summary>
		[DataMember(Name = "refund_reason_code")]
		public string RefundReasonCode { get; set; }
		/// <summary>
		/// string containing an ISO-8601 datetime
		/// time when the order was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// time when the order was last updated
		/// string containing an ISO-8601 datetime
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
	}
}
