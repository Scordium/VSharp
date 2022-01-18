using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VSharpPlus.Entities.Media;

namespace VSharpPlus.EventArgs
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