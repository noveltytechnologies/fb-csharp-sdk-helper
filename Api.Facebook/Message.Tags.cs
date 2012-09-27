//-----------------------------------------------------------------------
// <copyright file="Message.Tags.cs" company="Novelty Technologies">
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
	/// Most seen tags are covered listed uncomment the approporiates.
	/// </summary>
	[DataContract]
	public class MessageTags
	{
		/// <summary>
		/// Work arround property
		/// Tags or specific tag arrays are returned.
		/// </summary>
		[DataMember]
		public StoryTag[] Items {get;set;}
		/// <summary>
		/// Dynamic property
		/// </summary>
		[DataMember(Name = "3")]
		public StoryTag[] _3 { get; set; }
		
		//Further can be exdend as below
		/*
		[DataMember(Name = "36")]
		public StoryTag _36 { get; set; }
		[DataMember(Name = "54")]
		public StoryTag _54 { get; set; }
		[DataMember(Name = "80")]
		public StoryTag _80 { get; set; }
		[DataMember(Name = "87")]
		public StoryTag _87 { get; set; }
		[DataMember(Name = "114")]
		public StoryTag _114 { get; set; }
		[DataMember(Name = "124")]
		public StoryTag _124 { get; set; }
		[DataMember(Name = "125")]
		public StoryTag _125 { get; set; }
		[DataMember(Name = "171")]
		public StoryTag _171 { get; set; }
		[DataMember(Name = "225")]
		public StoryTag _225 { get; set; }
		[DataMember(Name = "1258")]
		public StoryTag _1258 { get; set; }
		*/
	}
}
