using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// <example>
    /// me/videos?fields=id,from,tags,name,description,picture,embed_html,icon,source,created_time,updated_time,comments
    /// </example>
    /// An individual Video in the Graph API.
    /// </summary>
    public class Video
    {
        /// <summary>
        ///string
        /// The video ID
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }
        /// <summary>
        /// object containing id and name fields
        /// The profile (user or page) that created the video
        /// </summary>
        [DataMember(Name = "from")]
        public Domain From { get; set; }
        /// <summary>
        /// array of objects containing id and name fields
        /// The users who are tagged in this video
        /// </summary>
        [DataMember(Name = "tags")]
        public Domain[] Tags { get; set; }
        /// <summary>
        ///string
        /// The video title or caption
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        ///string
        /// The description of the video
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        ///string
        /// The URL for the thumbnail picture for the video
        /// </summary>
        [DataMember(Name = "picture")]
        public string Picture { get; set; }
        /// <summary>
        /// string containing a valid URL
        /// The html element that may be embedded in an Web page to play the video
        /// </summary>
        [DataMember(Name = "embed_html")]
        public string EmbedHtml { get; set; }
        /// <summary>
        /// string containing a valid URL
        /// The icon that Facebook displays when video are published to the Feed
        /// </summary>
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        /// <summary>
        /// string containing a valid URL
        /// A URL to the raw, playable video file
        /// </summary>
        [DataMember(Name = "source")]
        public string Source { get; set; }
        /// <summary>
        /// string containing ISO-8601 date-time
        /// The time the video was initially published
        /// </summary>
        [DataMember(Name = "created_time")]
        public string CreatedTime { get; set; }
        /// <summary>
        /// string containing ISO-8601 date-time
        /// The last time the video or its caption were updated
        /// </summary>
        [DataMember(Name = "updated_time")]
        public string UpdatedTime { get; set; }
        /// <summary>
        /// array of objects containing id, from, message, created_time, and likes fields
        /// All of the comments on this video
        /// </summary>
        [DataMember(Name = "comments")]
        public Comments Comments { get; set; }

    }
}
