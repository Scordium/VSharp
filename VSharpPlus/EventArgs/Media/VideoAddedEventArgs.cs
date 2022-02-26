using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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