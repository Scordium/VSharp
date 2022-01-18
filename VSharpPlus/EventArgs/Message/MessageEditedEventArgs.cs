namespace VSharpPlus.EventArgs.Message
{
    public sealed class MessageEditedEventArgs : VkEventArgs
    {
        //??????
        public Entities.Message Message { get; }

        internal MessageEditedEventArgs(dynamic payloadObject)
        {
            Message = ToObject<Entities.Message>(payloadObject);
        }
    }
}