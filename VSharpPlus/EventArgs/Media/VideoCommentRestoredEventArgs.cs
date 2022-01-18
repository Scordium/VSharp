using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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