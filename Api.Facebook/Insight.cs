//-----------------------------------------------------------------------
// <copyright file="Insight.cs" company="Novelty Technologies">
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
	/// An object containing statistics about applications, pages, and domains.
	/// Available metrics include application and page hits, adds, removes, and likes.
	/// </summary>
	[DataContract]
	public class Insight
	{
		/// <summary>
		/// ID of the insight
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Name of the metric
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Length of the period during which the insights were collected
		/// </summary>
		[DataMember(Name = "period")]
		public string Period { get; set; }
		/// <summary>
		/// array of objects containing value and end_time
		/// Individual data points for the insight
		/// </summary>
		[DataMember(Name = "values")]
		public InsightValue[] Values { get; set; }
		/// <summary>
		/// The full description of the metric
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
	}
}
