using System.Collections.Generic;
using VSharp.Entities.Media;
using VSharp.Enums;

namespace VSharp.Entities.Group
{
    public class VkGroup
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string ScreenName { get; internal set; }
        public GroupAccessType AccessType { get; internal set; }
        public string Deactivated { get; internal set; }
        public bool IsAdmin { get; internal set; }
        public GroupAdminLevel AdminLevel { get; internal set; }
        public bool IsMember { get; internal set; }
        public bool IsAdvertiser { get; internal set; }
        public int InvitedBy { get; internal set; }
        public string GroupType { get; internal set; }
        public string Photo_50 { get; internal set; }
        public string Photo_100 { get; internal set; }
        public string Photo_200 { get; internal set; }
        
        public string? Activity { get; internal set; }
        public GroupAddresses? Addresses { get; internal set; }
        public GroupAgeLimit? AgeLimit { get; internal set; }
        public GroupBan? BanInfo { get; internal set; }
        public bool? CanCreateTopic { get; internal set; }
        public bool? CanMessage { get; internal set; }
        public bool? CanPost { get; internal set; }
        public bool? CanSeeAllPosts { get; internal set; }
        public bool? CanUploadDocument { get; internal set; }
        public bool? CanUploadVideo { get; internal set; }
        public City? City { get; internal set; }
        public List<GroupContact>? Contacts { get; internal set; }
        public GroupCounters? Counters { get; internal set; }
        public Country? Country { get; internal set; }
        public GroupCover? Cover { get; internal set; }
        public CroppedPhoto? CroppedPhoto { get; internal set; }
        public string? Description { get; internal set; }
        public int? PinnedPostId { get; internal set; }
        public bool? HasPhoto { get; internal set; }
        public bool? Favorited { get; internal set; }
        public bool? HiddenFromFeed { get; internal set; }
        public bool? MessagesBlocked { get; internal set; }
        public List<GroupLink>? Links { get; internal set; }
        public int? MainAlbumId { get; internal set; }
        public GroupMainSectionType? MainSectionType { get; internal set; }
        public GroupMarket? Market { get; internal set; }
        public GroupMemberStatus? MemberStatus { get; internal set; }
        public int? MembersCount { get; internal set; }
        public Place? Place { get; internal set; }
        public string? PublicDateLabel { get; internal set; }
        public string? Website { get; internal set; }
        public ulong? StartDate { get; internal set; }
        public ulong? FinishDate { get; internal set; }
        public string? Status { get; internal set; }
        public bool? Trending { get; internal set; }
        public bool? Verified { get; internal set; }
        public GroupWallAccessType? WallAccess { get; internal set; }
        public string? WikiPageName { get; internal set; }

    }
}