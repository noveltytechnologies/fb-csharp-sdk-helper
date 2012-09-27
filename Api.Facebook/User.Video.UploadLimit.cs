//-----------------------------------------------------------------------
// <copyright file="User.Video.UploadLimit.cs" company="Novelty Technologies">
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
    /// object containing length and size of video
    ///the size of the video file and the length of the video that a user can upload; only returned if specifically requested via the
    /// </summary>
    [DataContract]
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
