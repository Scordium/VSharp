namespace VSharp.EventArgs.Message
{
    public sealed class MessageReplyCreatedEventArgs : VkEventArgs
    {
        public Entities.Message Message { get; }

        internal MessageReplyCreatedEventArgs(dynamic payloadObject)
        {
            Message = ToObject<Entities.Message>(payloadObject);
        }
    }
}