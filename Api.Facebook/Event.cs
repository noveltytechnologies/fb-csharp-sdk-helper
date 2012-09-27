//-----------------------------------------------------------------------
// <copyright file="Event.cs" company="Novelty Technologies">
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
	/// Specifies information about an event, including the location, 
	/// event name, and which invitees plan to attend. The User, Page, and Application objects have an events connection.
	/// <example>
	/// Api Query : me/events?fields=description,id,end_time,owner,rsvp_status,start_time,privacy,updated_time,name,timezone,venue,location
	/// </example>
	/// </summary>
	[DataContract]
	public class Event
	{
		/// <summary>
		/// The event ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// Contains id and name fields
		/// The profile that created the event
		/// </summary>
		[DataMember(Name = "owner")]
		public Domain Owner { get; set; }
		/// <summary>
		/// The event title
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// The long-form description of the event
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
		/// The start time of the event, as you want it to be displayed on facebook
		/// </summary>
		[DataMember(Name = "start_time")]
		public string StartTime { get; set; }
		/// <summary>
		/// string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
		/// The end time of the event, if one has been set
		/// </summary>
		[DataMember(Name = "end_time")]
		public string EndTime { get; set; }
		/// <summary>
		/// The location for this event
		/// </summary>
		[DataMember(Name = "location")]
		public string Location { get; set; }
		/// <summary>
		/// object containing one or more of the following fields: id, street, city, state, zip, country, latitude, and longitude fields
		/// The location of this event
		/// </summary>
		[DataMember(Name = "venue")]
		public Venue Venue { get; set; }
		/// <summary>
		/// string containing 'OPEN', 'SECRET', 'FRIENDS', or 'CLOSED' (deprecated)
		/// The visibility of this event
		/// </summary>
		[DataMember(Name = "privacy")]
		public EventPrivacy Privacy { get; set; }
		/// <summary>
		/// string containing ISO-8601 date-time
		/// The last time the event was updated
		/// </summary>
		[DataMember(Name = "updated_time")]
		public string UpdateTime { get; set; }
		/// <summary>
		/// The URL of the event's picture (only returned if you explicitly include picture in the fields param; example: ?fields=id,name,picture)
		/// </summary>
		[DataMember(Name = "picture")]
		public string Picture { get; set; }
	}
}
