using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace VSharp.Clients
{
    internal class VkResponse<T>
    {
        [JsonProperty("response")]
        public List<T> ResponseObjects;

        public T Object => ResponseObjects.First();
    }

    public class VkResponseSingle<T>
    {
        [JsonProperty("response")]
        public T Object;
    }
}