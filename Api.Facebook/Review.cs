//-----------------------------------------------------------------------
// <copyright file="Review.cs" company="Novelty Technologies">
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
using System;
using System.Runtime.Serialization;

namespace Api.Facebook
{
	/// <summary>
	/// An object representing a review for an application.
	/// </summary>
	[DataContract]
	public class Review
	{
		/// <summary>
		///string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// object containing the id and name of the creating user
		/// The user that created the review
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// object containing the id and name of the application
		/// The application to which this review applies
		/// </summary>
		[DataMember(Name = "to")]
		public Domain To { get; set; }
		/// <summary>
		/// Review - Facebook Developers
		/// </summary>
		[DataMember(Name = "message")]
		public string Message { get; set; }
		/// <summary>
		/// int between 1 and 5
		/// The review rating
		/// </summary>
		[DataMember(Name = "rating")]
		public int Rating { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The timedate the review was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public String CreatedTime { get; set; }

	}
}
