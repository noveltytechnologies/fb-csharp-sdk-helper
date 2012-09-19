using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// Form class is contain the Id and Name 
    /// </summary>
    public class Domain
    {
        /// <summary>
        /// Id is contain the string
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }
        /// <summary>
        /// Name is contain the string
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
