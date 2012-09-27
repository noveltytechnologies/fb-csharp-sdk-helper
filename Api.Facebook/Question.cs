//-----------------------------------------------------------------------
// <copyright file="Question.cs" company="Novelty Technologies">
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
	/// A question asked by a user, .
	/// <example>Api Query: me/questions</example>
	/// </summary>
	[DataContract]
	public class Question
	{
		/// <summary>
		/// Question ID
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
		/// Text of the question
		/// </summary>
		[DataMember(Name = "question")]
		public string Text { get; set; }
		/// <summary>
		/// string containing ISO-8601 datetime
		/// Time when question was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public string CreatedTime { get; set; }
		/// <summary>
		/// string containing ISO-8601 datetime
		/// Time when question was last updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdatedTime { get; set; }
		/// <summary>
		/// Object containing data[] array of options, as described in the options connection below
		/// The list of options available as answers to the question
		/// </summary>
		[DataMember(Name = "options")]
		public string[] Option { get; set; }
	}
}
