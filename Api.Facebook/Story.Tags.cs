//-----------------------------------------------------------------------
// <copyright file="Story.Tags.cs" company="Novelty Technologies">
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
	/// Most seen tags are covered listed uncomment the class if needed.
	/// </summary>
	[DataContract]
	public class StoryTags
	{
		/// <summary>
		/// Work arround property
		/// Tags or specific tag arrays are returned.
		/// </summary>
		[DataMember]
		public StoryTag[] Items { get; set; }
		/// <summary>
		/// Dynamic property
		/// </summary>
		[DataMember(Name = "0")]
		public StoryTag[] _0 { get; set; }

		// Further can be extended as below
		/*
		[DataMember(Name = "18")]
		public StoryTag _18 { get; set; }
		[DataMember(Name = "19")]
		public StoryTag _19 { get; set; }
		[DataMember(Name = "20")]
		public StoryTag _20 { get; set; }
		[DataMember(Name = "24")]
		public StoryTag _24 { get; set; }
		[DataMember(Name = "26")]
		public StoryTag _26 { get; set; }
		[DataMember(Name = "27")]
		public StoryTag _27 { get; set; }
		[DataMember(Name = "30")]
		public StoryTag _30 { get; set; }
		*/
	}
}
