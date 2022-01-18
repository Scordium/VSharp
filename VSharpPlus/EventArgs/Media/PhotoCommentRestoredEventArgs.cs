using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
{
    public sealed class PhotoCommentRestoredEventArgs : VkEventArgs
    {
        public PhotoComment Comment { get;}

        internal PhotoCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<PhotoComment>(payloadObject);
        }
    }
}