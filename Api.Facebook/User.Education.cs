using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// array of objects containing year and type fields, and school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
    /// 
    /// </summary>
  public  class Education
    {
      /// <summary>
      /// year is contin string
      /// </summary>
      [DataMember(Name = "year")]
      public string Year { get; set; }
      /// <summary>
      /// type is contin string
      /// </summary>
      [DataMember(Name = "type")]
      public string Type { get; set; }
      /// <summary>
      /// school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
      /// </summary>
      [DataMember(Name = "school")]
	  public EducationSchool School { get; set; }
    }
}
