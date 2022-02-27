using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class VideoCommentEditedEventArgs : VkEventArgs
    {
        public VideoComment Comment { get; }

        internal VideoCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<VideoComment>(payloadObject);
        }
        
        
    }
}