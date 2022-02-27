using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class VideoCommentRestoredEventArgs : VkEventArgs
    {
        public VideoComment Comment { get; }

        internal VideoCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<VideoComment>(payloadObject);
        }
    }
}