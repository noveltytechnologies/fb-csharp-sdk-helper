using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
    /// <summary>
    /// object containing length and size of video
    ///the size of the video file and the length of the video that a user can upload; only returned if specifically requested via the
    /// </summary>
    public class VideoUploadLimit
    {
        /// <summary>
        ///long
        /// </summary>
        [DataMember(Name = "length")]
        public long Length { get; set; }
        /// <summary>
        ///long
        /// </summary>
        [DataMember(Name = "size")]
        public long Size { get; set; }
    }
}
