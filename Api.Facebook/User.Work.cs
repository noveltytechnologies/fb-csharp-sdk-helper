//-----------------------------------------------------------------------
// <copyright file="User.Work.cs" company="Novelty Technologies">
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
    /// array of objects containing employer, location, position, start_date and end_date fields
    /// </summary>
    public class Work
    {
        /// <summary>
        /// employer contains string
        /// </summary>
        [DataMember(Name = "employe")]
        public Domain Employer { get; set; }
        /// <summary>
        /// location contains string
        /// </summary>
        [DataMember(Name = "location")]
		public Domain Location { get; set; }
        /// <summary>
        /// position contains string
        /// </summary>
        [DataMember(Name = "position")]
        public Domain Position { get; set; }
        /// <summary>
        /// startdate contains string
        /// </summary>
        [DataMember(Name = "start_date")]
        public string StartDate { get; set; }
        /// <summary>
        /// Enddate contains string
        /// </summary>
        [DataMember(Name = "end_date")]
        public string EndDate { get; set; }
        /// <summary>
        /// description contain string
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
