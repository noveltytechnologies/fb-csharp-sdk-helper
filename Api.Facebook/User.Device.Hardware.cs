using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// /// <summary>
    /// hardware which may be a value of 'iPad' or 'iPhone' if present, however may not be returned if we 
    /// are unable to determine the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
    /// </summary>
    /// </summary>
  public  class Hardware
    {
      /// <summary>
      ///string
      /// </summary>
      [DataMember(Name = "ipad")]
        public string Ipad { get; set; }
      /// <summary>
      ///stringh
      /// </summary>
      [DataMember(Name = "iphone")]
        public string Iphone { get; set; }
    }
}
