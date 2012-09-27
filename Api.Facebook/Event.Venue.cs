//-----------------------------------------------------------------------
// <copyright file="Event.Venue.cs" company="Novelty Technologies">
// Copyright (c) 2011, Novelty Technologies.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Novelty Technologies (info@noveltytechnologies.com)</author>
// <website>https://github.com/noveltytechnologies/fb-csharp-sdk-helper</website>
//-----------------------------------------------------------------------
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
