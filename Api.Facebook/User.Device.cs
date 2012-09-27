//-----------------------------------------------------------------------
// <copyright file="User.Device.cs" company="Novelty Technologies">
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
    /// array of objects containing os which may be a value of 'iOS' or 'Android', along with an additional field
    /// hardware which may be a value of 'iPad' or 'iPhone' if present, however may not be returned if we are unable to determine
    /// the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
    /// </summary>
  public class Device
    {
      /// <summary>
        ///  os which may be a value of 'iOS' or 'Android', along with an additional field
      /// </summary>
      [DataMember(Name = "os")]
      public string Os { get; set; }
      /// <summary>
      /// hardware which may be a value of 'iPad' or 'iPhone' if present, however may not be returned if we 
      /// are unable to determine the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
      /// </summary>
      [DataMember(Name = "hardware")]
      public string Hardware { get; set; }
    }
}
