using System;
using System.Collections.Generic;
using VSharp.Entities.Media;

namespace VSharp.Entities.Poll
{
    public class Poll
    {
        public int Id { get; internal set; }
        public int OwnerId { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public string QuestionText { get; internal set; }
        public int VotesCount { get; internal set; }
        public List<PollAnswer> Answers { get; internal set; }
        public bool Anonymous { get; internal set; }
        public bool MultipleAllowed { get; internal set; }
        public List<int> ChosenAnswers { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public bool Closed { get; internal set; }
        public bool AttachedToBoard { get; internal set; }
        public bool CanEdit { get; internal set; }
        public bool CanVote { get; internal set; }
        public bool CanReport { get; internal set; }
        public bool CanShare { get; internal set; }
        public int AuthorId { get; internal set; }
        public Photo Photo { get; internal set; }
        
    }
}