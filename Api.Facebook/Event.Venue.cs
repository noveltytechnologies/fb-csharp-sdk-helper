using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// object contains one or more of the following fields: id, street, city, state, zip, country, latitude, and longitude fields
    /// </summary>
    public class Venue
    {
        /// <summary>
        /// string
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set;}
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "street")]
        public string Street { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "state")]
        public string State { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "country")]
        public string Country { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "latitude")]
        public long Latitude { get; set; }
        /// <summary>
        ///string
        /// </summary>
        [DataMember(Name = "longitude")]
        public long Longitude { get; set; }
    }
}
