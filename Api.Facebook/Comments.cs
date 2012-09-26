using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// Array of comment. <seealso cref="Comment"/>
    /// </summary>
	[DataContract()]
	public class Comments
    {
        /// <summary>
        /// count
        /// </summary>
        [DataMember(Name = "count")]
        public long Count { get; set; }
        /// <summary>
        /// Array of comment
        /// </summary>
        [DataMember(Name = "data")]
        public Comment[] Items { get; set; }
    }
}
