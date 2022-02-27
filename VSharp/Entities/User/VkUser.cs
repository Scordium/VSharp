using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Entities.Media;
using VSharp.Enums;

namespace VSharp.Entities.User
{
    public class VkUser
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("first_name")]
        public string FirstName { get; internal set; }
        
        [JsonProperty("last_name")]
        public string LastName { get; internal set; }
        
        [JsonProperty("deactivated")]
        public string Deactivated { get; internal set; }
        
        [JsonProperty("is_closed")]
        public bool IsClosed { get; internal set; }
        
        [JsonProperty("can_access_closed")]
        public bool CanAccess { get; internal set; }
        
        [JsonProperty("about")]
        public string? About { get; internal set; }
        
        [JsonProperty("activities")]
        public string? Activities { get; internal set; }
        
        [JsonProperty("bdate")]
        public string? BirthDate { get; internal set; }
        
        [JsonProperty("blacklisted")]
        public bool? Blacklisted { get; internal set; }
        
        [JsonProperty("blacklisted_by_me")]
        public bool? BlacklistedByCurrent { get; internal set; }
        
        [JsonProperty("books")]
        public string? Books { get; internal set; }
        
        [JsonProperty("can_post")]
        public bool? CanPost { get; internal set; }
        
        [JsonProperty("can_see_all_posts")]
        public bool? CanSeeAllPosts { get; internal set; }
        
        [JsonProperty("can_see_audio")]
        public bool? CanSeeAudio { get; internal set; }
        
        [JsonProperty("can_send_friend_request")]
        public bool? CanSendFriendRequest { get; internal set; }
        
        [JsonProperty("can_write_private_message")]
        public bool? CanWritePrivate { get; internal set; }
        
        [JsonProperty("career")]
        public List<UserCareer>? Career { get; internal set; }
        
        [JsonProperty("city")]
        public City? City { get; internal set; }
        
        [JsonProperty("common_count")]
        public int? CommonFriendsCount { get; internal set; }
        
        [JsonProperty("connections")]
        public UserConnections? Connections { get; internal set; }
        
        [JsonProperty("contacts")]
        public UserContact? Contacts { get; internal set; }
        
        [JsonProperty("counters")]
        public UserCounters? Counters { get; internal set; }
        
        [JsonProperty("country")]
        public Country? Country { get; internal set; }
        
        [JsonProperty("crop_photo")]
        public CroppedPhoto? CroppedPhoto { get; internal set; }
        
        [JsonProperty("domain")]
        public string? Domain { get; internal set; }
        
        [JsonProperty("education")]
        public UserEducation? Education { get; internal set; }
        
        //[JsonProperty("exports")]
        //public UserExports? Exports {get; internal set;}
        
        //[JsonProperty("first_name_{case}")]
        //public string? FirstName_InCase { get; internal set; }
        
        [JsonProperty("followers_count")]
        public int? FollowersCount { get; internal set; }
        
        [JsonProperty("friend_status")]
        public FriendStatus? FriendStatus { get; internal set; }
        
        [JsonProperty("games")]
        public string? Games { get; internal set; }
        
        [JsonProperty("has_mobile")]
        public bool? HasMobile { get; internal set; }
        
        [JsonProperty("has_photo")]
        public bool? HasPhoto { get; internal set; }
        
        [JsonProperty("home_town")]
        public string? Hometown { get; internal set; }
        
        [JsonProperty("interests")]
        public string? Interests { get; internal set; }
        
        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; internal set; }
        
        [JsonProperty("is_friend")]
        public bool? IsFriend { get; internal set; }
        
        [JsonProperty("is_hidden_from_feed")]
        public bool? IsHiddenFromFeed { get; internal set; }
        
        [JsonProperty("is_no_index")]
        public bool? NotIndexed { get; internal set; }
        
        //[JsonProperty("last_name_{case}")]
        //public string? LastName_InCase { get; internal set; }
        
        [JsonProperty("last_seen")]
        public LastLogin? LastOnline { get; internal set; }
        
        //[JsonProperty("lists")]
        //public string? Lists {get; internal set;} - No fucking idea what is this.
        
        [JsonProperty("maiden_name")]
        public string? MaidenName { get; internal set; }
        
        [JsonProperty("military")]
        public List<UserMilitary>? Military { get; internal set; }
        
        [JsonProperty("movies")]
        public string? Movies { get; internal set; }
        
        [JsonProperty("music")]
        public string? Music { get; internal set; }
        
        [JsonProperty("nickname")]
        public string? Nickname { get; internal set; }
        
        [JsonProperty("occupation")]
        public UserOccupation? Occupation { get; internal set; }
        
        [JsonProperty("online")]
        public bool? OnlineStatus { get; internal set; }
        
        [JsonProperty("personal")]
        public UserPersonalViews? PersonalViews { get; internal set; }
        
        [JsonProperty("photo_50")]
        public string? Photo50 { get; internal set; }
        
        [JsonProperty("photo_100")]
        public string? Photo100 { get; internal set; }
        
        [JsonProperty("photo_200")]
        public string? Photo200 { get; internal set; }
        
        [JsonProperty("photo_200_orig")]
        public string? Photo200_Original { get; internal set; }
        
        [JsonProperty("photo_400_orig")]
        public string? Photo400_Original { get; internal set; }
        
        [JsonProperty("photo_id")]
        public string? PhotoId { get; internal set; }
        
        [JsonProperty("photo_max")]
        public string? Photo_Max { get; internal set; }
        
        [JsonProperty("photo_max_orig")]
        public string? Photo_Max_Original { get; internal set; }
        
        [JsonProperty("quotes")]
        public string? Quotes { get; internal set; }
        
        [JsonProperty("relatives")]
        public List<UserRelative>? Relatives { get; internal set; }
        
        [JsonProperty("relation")]
        public UserRelation? Relation { get; internal set; }
        
        [JsonProperty("schools")]
        public List<UserSchool>? Schools { get; internal set; }
        
        [JsonProperty("screen_name")]
        public string? ScreenName { get; internal set; }
        
        [JsonProperty("sex")]
        public Sex? Sex { get; internal set; }
        
        [JsonProperty("site")]
        public string? Site { get; internal set; }
        
        [JsonProperty("status")]
        public string? Status { get; internal set; }
        
        [JsonProperty("timezone")]
        public int? TimeZone { get; internal set; }
        
        [JsonProperty("trending")]
        public bool? Trending { get; internal set; }
        
        [JsonProperty("tv")]
        public string? TVShows { get; internal set; }
        
        [JsonProperty("universities")]
        public List<UserUniversity>? Universities { get; internal set; }
        
        [JsonProperty("verified")]
        public bool? Verified { get; internal set; }
        
        [JsonProperty("wall_default")]
        public string? WallDefaultAccess { get; internal set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (id{Id})";
        }
    }
}