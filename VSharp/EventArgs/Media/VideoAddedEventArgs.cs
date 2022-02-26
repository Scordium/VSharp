using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class VideoAddedEventArgs : VkEventArgs
    {
        public Video Video { get; }

        internal VideoAddedEventArgs(dynamic payloadObject)
        {
            Video = ToObject<Video>(payloadObject);
        }
    }
}