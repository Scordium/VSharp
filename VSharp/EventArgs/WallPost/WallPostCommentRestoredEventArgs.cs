using VSharp.Entities.WallPost;

namespace VSharp.EventArgs.WallPost
{
    public sealed class WallPostCommentRestoredEventArgs : VkEventArgs
    { 
        public WallPostComment Comment { get; }

        internal WallPostCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<WallPostComment>(payloadObject);
        }
    }

}