using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Message
{
    public sealed class MessageCreatedEventArgs : VkEventArgs
    {
        public Entities.Message Message { get; }
        
        //TODO: Make a class for client info
        public dynamic ClientInfo { get; }

        internal MessageCreatedEventArgs(dynamic payloadData)
        {
            var obj = (JObject) JObject.Parse(payloadData.ToString());
            
            Message = ToObject<Entities.Message>(obj["message"]);
            ClientInfo = obj["client_info"];
        }
        
    }
}