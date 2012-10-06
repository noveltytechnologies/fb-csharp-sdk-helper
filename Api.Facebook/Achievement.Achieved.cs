//-----------------------------------------------------------------------
// <copyright file="Achievement.Achieved.cs" company="Novelty Technologies">
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
	/// contains  id,url,type,title
	/// </summary>
	[DataContract]
	public class Achieved
	{
		/// <summary>
		/// id - string
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// url - strring
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; }
		/// <summary>
		/// type - string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// title - string
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; }
	}
}
