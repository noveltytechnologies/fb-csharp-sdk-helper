//-----------------------------------------------------------------------
// <copyright file="User.Education.cs" company="Novelty Technologies">
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
	/// array of objects containing year and type fields and
	/// school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
	/// </summary>
	[DataContract(Name = "school")]
	public class Education
	{
		/// <summary>
		/// year is contin string
		/// </summary>
		[DataMember(Name = "year")]
		public Domain Year { get; set; }
		/// <summary>
		/// type is contin string
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }
		/// <summary>
		/// school object
		/// </summary>
		[DataMember(Name = "school")]
		public Domain School { get; set; }
		/// <summary>
		/// concentration contains array
		/// </summary>
		[DataMember(Name = "concentration")]
		public Domain[] Concentration { get; set; }
		/// <summary>
		/// classes contains array
		/// </summary>
		[DataMember(Name = "classes")]
		public Domain[] Classes { get; set; }
		/// <summary>
		///  width contains array
		/// </summary>
		[DataMember(Name = "width")]
		public Domain[] Width { get; set; }
	}
}
