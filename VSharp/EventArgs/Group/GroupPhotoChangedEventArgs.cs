using Newtonsoft.Json.Linq;
using VSharp.Entities.Media;

namespace VSharp.EventArgs.Group
{
    public sealed class GroupPhotoChangedEventArgs : VkEventArgs
    {
        public int UserId { get; }
        public Photo Photo { get; }

        internal GroupPhotoChangedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            UserId = obj["user_id"].Value<int>();;
            Photo = ToObject<Photo>(obj["photo"]);
        }
    }
}