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
