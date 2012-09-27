//-----------------------------------------------------------------------
// <copyright file="FriendList.Type.cs" company="Novelty Technologies">
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
	[DataContract]
    public class FriendListType
    {
        public static readonly string CLOSE_FRIENDS = "close_friends", ACQUAINTANCES = "acquaintances", RESTRICTED = "restricted", USER_CREATED = "user_created", EDUCATION = "education", WORK = "work", CURRENT_CITY = "current_city", FAMILY = "family";
        /// <summary>
        ///type - string
        /// </summary>
        [DataMember(Name = "list_type")]
        public string Type { get; set; }
    }
}
