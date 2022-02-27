using Emzi0767.Utilities;
using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs
{
    public abstract class VkEventArgs : AsyncEventArgs
    {
        protected VkEventArgs(){}
        
        internal T ToObject<T>(JObject data) => data.ToObject<T>();

        internal T ToObject<T>(dynamic data)
        {
            var obj = (JObject) JObject.Parse(data.ToString());

            return obj.ToObject<T>();
        }
        
        
    }
}