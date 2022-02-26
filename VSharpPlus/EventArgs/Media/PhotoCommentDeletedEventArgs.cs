using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs
{
    public sealed class PhotoCommentDeletedEventArgs : VkEventArgs
    {
        public int PhotoOwnerId { get; }
        public int Id { get; }
        public int DeleterId { get; }
        public int PhotoId { get; }

        internal PhotoCommentDeletedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            PhotoOwnerId = obj["owner_id"].Value<int>();;
            Id = obj["id"].Value<int>();;
            DeleterId = obj["user_id"].Value<int>();;
            PhotoId = obj["photo_id"].Value<int>();;
        }
    }
}