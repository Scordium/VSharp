using VSharp.Entities.Media;

namespace VSharp.EventArgs.Media
{
    public sealed class AudioAddedEventArgs : VkEventArgs
    {
        public Audio Audio { get; }

        internal AudioAddedEventArgs(dynamic payloadObject)
        {
            Audio = ToObject<Audio>(payloadObject);
        }
    }
}