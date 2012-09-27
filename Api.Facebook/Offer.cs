//-----------------------------------------------------------------------
// <copyright file="Offer.cs" company="Novelty Technologies">
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
	/// An Offer represents an offer that is published by a page. 
	/// Only Page objects have offers connections.
	/// </summary>
	public class Offer
	{
		/// <summary>
		/// The offer ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the id, category, and name fields
		/// The ID, category, and name of the page that published the offer
		/// </summary>
		[DataMember(Name = "from")]
		public OfferFrom From { get; set; }
		/// <summary>
		/// The title of the offer
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time datetime
		/// The time the offer was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time datetime
		/// The expiration time of the offer (for display purposes)
		/// </summary>
		[DataMember(Name = "expiration_time")]
		public string ExpirationTime { get; set; }
		/// <summary>
		/// The terms of the offer
		/// </summary>
		[DataMember(Name = "terms")]
		public string Terms { get; set; }
	}
}
