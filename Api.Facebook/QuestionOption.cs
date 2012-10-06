//-----------------------------------------------------------------------
// <copyright file="QuestionOption.cs" company="Novelty Technologies">
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
	/// An option allowed as an answer to a Question, .
	/// </summary>
	[DataContract]
	public class QuestionOption
	{
		/// <summary>
		/// QuestionOption ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Object containing id and name fields
		/// User who asked the question
		/// </summary>
		[DataMember(Name = "from")]
		public Domain From { get; set; }
		/// <summary>
		/// Text name of the option
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Number of votes this option has received
		/// </summary>
		[DataMember(Name = "votes")]
		public int Votes { get; set; }
		/// <summary>
		/// object containing name, category, and id of a Page associated with this option
		/// Optional page associated with this 
		/// </summary>
		[DataMember(Name = "object")]
		public OptionObject Object { get; set; }
		/// <summary>
		/// Time when option was created
		/// string containing ISO-8601 datetime
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
	}
}
