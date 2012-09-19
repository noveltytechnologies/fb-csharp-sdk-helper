using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    ///  os which may be a value of 'iOS' or 'Android', along with an additional field
    /// </summary>
   public class Os
    {
       /// <summary>
       ///string
       /// </summary>
        [DataMember(Name = "ios")]
        public string Ios { get; set; }
       /// <summary>
       ///string
       /// </summary>
        [DataMember(Name = "android")]
        public string Android { get; set; }
    }
}
