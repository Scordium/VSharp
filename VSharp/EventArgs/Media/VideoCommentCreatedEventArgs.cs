using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class VideoCommentCreatedEventArgs : VkEventArgs
    {
        public VideoComment Comment { get; }

        internal VideoCommentCreatedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<VideoComment>(payloadObject);
        }
    }
}