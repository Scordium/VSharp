namespace VSharp.Entities.User
{
    public class UserOnlineStatus
    {
        public bool Online { get; internal set; }
        public bool? OnlineMobile { get; internal set; }
        public int? OnlineAppId { get; internal set; }
    }
}