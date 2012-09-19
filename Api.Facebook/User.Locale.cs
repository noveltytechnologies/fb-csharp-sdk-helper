using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
  
    ///  <summary>
    /// string containing the ISO Language Code and ISO Country Code
    /// The user's locale
    /// </summary>
    
   public class Locale
    {
       /// <summary>
        ///  string containing the ISO Language Code
       /// </summary>
       [DataMember(Name = "languagecode")]
       public string LanguageCode { get; set; }
       /// <summary>
       /// string containing the ISO Country Code
       /// </summary>
       [DataMember(Name = "countrycode")]
       public string CountryCode { get; set; }
    }
}
