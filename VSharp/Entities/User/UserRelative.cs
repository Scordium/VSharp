using VSharp.Enums;

namespace VSharp.Entities.User
{
    public class UserRelative
    {
        public int? Id { get; internal set; }
        public string? Name { get; internal set; }
        public UserRelativeRelation Type { get; internal set; }
    }
}