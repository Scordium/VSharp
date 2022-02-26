using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class PhotoCommentCreatedEventArgs : VkEventArgs
    {
        public PhotoComment Comment { get; }

        internal PhotoCommentCreatedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<PhotoComment>(payloadObject);
        }
    }
}