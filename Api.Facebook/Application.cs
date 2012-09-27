//-----------------------------------------------------------------------
// <copyright file="Application.cs" company="Novelty Technologies">
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
	/// An application registered on Facebook Platform.
	/// </summary>
	[DataContract]
	public class Application
	{
		/// <summary>
		/// The application ID
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }
		/// <summary>
		/// The title of the application
		/// </summary>
		[DataMember(Name = "name")]
		public string Nmae { get; set; }
		/// <summary>
		/// The description of the application written by the 3rd party develope
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }
		/// <summary>
		/// The category of the application
		/// </summary>
		[DataMember(Name = "category")]
		public string Categoray { get; set; }
		/// <summary>
		/// The company the application belongs to
		/// </summary>
		[DataMember(Name = "company")]
		public string Company { get; set; }
		/// <summary>
		/// The URL of the application's icon
		/// </summary>
		[DataMember(Name = "icon_url")]
		public string IconUrl { get; set; }
		/// <summary>
		/// The subcategory of the application
		/// </summary>
		[DataMember(Name = "subcategory")]
		public string SubCategory { get; set; }
		/// <summary>
		/// A url to the Application's profile page
		/// </summary>
		[DataMember(Name = "link")]
		public string Link { get; set; }
		/// <summary>
		/// A url to the application's logo
		/// </summary>
		[DataMember(Name = "logo_url")]
		public string LogoUrl { get; set; }
		/// <summary>
		/// The number of daily active users the application
		/// </summary>
		[DataMember(Name = "daily_active_users")]
		public long DailyActiveUsers { get; set; }
		/// <summary>
		/// The number of weekly active users the application
		/// </summary>
		[DataMember(Name = "weekly_active_users")]
		public long WeeklyActiveUsers { get; set; }
		/// <summary>
		/// The number of monthly active users the application
		/// </summary>
		[DataMember(Name = "monthly_active_users")]
		public long MonthlyActiveUser { get; set; }
		/// <summary>
		/// Migrations settings for app profile (Editable via API)
		/// </summary>
		[DataMember(Name = "migrations")]
		public string[] Migrations { get; set; }
		/// <summary>
		/// The namespace for the app (Editable via API)
		/// </summary>
		[DataMember(Name = "namespace")]
		public string NameSpace { get; set; }
		/// <summary>
		/// Object with one or more of the following fields: type, location, age, and age_distr
		/// Demographic restrictions set for this app (Editable via API)
		/// </summary>
		[DataMember(Name = "restrictions")]
		public ApplicationRestriction Restrictions { get; set; }
		/// <summary>
		/// Domains and subdomains this app can use (Editable via API)
		/// </summary>
		[DataMember(Name = "app_domains")]
		public string[] AppDomains { get; set; }
		/// <summary>
		/// The url of a special landing page that helps users of an app begin publishing Open Graph activity (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_dialog_data_help_url")]
		public string AuthDialogDataHelpUrl { get; set; }
		/// <summary>
		/// The description of an app that appears in the Auth Dialog (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_dialog_description")]
		public string AuthDialogDescription { get; set; }
		/// <summary>
		/// One line description of an app that appears in the Auth Dialog (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_dialog_headline")]
		public string AuthDialogHeadline { get; set; }
		/// <summary>
		/// The text to explain why an app needs additional permissions that appears in the Auth Dialog (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_dialog_perms_explanation")]
		public string AuthDiologPermsExplanation { get; set; }
		/// <summary>
		///string
		/// Basic user permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_user_perms")]
		public string[] AuthReferralUserPerms { get; set; }
		/// <summary>
		/// Basic friends permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_friend_perms")]
		public string[] AuthReferralFriendPerms { get; set; }
		/// <summary>
		/// string which is one of: SELF, EVERYONE, ALL_FRIENDS or NONE
		/// The default privacy setting selected for Open Graph activities in the Auth Dialog (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_default_activity_privacy")]
		public Privacy AuthReferralDefaultActivityPrivacy { get; set; }
		/// <summary>
		/// Indicates whether Authenticated Referrals are enabled (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_enabled")]
		public bool AuthReferralEnabled { get; set; }
		/// <summary>
		/// Extended permissions that a user can choose to grant when Authenticated Referrals are enabled (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_extended_perms")]
		public string[] AuthReferralExtendedPerms { get; set; }
		/// <summary>
		/// string which is one of: code or token
		/// The format that an app receives the Auth token from the Auth Dialog in (Editable via API)
		/// </summary>
		[DataMember(Name = "auth_referral_response_type")]
		public ResponseType AuthReferralResponseType { get; set; }
		/// <summary>
		/// Indicates whether app uses fluid or settable height values for Canvas (Editable via API)
		/// </summary>
		[DataMember(Name = "canvas_fluid_height")]
		public bool CanvasFluidHeight { get; set; }
		/// <summary>
		/// Indicates whether app uses fluid or fixed width values for Canvas (Editable via API)
		/// </summary>
		[DataMember(Name = "canvas_fluid_width")]
		public bool CanvasFluidWidth { get; set; }
		/// <summary>
		/// The non-secure URL from which Canvas app content is loaded (Editable via API)
		/// </summary>
		[DataMember(Name = "canvas_url")]
		public string CanvasUrl { get; set; }
		/// <summary>
		/// Email address listed for users to contact developers (Editable via API)
		/// </summary>
		[DataMember(Name = "contact_email")]
		public string ContactEmail { get; set; }
		/// <summary>
		/// Unix timestamp that indicates when the app was created
		/// </summary>
		[DataMember(Name = "created_time")]
		public int CreatedTime { get; set; }
		/// <summary>
		/// User ID of the creator of this app
		/// </summary>
		[DataMember(Name = "creator_uid")]
		public int CreatorUid { get; set; }
		/// <summary>
		/// URL that is pinged whenever a user removes the app (Editable via API)
		/// </summary>
		[DataMember(Name = "deauth_callback_url")]
		public string DeAuthCallBackUrl { get; set; }
		/// <summary>
		/// ID of the app in the iPhone App Store
		/// </summary>
		[DataMember(Name = "iphone_app_store_id")]
		public string IPhoneAppStoreId { get; set; }
		/// <summary>
		/// Webspace created with one of our hosting partners for this app
		/// </summary>
		[DataMember(Name = "hosting_url")]
		public string HostingUrl { get; set; }
		/// <summary>
		/// URL to which Mobile users will be directed when using the app (Editable via API)
		/// </summary>
		[DataMember(Name = "mobile_web_url")]
		public string MobileWebUrl { get; set; }
		/// <summary>
		/// The title of the app when used in a Page Tab (Editable via API)
		/// </summary>
		[DataMember(Name = "page_tab_default_name")]
		public string PageTabDefaultName { get; set; }
		/// <summary>
		/// The non-secure URL from which Page Tab app content is loaded (Editable via API)
		/// </summary>
		[DataMember(Name = "page_tab_url")]
		public string PageTabUrl { get; set; }
		/// <summary>
		/// The URL that links to a Privacy Policy for the app (Editable via API)
		/// </summary>
		[DataMember(Name = "privacy_policy_url")]
		public string PrivacyPolicyUrl { get; set; }
		/// <summary>
		/// The secure URL from which Canvas app content is loaded (Editable via API)
		/// </summary>
		[DataMember(Name = "secure_canvas_url")]
		public string SecureCanvasUrl { get; set; }
		/// <summary>
		/// The secure URL from which Page Tab app content is loaded (Editable via API)
		/// </summary>
		[DataMember(Name = "secure_page_tab_url")]
		public string SecurePageTabUrl { get; set; }
		/// <summary>
		/// App requests must originate from this comma-separated list of IP addresses (Editable via API)
		/// </summary>
		[DataMember(Name = "server_ip_whitelist")]
		public string ServerIpWhiteList { get; set; }
		/// <summary>
		/// Indicates whether app usage stories show up in the Ticker or News Feed (Editable via API)
		/// </summary>
		[DataMember(Name = "social_discovery")]
		public bool SocialDiscovery { get; set; }
		/// <summary>
		/// URL to Terms of Service which is linked to in Auth Dialog (Editable via API)
		/// </summary>
		[DataMember(Name = "terms_of_service_url")]
		public string TermsOfServiceUrl { get; set; }
		/// <summary>
		/// Main contact email for this app (Editable via API)
		/// </summary>
		[DataMember(Name = "user_support_email")]
		public string UserSupportEmail { get; set; }
		/// <summary>
		/// URL of support for users of an app shown in Canvas footer (Editable via API)
		/// </summary>
		[DataMember(Name = "user_support_url")]
		public string UserSupportUrl { get; set; }
		/// <summary>
		/// URL of a website that integrates with this app (Editable via API)
		/// </summary>
		[DataMember(Name = "website_url")]
		public string WebsiteUrl { get; set; }
	}
}
