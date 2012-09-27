//-----------------------------------------------------------------------
// <copyright file="FriendList.cs" company="Novelty Technologies">
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
	/// Friend list. 
	/// <example>
	/// Api Query: me/friendlists?fields=id,name,list_type
	/// </example>
	/// </summary>
	[DataContract]
	public class FriendList
	{
		/// <summary>
		/// The friend list ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The name of the friend list
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// The type of the friends list
		/// Possible values are: close_friends, acquaintances, restricted,user_created, education, work, current_city or family
		/// </summary>
		[DataMember(Name = "list_type")]
		public FriendListType ListType { get; set; }
	}
}
