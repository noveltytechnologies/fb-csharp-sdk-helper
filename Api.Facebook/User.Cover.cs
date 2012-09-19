using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
   public class Cover
    {
       /// <summary>
       /// id is contain string
       /// </summary>
       [DataMember(Name = "id")]
       public string Id { get; set; }
       /// <summary>
       /// source is contain string
       /// </summary>
       [DataMember(Name = "name")]
        public string Source { get; set; }
       /// <summary>
       /// offsety is contain string
       /// </summary>
        [DataMember(Name = "offset_y")]
       public int OffsetY { get; set; }
    }
}
