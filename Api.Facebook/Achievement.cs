//-----------------------------------------------------------------------
// <copyright file="Achievement.cs" company="Novelty Technologies">
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
    /// represents the achievement achieved by a user for a particular app.
    /// An app can always access achievement(instance) associated with their app with an app or user access_token associated with their app. 
    /// Require user_games_activity, friends_games_activity permissions.
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// string
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }
        /// <summary>
        ///  object containing the id and name of user
        /// </summary>
        [DataMember(Name = "from")]
        public Domain From { get; set; }
        /// <summary>
        /// string containing an ISO-8601 datetime
        /// </summary>
        [DataMember(Name = "created_time")]
        public string CreatedTime { get; set; }
        /// <summary>
        /// object containing id and name of application
        /// The application in which the user achieved the achievement
        /// </summary>
        [DataMember(Name = "application")]
        public Domain Application { get; set; }
        /// <summary>
        /// object containing the id, url, type, and title of the achievement
        /// The achievement object that the user achieved
        /// </summary>
        [DataMember(Name = "achievement")]
        public Achieved Achieved { get; set; }
        /// <summary>
        /// Array of name and id of users with no counts.
        /// </summary>
        [DataMember(Name = "likes")]
		public LikeItems Likes { get; set; }
        /// <summary>
        /// Array of Comment and count
        /// </summary>
        [DataMember(Name = "comments")]
		public CommentItems Comments { get; set; }
    }
}
