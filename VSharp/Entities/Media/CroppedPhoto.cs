using Newtonsoft.Json;

namespace VSharpPlus.Entities.Media
{
    public class CroppedPhoto
    {
        [JsonProperty("photo")]
        public Photo Original { get; internal set; }
        [JsonProperty("crop")]
        public CroppedPhotoData Crop { get; internal set; }
        [JsonProperty("rect")]
        public CroppedPhotoData Rect { get; internal set; }
    }
}