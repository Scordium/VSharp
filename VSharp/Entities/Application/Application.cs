using System;
using System.Collections.Generic;
using VSharp.Entities.Media;
using VSharp.Enums;

namespace VSharp.Entities.Application
{
    public class Application
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public string Icon278 { get; internal set; }
        public string Icon139 { get; internal set; }
        public string Icon150 { get; internal set; }
        public string Icon75 { get; internal set; }
        public string Banner560 { get; internal set; }
        public string Banner1120 { get; internal set; }
        public ApplicationType Type { get; internal set; }
        public string Section { get; internal set; }
        public string AuthorPage { get; internal set; }
        public int AuthorId { get; internal set; }
        public int AuthorGroupId { get; internal set; }
        public int MembersCount { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public int CatalogPosition { get; internal set; }
        public bool International { get; internal set; }
        public ApplicationLeaderboardType LeaderboardType { get; internal set; }
        public int GenreId { get; internal set; }
        public string GenreName { get; internal set; }
        public string StoreId { get; internal set; }
        public bool IsInCatalog { get; internal set; }
        public string? Description { get; internal set; }
        public string? ScreenName { get; internal set; }
        public string? Icon16 { get; internal set; }
        public List<Photo> Screenshots { get; internal set; }
    }
}