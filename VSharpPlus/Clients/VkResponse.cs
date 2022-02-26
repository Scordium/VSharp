using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using VSharpPlus.Utils;

namespace VSharpPlus.Clients
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