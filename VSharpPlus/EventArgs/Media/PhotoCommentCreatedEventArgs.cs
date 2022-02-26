using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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