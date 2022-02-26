using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs
{
    public sealed class PollVoteCreatedEventArgs : VkEventArgs
    {
        public int OwnerId { get; }
        public int PollId { get; }
        public int OptionId { get; }
        public int UserId { get; }

        internal PollVoteCreatedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            OwnerId = obj["owner_id"].Value<int>();;
            PollId = obj["poll_id"].Value<int>();;
            OptionId = obj["option_id"].Value<int>();;
            UserId = obj["user_id"].Value<int>();;
        }
    }
}