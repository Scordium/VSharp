using Emzi0767.Utilities;
using VSharp.EventArgs;
using VSharp.EventArgs.Donut;
using VSharp.EventArgs.Group;
using VSharp.EventArgs.Market;
using VSharp.EventArgs.Media;
using VSharp.EventArgs.Message;
using VSharp.EventArgs.Topic;
using VSharp.EventArgs.WallPost;

namespace VSharp.Clients
{
    public partial class VkClient
    {
        public event AsyncEventHandler<VkClient, MessageCreatedEventArgs> MessageCreated
        {
            add => _messageCreated.Register(value);
            remove => _messageCreated.Unregister(value);
        }
        private AsyncEvent<VkClient, MessageCreatedEventArgs> _messageCreated;

        
        public event AsyncEventHandler<VkClient, TypingStartedEventArgs> TypingStarted
        {
            add => _typingStarted.Register(value);
            remove => _typingStarted.Unregister(value);
        }
        private AsyncEvent<VkClient, TypingStartedEventArgs> _typingStarted;
     
        
        public event AsyncEventHandler<VkClient, MessageReplyCreatedEventArgs> ReplyCreated
        {
            add => _replyCreated.Register(value);
            remove => _replyCreated.Unregister(value);
        }
        private AsyncEvent<VkClient, MessageReplyCreatedEventArgs> _replyCreated;
        
        
        public event AsyncEventHandler<VkClient, MessageEditedEventArgs> MessageEdited
        {
            add => _messageEdited.Register(value);
            remove => _messageEdited.Unregister(value);
        }
        private AsyncEvent<VkClient, MessageEditedEventArgs> _messageEdited;
        
        
        public event AsyncEventHandler<VkClient, GroupMessagesAllowedEventArgs> GroupMessagesAllowed
        {
            add => _groupMessagesAllowed.Register(value);
            remove => _groupMessagesAllowed.Unregister(value);
        }
        private AsyncEvent<VkClient, GroupMessagesAllowedEventArgs> _groupMessagesAllowed;
        
        
        public event AsyncEventHandler<VkClient, GroupMessagesBlockedEventArgs> GroupMessagesBlocked
        {
            add => _groupMessagesBlocked.Register(value);
            remove => _groupMessagesBlocked.Unregister(value);
        }
        private AsyncEvent<VkClient, GroupMessagesBlockedEventArgs> _groupMessagesBlocked;

        public event AsyncEventHandler<VkClient, WallPostCreatedEventArgs> WallPostCreated
        {
            add => _wallPostCreated.Register(value);
            remove => _wallPostCreated.Unregister(value);
        }
        private AsyncEvent<VkClient, WallPostCreatedEventArgs> _wallPostCreated;
        
        public event AsyncEventHandler<VkClient, WallPostCommentCreatedEventArgs> WallPostReplyCreated
        {
            add => _wallPostCommentCreated.Register(value);
            remove => _wallPostCommentCreated.Unregister(value);
        }

        private AsyncEvent<VkClient, WallPostCommentCreatedEventArgs> _wallPostCommentCreated;
        
        
        public event AsyncEventHandler<VkClient, PhotoAddedEventArgs> PhotoAdded
        {
            add => _photoAdded.Register(value);
            remove => _photoAdded.Unregister(value);
        }

        private AsyncEvent<VkClient, PhotoAddedEventArgs> _photoAdded;
        
        
        public event AsyncEventHandler<VkClient, LikeAddedEventArgs> LikeAdded
        {
            add => _likeAdded.Register(value);
            remove => _likeAdded.Unregister(value);
        }

        private AsyncEvent<VkClient, LikeAddedEventArgs> _likeAdded;
        
        
        public event  AsyncEventHandler<VkClient, LikeRemovedEventArgs> LikeRemoved
        {
            add => _likeRemoved.Register(value);
            remove => _likeRemoved.Unregister(value);
        }

        private AsyncEvent<VkClient, LikeRemovedEventArgs> _likeRemoved;
        
        
        public event AsyncEventHandler<VkClient, TopicCommentCreatedEventArgs> TopicCommentCreated
        {
            add => _topicCommentCreated.Register(value);
            remove => _topicCommentCreated.Unregister(value);
        }

        private AsyncEvent<VkClient, TopicCommentCreatedEventArgs> _topicCommentCreated;
        
        public event AsyncEventHandler<VkClient, TopicCommentDeletedEventArgs> TopicCommentDeleted
        {
            add => _topicCommentDeleted.Register(value);
            remove => _topicCommentDeleted.Unregister(value);
        }

        private AsyncEvent<VkClient, TopicCommentDeletedEventArgs> _topicCommentDeleted;
        
        
        public event AsyncEventHandler<VkClient, TopicCommentEditedEventArgs> TopicCommentEdited
        {
            add => _topicCommentEdited.Register(value);
            remove => _topicCommentEdited.Unregister(value);
        }

        private AsyncEvent<VkClient, TopicCommentEditedEventArgs> _topicCommentEdited;
        
        
        
        public event AsyncEventHandler<VkClient, TopicCommentRestoredEventArgs> TopicCommentRestored
        {
            add => _topicCommentRestored.Register(value);
            remove => _topicCommentRestored.Unregister(value);
        }

        private AsyncEvent<VkClient, TopicCommentRestoredEventArgs> _topicCommentRestored;
        
        
        
        public event AsyncEventHandler<VkClient, MarketOrderEditedEventArgs> MarketOrderEdited
        {
            add => _marketOrderEdited.Register(value);
            remove => _marketOrderEdited.Unregister(value);
        }

        private AsyncEvent<VkClient, MarketOrderEditedEventArgs> _marketOrderEdited;
        
        
        public event AsyncEventHandler<VkClient, MarketOrderCreatedEventArgs> MarketOrderCreated
        {
            add => _marketOrderCreated.Register(value);
            remove => _marketOrderCreated.Unregister(value);
        }

        private AsyncEvent<VkClient, MarketOrderCreatedEventArgs> _marketOrderCreated;
        
        public event AsyncEventHandler<VkClient,MarketItemCommentCreatedEventArgs> MarketItemCommentCreated
        {
            add => _marketItemCommentCreated.Register(value);
            remove => _marketItemCommentCreated.Unregister(value);
        }
        private AsyncEvent<VkClient,MarketItemCommentCreatedEventArgs> _marketItemCommentCreated;
        
        public event AsyncEventHandler<VkClient,MarketItemCommentEditedEventArgs> MarketItemCommentEdited
        {
            add => _marketItemCommentEdited.Register(value);
            remove => _marketItemCommentEdited.Unregister(value);
        }
        private AsyncEvent<VkClient,MarketItemCommentEditedEventArgs> _marketItemCommentEdited;
        
        public event AsyncEventHandler<VkClient,MarketItemCommentRestoredEventArgs> MarketItemCommentRestored
        {
            add => _marketItemCommentRestored.Register(value);
            remove => _marketItemCommentRestored.Unregister(value);
        }
        private AsyncEvent<VkClient,MarketItemCommentRestoredEventArgs> _marketItemCommentRestored;
        
        
        
        public event AsyncEventHandler<VkClient,MarketItemCommentDeletedEventArgs> MarketItemCommentDeleted
        {
            add => _marketItemCommentDeleted.Register(value);
            remove => _marketItemCommentDeleted.Unregister(value);
        }

        private AsyncEvent<VkClient, MarketItemCommentDeletedEventArgs> _marketItemCommentDeleted;
        
        
        public event AsyncEventHandler<VkClient,WallPostCommentEditedEventArgs> WallPostCommentEdited
        {
            add => _wallPostCommentEdited.Register(value);
            remove => _wallPostCommentEdited.Unregister(value);
        }
        private AsyncEvent<VkClient,WallPostCommentEditedEventArgs> _wallPostCommentEdited;
        
        
        public event AsyncEventHandler<VkClient,WallPostCommentRestoredEventArgs> WallPostCommentRestored
        {
            add => _wallPostCommentRestored.Register(value);
            remove => _wallPostCommentRestored.Unregister(value);
        }
        private AsyncEvent<VkClient,WallPostCommentRestoredEventArgs> _wallPostCommentRestored;
        
        public event AsyncEventHandler<VkClient,WallPostCommentDeletedEventArgs> WallPostCommentDeleted
        {
            add => _wallPostCommentDeleted.Register(value);
            remove => _wallPostCommentDeleted.Unregister(value);
        }
        private AsyncEvent<VkClient,WallPostCommentDeletedEventArgs> _wallPostCommentDeleted;
        
        
        public event AsyncEventHandler<VkClient,WallPostRepostedEventArgs> WallPostReposted
        {
            add => _wallPostReposted.Register(value);
            remove => _wallPostReposted.Unregister(value);
        }
        private AsyncEvent<VkClient,WallPostRepostedEventArgs> _wallPostReposted;
        
        
        public event AsyncEventHandler<VkClient,PhotoCommentCreatedEventArgs> PhotoCommentCreated
        {
            add => _photoCommentCreated.Register(value);
            remove => _photoCommentCreated.Unregister(value);
        }
        
        private AsyncEvent<VkClient,PhotoCommentCreatedEventArgs> _photoCommentCreated;
        
        
        
        public event AsyncEventHandler<VkClient,PhotoCommentEditedEventArgs> PhotoCommentEdited
        {
            add => _photoCommentEdited.Register(value);
            remove => _photoCommentEdited.Unregister(value);
        }
        
        private AsyncEvent<VkClient,PhotoCommentEditedEventArgs> _photoCommentEdited;
        
        
        public event AsyncEventHandler<VkClient,PhotoCommentRestoredEventArgs> PhotoCommentRestored
        {
            add => _photoCommentRestored.Register(value);
            remove => _photoCommentRestored.Unregister(value);
        }
        private AsyncEvent<VkClient,PhotoCommentRestoredEventArgs> _photoCommentRestored;
        
        
        public event AsyncEventHandler<VkClient,PhotoCommentDeletedEventArgs> PhotoCommentDeleted
        {
            add => _photoCommentDeleted.Register(value);
            remove => _photoCommentDeleted.Unregister(value);
        }
        private AsyncEvent<VkClient, PhotoCommentDeletedEventArgs> _photoCommentDeleted;
        
        public event AsyncEventHandler<VkClient,AudioAddedEventArgs> AudioAdded
        {
            add => _audioAdded.Register(value);
            remove => _audioAdded.Unregister(value);
        }

        private AsyncEvent<VkClient, AudioAddedEventArgs> _audioAdded;
        
        
        public event AsyncEventHandler<VkClient,VideoAddedEventArgs> VideoAdded
        {
            add => _videoAdded.Register(value);
            remove => _videoAdded.Unregister(value);
        }
        private AsyncEvent<VkClient,VideoAddedEventArgs> _videoAdded;

        
        
        public event AsyncEventHandler<VkClient,VideoCommentCreatedEventArgs> VideoCommentCreated
        {
            add => _videoCommentCreated.Register(value);
            remove => _videoCommentCreated.Unregister(value);
        }
        private AsyncEvent<VkClient,VideoCommentCreatedEventArgs> _videoCommentCreated;
        
        
        public event AsyncEventHandler<VkClient,VideoCommentEditedEventArgs> VideoCommentEdited
        {
            add => _videoCommentEdited.Register(value);
            remove => _videoCommentEdited.Unregister(value);
        }
        private AsyncEvent<VkClient,VideoCommentEditedEventArgs> _videoCommentEdited;
        
        
        public event AsyncEventHandler<VkClient,VideoCommentRestoredEventArgs> VideoCommentRestored
        {
            add => _videoCommentRestored.Register(value);
            remove => _videoCommentRestored.Unregister(value);
        }
        private AsyncEvent<VkClient,VideoCommentRestoredEventArgs> _videoCommentRestored;
        
        public event AsyncEventHandler<VkClient,VideoCommentDeletedEventArgs> VideoCommentDeleted
        {
            add => _videoCommentDeleted.Register(value);
            remove => _videoCommentDeleted.Unregister(value);
        }
        private AsyncEvent<VkClient,VideoCommentDeletedEventArgs> _videoCommentDeleted;
        
        
        public event AsyncEventHandler<VkClient,GroupMemberLeftEventArgs> GroupMemberLeft
        {
            add => _groupMemberLeft.Register(value);
            remove => _groupMemberLeft.Unregister(value);
        }

        private AsyncEvent<VkClient, GroupMemberLeftEventArgs> _groupMemberLeft;
        
        
        public event AsyncEventHandler<VkClient,GroupMemberJoinedEventArgs> GroupMemberJoined
        {
            add => _groupMemberJoined.Register(value);
            remove => _groupMemberJoined.Unregister(value);
        }
        private AsyncEvent<VkClient,GroupMemberJoinedEventArgs> _groupMemberJoined;
        
        
        public event AsyncEventHandler<VkClient,GroupUserBlacklistedEventArgs> UserBlacklisted
        {
            add => _userBlacklisted.Register(value);
            remove => _userBlacklisted.Unregister(value);
        }
        private AsyncEvent<VkClient,GroupUserBlacklistedEventArgs> _userBlacklisted;
        
        
        public event AsyncEventHandler<VkClient,GroupUserUnblacklistedEventArgs> UserUnblacklisted
        {
            add => _userUnblacklisted.Register(value);
            remove => _userUnblacklisted.Unregister(value);
        }
        private AsyncEvent<VkClient,GroupUserUnblacklistedEventArgs> _userUnblacklisted;
        
        
        public event AsyncEventHandler<VkClient,DonutSubscriptionCreatedEventArgs> DonutSubscriptionCreated
        {
            add => _donutSubscriptionCreated.Register(value);
            remove => _donutSubscriptionCreated.Unregister(value);
        } 
        private AsyncEvent<VkClient,DonutSubscriptionCreatedEventArgs> _donutSubscriptionCreated;
        

        
        public event AsyncEventHandler<VkClient,DonutSubscriptionProlongedEventArgs> DonutSubscriptionProlonged
        {
            add => _donutSubscriptionProlonged.Register(value);
            remove => _donutSubscriptionProlonged.Unregister(value);
        }
        private AsyncEvent<VkClient,DonutSubscriptionProlongedEventArgs> _donutSubscriptionProlonged;
        
        
        public event AsyncEventHandler<VkClient,DonutSubscriptionExpiredEventArgs> DonutSubscriptionExpired
        {
            add => _donutSubscriptionExpired.Register(value);
            remove => _donutSubscriptionExpired.Unregister(value);
        }

        private AsyncEvent<VkClient, DonutSubscriptionExpiredEventArgs> _donutSubscriptionExpired;
        
        
        public event AsyncEventHandler<VkClient,DonutSubscriptionCancelledEventArgs> DonutSubscriptionCancelled
        {
            add => _donutSubscriptionCancelled.Register(value);
            remove => _donutSubscriptionCancelled.Unregister(value);
        }
        private AsyncEvent<VkClient,DonutSubscriptionCancelledEventArgs> _donutSubscriptionCancelled;
        
        public event AsyncEventHandler<VkClient,DonutSubscriptionPriceChangedEventArgs> DonutSubscriptionPriceChanged
        {
            add => _donutSubscriptionPriceChanged.Register(value);
            remove => _donutSubscriptionPriceChanged.Unregister(value);
        }
        private AsyncEvent<VkClient,DonutSubscriptionPriceChangedEventArgs> _donutSubscriptionPriceChanged;
        
        
        public event AsyncEventHandler<VkClient,DonutMoneyWithdrawnEventArgs> DonutMoneyWithdrawn
        {
            add => _donutMoneyWithdrawn.Register(value);
            remove => _donutMoneyWithdrawn.Unregister(value);
        }
        private AsyncEvent<VkClient,DonutMoneyWithdrawnEventArgs> _donutMoneyWithdrawn;
        
        
        public event AsyncEventHandler<VkClient,DonutMoneyWithdrawErroredEventArgs> DonutMoneyWithdrawErrored
        {
            add => _donutMoneyWithdrawErrored.Register(value);
            remove => _donutMoneyWithdrawErrored.Unregister(value);
        }
        private AsyncEvent<VkClient,DonutMoneyWithdrawErroredEventArgs> _donutMoneyWithdrawErrored;
        
        
        public event AsyncEventHandler<VkClient,GroupOfficerEditedEventArgs> GroupOfficerEdited
        {
            add => _groupOfficerEdited.Register(value);
            remove => _groupOfficerEdited.Unregister(value);
        }
        private AsyncEvent<VkClient,GroupOfficerEditedEventArgs> _groupOfficerEdited;
        
        public event AsyncEventHandler<VkClient,GroupPhotoChangedEventArgs> GroupPhotoChanged
        {
            add => _groupPhotoChanged.Register(value);
            remove => _groupPhotoChanged.Unregister(value);
        }
        private AsyncEvent<VkClient,GroupPhotoChangedEventArgs> _groupPhotoChanged;
        
        
        public event AsyncEventHandler<VkClient,VkPayTransactionEventArgs> VkPayTransaction
        {
            add => _vkPayTransaction.Register(value);
            remove => _vkPayTransaction.Unregister(value);
        }
        private AsyncEvent<VkClient,VkPayTransactionEventArgs> _vkPayTransaction;
        
        
        public event AsyncEventHandler<VkClient,AppPayloadReceivedEventArgs> AppPayloadReceived
        {
            add => _appPayloadReceived.Register(value);
            remove => _appPayloadReceived.Unregister(value);
        }
        private AsyncEvent<VkClient,AppPayloadReceivedEventArgs> _appPayloadReceived;
        
        
        
        public event AsyncEventHandler<VkClient,PollVoteCreatedEventArgs> PollVoteCreated
        {
            add => _pollVoteCreated.Register(value);
            remove => _pollVoteCreated.Unregister(value);
        }
        private AsyncEvent<VkClient,PollVoteCreatedEventArgs> _pollVoteCreated;
        
    }
}