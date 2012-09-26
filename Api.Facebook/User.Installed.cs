using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// object containing type (this is always "user"), id (the ID of the user), and optional installed field (always true if returned); The installed field is only
    /// returned if the user has installed the application, otherwise it is not part of the returned object
    /// Specifies whether the user has installed the application associated with the app access token that is 
    /// used to make the request; only returned if specifically requested via the fields URL parameter
    /// </summary>
  
   public class Installed
    {
       /// <summary>
       /// type contains string
       /// </summary>
       [DataMember(Name = "type")]
        public string Type { get; set; }
       /// <summary>
       /// id contains string
       /// </summary>
       [DataMember(Name = "id")]
        public string Id { get; set; }
       /// <summary>
       /// text contains string
       /// </summary>
       [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
