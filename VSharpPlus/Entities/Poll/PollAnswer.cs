namespace VSharpPlus.Entities.Poll
{
    public class PollAnswer
    {
        public int Id { get; internal set; }
        public string Text { get; internal set; }
        public int Votes { get; internal set; }
        public float Rating { get; internal set; }
    }
}