using Newtonsoft.Json;

namespace VSharp.Entities.Media
{
    public class CroppedPhotoData
    {
        [JsonProperty("x")]
        public float UpperLeftX { get; internal set; }
        [JsonProperty("y")]
        public float UpperLeftY { get; internal set; }
        [JsonProperty("x2")]
        public float BottomRightX { get; internal set; }
        [JsonProperty("y2")]
        public float BottomRightY { get; internal set; }
    }
}