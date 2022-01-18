using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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