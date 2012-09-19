using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
      public Os Os { get; set; }
      /// <summary>
      /// hardware which may be a value of 'iPad' or 'iPhone' if present, however may not be returned if we 
      /// are unable to determine the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
      /// </summary>
      [DataMember(Name = "hardware")]
      public Hardware Hardware { get; set; }
    }
}
