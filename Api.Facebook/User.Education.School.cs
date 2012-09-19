using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
    /// </summary>
	public class EducationSchool
    {
       /// <summary>
       /// name is contain string
       /// </summary>
       [DataMember(Name = "name")]
       public string Name { get; set; }
       /// <summary>
       ///  id is contain string
       /// </summary>
       [DataMember(Name = "id")]
       public string Id { get; set; }
       /// <summary>
       ///  type is contain string
       /// </summary>
       [DataMember(Name = "type")]
       public string Type { get; set; }
       /// <summary>
       ///  year is contain string
       /// </summary>
       [DataMember(Name = "year")]
       public string Year { get; set; }
       /// <summary>
       ///  degree is contain string
       /// </summary>
       [DataMember(Name = "degree")]
       public string Degree { get; set; }
       /// <summary>
       ///  concentration is contain string
       /// </summary>
       [DataMember(Name = "concentration")]
       public string Concentration { get; set; }
       /// <summary>
       ///  classes is contain string
       /// </summary>
       [DataMember(Name = "classes")]
       public string Classes { get; set; }
       /// <summary>
       ///  width is contain string
       /// </summary>
     //  [DataMember(Name = "width")]
     //  public string Width { get; set; }
    }
}
