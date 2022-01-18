using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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