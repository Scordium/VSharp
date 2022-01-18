using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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