using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// Like class contain a count and Form(where form contain a id and name)
    /// </summary>
    public class Likes
    {
        /// <summary>
        /// count contain a string
        /// </summary>
        [DataMember(Name = "count")]
        public long Count { get; set; }
        /// <summary>
        /// Form as well as an array containing the name and id of users 
        /// </summary>
        [DataMember(Name = "data")]
        public Domain[] Items { get; set; }
    }
}
