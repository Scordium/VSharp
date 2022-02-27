using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class PhotoCommentEditedEventArgs : VkEventArgs
    {
        public PhotoComment Comment { get; }

        internal PhotoCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<PhotoComment>(payloadObject);
        }
    }
}