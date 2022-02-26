using VSharpPlus.Entities.WallPost;

namespace VSharpPlus.EventArgs.WallPost
{
    public sealed class WallPostCommentEditedEventArgs : VkEventArgs
    {
        public WallPostComment Comment { get; }

        internal WallPostCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<WallPostComment>(payloadObject);
        }
    }
}