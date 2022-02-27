using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class PhotoAddedEventArgs : VkEventArgs
    {
        public Photo Photo { get; }

        internal PhotoAddedEventArgs(dynamic payloadObject)
        {
            Photo = ToObject<Photo>(payloadObject);
        }
    }
}