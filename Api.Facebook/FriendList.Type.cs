using System.Runtime.Serialization;

namespace Api.Facebook
{
	[DataContract]
    public class FriendListType
    {
        public static readonly string CLOSE_FRIENDS = "close_friends", ACQUAINTANCES = "acquaintances", RESTRICTED = "restricted", USER_CREATED = "user_created", EDUCATION = "education", WORK = "work", CURRENT_CITY = "current_city", FAMILY = "family";
        /// <summary>
        ///type - string
        /// </summary>
        [DataMember(Name = "list_type")]
        public string Type { get; set; }
    }
}
