//-----------------------------------------------------------------------
// <copyright file="Page.Cover.cs" company="Novelty Technologies">
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
	/// <seealso cref="Page"/>
	/// </summary>
	[DataContract]
	public class PageCover
	{
		/// <summary>
		/// The Page's ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The Page's name
		/// </summary>
		[DataMember(Name = "source")]
		public string Source { get; set; }
		/// <summary>
		/// Link to the page on Facebook
		/// string containing a valid URL
		/// </summary>
		[DataMember(Name = "offset_y")]
		public int OffsetY { get; set; }
	}
}
