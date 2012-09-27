//-----------------------------------------------------------------------
// <copyright file="User.Installed.cs" company="Novelty Technologies">
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
