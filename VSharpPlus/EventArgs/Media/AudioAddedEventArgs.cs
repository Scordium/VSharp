using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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