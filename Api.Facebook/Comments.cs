using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// Comment class contain the Like,Id,Message,CreatedTime property
    /// </summary>
    public class Comments
    {
        /// <summary>
        /// count contain a string
        /// </summary>
        [DataMember(Name = "count")]
        public long Count { get; set; }
        /// <summary>
        /// object contain the array of comment
        /// </summary>
        [DataMember(Name = "data")]
        public Comment[] Items { get; set; }
    }
}
