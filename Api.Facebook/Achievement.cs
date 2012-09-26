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
        public Likes Likes { get; set; }
        /// <summary>
        /// Array of Comment and count
        /// </summary>
        [DataMember(Name = "comments")]
        public Comments Comments { get; set; }
    }
}
