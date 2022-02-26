using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
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