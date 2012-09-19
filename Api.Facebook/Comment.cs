using System.Runtime.Serialization;

namespace Api.Facebook
{
    public class Comment
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "from")]
        public Domain From { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "created_time")]
        public string CreatedTime { get; set; }
        [DataMember(Name = "likes")]
        public long Likes { get; set; }
        [DataMember(Name = "user_likes")]
        public bool UserLikes { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
