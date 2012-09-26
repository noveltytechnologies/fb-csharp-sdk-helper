using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// Contains name and id, canvas_name, and namespace of the application
    /// </summary>
    public class CheckinApplication
    {
        /// <summary>
        /// Contains Id and Name 
        /// </summary>
        [DataMember(Name = "data")]
        public Domain Item { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "canvas_name")]
        public string CanvasName { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "namespace")]
        public string NameSpace { get; set; }
        
    }
}
