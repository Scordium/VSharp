using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Emzi0767.Utilities;
using Newtonsoft.Json.Linq;
using VSharpPlus.Abstractions;
using VSharpPlus.Entities;
using VSharpPlus.Entities.User;
using VSharpPlus.EventArgs;
using VSharpPlus.EventArgs.Donut;
using VSharpPlus.EventArgs.Group;
using VSharpPlus.EventArgs.Market;
using VSharpPlus.EventArgs.Message;
using VSharpPlus.EventArgs.Topic;
using VSharpPlus.EventArgs.WallPost;
using VSharpPlus.Utils;
using static VSharpPlus.Utils.QueryCreator;


namespace VSharpPlus.Clients
{
    public sealed partial class VkClient : BaseClient
    {
        private int BotGroupId;
        private string? ConfirmOnNew;
        private CancellationToken? CancellationToken;

        internal void Configure()
        {
            _typingStarted = new AsyncEvent<VkClient, TypingStartedEventArgs>("message_typing_state", TimeSpan.FromSeconds(2), null);
            _messageCreated = new AsyncEvent<VkClient, MessageCreatedEventArgs>("message_new", TimeSpan.FromSeconds(2), null);
            _messageEdited = new AsyncEvent<VkClient, MessageEditedEventArgs>("message_edit", TimeSpan.FromSeconds(2), null);
            _replyCreated = new AsyncEvent<VkClient, MessageReplyCreatedEventArgs>("message_reply", TimeSpan.FromSeconds(2), null);
            
            _wallPostCreated = new AsyncEvent<VkClient, WallPostCreatedEventArgs>("wall_post_new", TimeSpan.FromSeconds(2), null);
            _wallPostReposted = new AsyncEvent<VkClient,WallPostRepostedEventArgs>("wall_repost", TimeSpan.FromSeconds(2), null);
            _wallPostCommentCreated = new AsyncEvent<VkClient, WallPostCommentCreatedEventArgs>("wall_reply_new", TimeSpan.FromSeconds(2), null);
            _wallPostCommentEdited = new AsyncEvent<VkClient, WallPostCommentEditedEventArgs>("wall_reply_edit", TimeSpan.FromSeconds(2), null);
            _wallPostCommentRestored = new AsyncEvent<VkClient, WallPostCommentRestoredEventArgs>("wall_reply_restore", TimeSpan.FromSeconds(2), null);
            _wallPostCommentDeleted = new AsyncEvent<VkClient, WallPostCommentDeletedEventArgs>("wall_reply_delete", TimeSpan.FromSeconds(2), null);
            
            _photoAdded = new AsyncEvent<VkClient, PhotoAddedEventArgs>("photo_new", TimeSpan.FromSeconds(2), null);
            _photoCommentCreated = new AsyncEvent<VkClient,PhotoCommentCreatedEventArgs>("photo_comment_new", TimeSpan.FromSeconds(2), null);
            _photoCommentEdited = new AsyncEvent<VkClient,PhotoCommentEditedEventArgs>("photo_comment_edit", TimeSpan.FromSeconds(2), null);
            _photoCommentRestored = new AsyncEvent<VkClient,PhotoCommentRestoredEventArgs>("photo_comment_restored", TimeSpan.FromSeconds(2), null);
            _photoCommentDeleted = new AsyncEvent<VkClient,PhotoCommentDeletedEventArgs>("photo_comment_delete", TimeSpan.FromSeconds(2), null);

            _audioAdded = new AsyncEvent<VkClient, AudioAddedEventArgs>("audio_new", TimeSpan.FromSeconds(2), null);
            
            _videoAdded = new AsyncEvent<VkClient, VideoAddedEventArgs>("video_new", TimeSpan.FromSeconds(2), null);
            _videoCommentCreated = new AsyncEvent<VkClient,VideoCommentCreatedEventArgs>("video_comment_new", TimeSpan.FromSeconds(2), null);
            _videoCommentEdited = new AsyncEvent<VkClient,VideoCommentEditedEventArgs>("video_comment_edit", TimeSpan.FromSeconds(2), null);
            _videoCommentRestored = new AsyncEvent<VkClient,VideoCommentRestoredEventArgs>("video_comment_restore", TimeSpan.FromSeconds(2), null);
            _videoCommentDeleted = new AsyncEvent<VkClient,VideoCommentDeletedEventArgs>("video_comment_delete", TimeSpan.FromSeconds(2), null);

            _likeAdded = new AsyncEvent<VkClient, LikeAddedEventArgs>("like_add", TimeSpan.FromSeconds(2), null);
            _likeRemoved = new AsyncEvent<VkClient, LikeRemovedEventArgs>("like_remove", TimeSpan.FromSeconds(2), null);
            
            _topicCommentCreated = new AsyncEvent<VkClient, TopicCommentCreatedEventArgs>("board_post_new", TimeSpan.FromSeconds(2), null);
            _topicCommentDeleted = new AsyncEvent<VkClient, TopicCommentDeletedEventArgs>("board_post_delete", TimeSpan.FromSeconds(2), null);
            _topicCommentEdited = new AsyncEvent<VkClient, TopicCommentEditedEventArgs>("board_post_edit", TimeSpan.FromSeconds(2), null);
            _topicCommentRestored = new AsyncEvent<VkClient, TopicCommentRestoredEventArgs>("board_post_restore", TimeSpan.FromSeconds(2), null);
            
            _marketOrderEdited = new AsyncEvent<VkClient, MarketOrderEditedEventArgs>("market_order_edit", TimeSpan.FromSeconds(2),null);
            _marketOrderCreated = new AsyncEvent<VkClient, MarketOrderCreatedEventArgs>("market_order_new", TimeSpan.FromSeconds(2), null);
            _marketItemCommentCreated = new AsyncEvent<VkClient,MarketItemCommentCreatedEventArgs>("market_comment_new", TimeSpan.FromSeconds(2), null);
            _marketItemCommentEdited = new AsyncEvent<VkClient,MarketItemCommentEditedEventArgs>("market_comment_edit", TimeSpan.FromSeconds(2), null);
            _marketItemCommentRestored = new AsyncEvent<VkClient,MarketItemCommentRestoredEventArgs>("market_comment_restore", TimeSpan.FromSeconds(2), null);
            _marketItemCommentDeleted = new AsyncEvent<VkClient,MarketItemCommentDeletedEventArgs>("market_comment_delete", TimeSpan.FromSeconds(2), null);
            
            _groupOfficerEdited = new AsyncEvent<VkClient,GroupOfficerEditedEventArgs>("group_officers_edit", TimeSpan.FromSeconds(2), null);
            _groupPhotoChanged = new AsyncEvent<VkClient,GroupPhotoChangedEventArgs>("group_change_photo", TimeSpan.FromSeconds(2), null);
            _groupMessagesBlocked = new AsyncEvent<VkClient,GroupMessagesBlockedEventArgs>("message_deny", TimeSpan.FromSeconds(2), null);
            _groupMessagesAllowed = new AsyncEvent<VkClient,GroupMessagesAllowedEventArgs>("message_allow", TimeSpan.FromSeconds(2), null);
            _groupMemberJoined = new AsyncEvent<VkClient,GroupMemberJoinedEventArgs>("group_join", TimeSpan.FromSeconds(2), null);
            _groupMemberLeft = new AsyncEvent<VkClient,GroupMemberLeftEventArgs>("group_leave", TimeSpan.FromSeconds(2), null);
            _userBlacklisted = new AsyncEvent<VkClient,GroupUserBlacklistedEventArgs>("user_block", TimeSpan.FromSeconds(2), null);
            _userUnblacklisted = new AsyncEvent<VkClient,GroupUserUnblacklistedEventArgs>("user_unblock", TimeSpan.FromSeconds(2), null);
            
            _donutSubscriptionCreated = new AsyncEvent<VkClient, DonutSubscriptionCreatedEventArgs>("donut_subscription_create", TimeSpan.FromSeconds(2), null);
            _donutSubscriptionProlonged = new AsyncEvent<VkClient,DonutSubscriptionProlongedEventArgs>("donut_subscription_prolonged", TimeSpan.FromSeconds(2), null);
            _donutSubscriptionExpired = new AsyncEvent<VkClient,DonutSubscriptionExpiredEventArgs>("donut_subscription_expired", TimeSpan.FromSeconds(2), null);
            _donutSubscriptionCancelled = new AsyncEvent<VkClient,DonutSubscriptionCancelledEventArgs>("donut_subscription_cancelled", TimeSpan.FromSeconds(2), null);
            _donutSubscriptionPriceChanged = new AsyncEvent<VkClient,DonutSubscriptionPriceChangedEventArgs>("donut_subscription_price_changed", TimeSpan.FromSeconds(2), null);
            _donutMoneyWithdrawn = new AsyncEvent<VkClient,DonutMoneyWithdrawnEventArgs>("donut_money_withdraw", TimeSpan.FromSeconds(2), null);
            _donutMoneyWithdrawErrored = new AsyncEvent<VkClient,DonutMoneyWithdrawErroredEventArgs>("donut_money_withdraw_error", TimeSpan.FromSeconds(2), null);
            
            _vkPayTransaction = new AsyncEvent<VkClient, VkPayTransactionEventArgs>("vkpay_transaction", TimeSpan.FromSeconds(2), null);
            _appPayloadReceived = new AsyncEvent<VkClient,AppPayloadReceivedEventArgs>("app_payload", TimeSpan.FromSeconds(2), null);
            
            _pollVoteCreated = new AsyncEvent<VkClient, PollVoteCreatedEventArgs>("poll_vote_new", TimeSpan.FromSeconds(2), null);
        }

        
        public VkClient(string token, int groupId) : base(token)
        {
            BotGroupId = groupId;
            Configure();
            CancellationToken = new CancellationToken();
            _ = Task.Run(async () => await Listen(), CancellationToken.Value);
        }

        private async Task Listen()
        {
            try
            {
                
                HttpListener listener = new();

                listener.Prefixes.Add("http://127.0.0.1:8000/callback/");
                listener.Start();

                while (true)
                {
                    HttpListenerContext context = await listener.GetContextAsync();
                    var response = context.Response;

                    var request = context.Request;
                    var payloadString = await new StreamReader(request.InputStream).ReadToEndAsync();
                    var payload = JObject.Parse(payloadString).ToObject<VkGatewayPayload>();
                    if(payload == null) return;
                    
                    string responseStr = await HandleDispatchAsync(payload);
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);

                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);

                    output.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }



        public void ConfigureNewServer(string confirmationString) => ConfirmOnNew = confirmationString;


        public async Task<VkUser> GetUsersAsync(int user_id)
        {
            return (await DoRequestAsync<VkResponse<VkUser>>(ENDPOINTS.GetUser, $"user_ids={user_id}&fields={ARGUMENTS.User}")).Object;
        }

        public async Task<List<VkUser>> GetUsersAsync(List<int> user_ids)
        {
            return (await DoRequestAsync<VkResponse<VkUser>>(ENDPOINTS.GetUser, $"user_ids={string.Join(",", user_ids)}&fields={ARGUMENTS.User}")).ResponseObjects;
        }
        
        
        public async Task<int> SendMessageAsync(MessageBuilder builder)
        {
            try
            {
                builder.Validate();
                var msg = 0;

                if (builder.PeerIds.Count == 1)
                    msg = (await DoRequestAsync<VkResponseSingle<int>>(ENDPOINTS.SendMessage, MakeQuery(builder))).Object;
                else
                    msg = (await DoRequestAsync<VkResponse<int>>(ENDPOINTS.SendMessage, MakeQuery(builder))).Object;
                
                return msg;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> GetConfirmationStringAsync()
        {
            return (await DoRequestAsync<VkResponseSingle<dynamic>>(ENDPOINTS.ConfirmServerSettings, $"group_id={BotGroupId}")).Object["code"];
        }



        public async Task<string> HandleDispatchAsync(VkGatewayPayload payload)
        {
            if (payload.Type is "confirmation")
            {
                if (ConfirmOnNew != null)
                {
                    var s = ConfirmOnNew;
                    ConfirmOnNew = null;
                    return s;
                }

                return await GetConfirmationStringAsync();
            }
            
            try
            {
                Console.WriteLine(payload.Type + " | " + payload.Object.ToString());
                switch (payload.Type)
                {
                    #region Message
                    case "message_new":
                        await _messageCreated.InvokeAsync(this, new MessageCreatedEventArgs(payload.Object));
                        break;

                    case "message_reply":
                        await _replyCreated.InvokeAsync(this, new MessageReplyCreatedEventArgs(payload.Object));
                        break;
                    
                    case "message_deny":
                        await _groupMessagesBlocked.InvokeAsync(this, new GroupMessagesBlockedEventArgs(payload.Object));
                        break;
                    
                    case "message_allow":
                        await _groupMessagesAllowed.InvokeAsync(this, new GroupMessagesAllowedEventArgs(payload.Object));
                        break;
                        
                    case "message_edit":
                        await _messageEdited.InvokeAsync(this, new MessageEditedEventArgs(payload.Object));
                        break;
                    
                    case "message_typing_state":
                        await _typingStarted.InvokeAsync(this, new TypingStartedEventArgs(payload.Object));
                        break;

                    #endregion

                    #region Topic
                    case "board_post_new":
                        await _topicCommentCreated.InvokeAsync(this, new TopicCommentCreatedEventArgs(payload.Object));
                        break;

                    case "board_post_delete":
                        await _topicCommentDeleted.InvokeAsync(this, new TopicCommentDeletedEventArgs(payload.Object));
                        break;

                    case "board_post_edit":
                        await _topicCommentEdited.InvokeAsync(this, new TopicCommentEditedEventArgs(payload.Object));
                        break;

                    case "board_post_restore":
                        await _topicCommentRestored.InvokeAsync(this, new TopicCommentRestoredEventArgs(payload.Object));
                        break;
                    
                    #endregion
                    
                    #region Market
                    case "market_order_edit":
                        await _marketOrderEdited.InvokeAsync(this, new MarketOrderEditedEventArgs(payload.Object));
                        break;
                    
                    case "market_order_new":
                        await _marketOrderCreated.InvokeAsync(this, new MarketOrderCreatedEventArgs(payload.Object));
                        break;
                    
                    case "market_comment_new":
                        await _marketItemCommentCreated.InvokeAsync(this, new MarketItemCommentCreatedEventArgs(payload.Object));
                        break;
                    
                    case "market_comment_edit":
                        await _marketItemCommentEdited.InvokeAsync(this, new MarketItemCommentEditedEventArgs(payload.Object));
                        break;
                    
                    case "market_comment_restore":
                        await _marketItemCommentRestored.InvokeAsync(this, new MarketItemCommentRestoredEventArgs(payload.Object));
                        break;
                    
                    case "market_comment_delete":
                        await _marketItemCommentDeleted.InvokeAsync(this, new MarketItemCommentDeletedEventArgs(payload.Object));
                        break;
                    #endregion
                    
                    #region WallPost
                    case "wall_post_new":
                        await _wallPostCreated.InvokeAsync(this, new WallPostCreatedEventArgs(payload.Object));
                        break;

                    case "wall_repost":
                        await _wallPostReposted.InvokeAsync(this, new WallPostRepostedEventArgs(payload.Object));
                        break;
                    
                    case "wall_reply_new":
                        await _wallPostCommentCreated.InvokeAsync(this, new WallPostCommentCreatedEventArgs(payload.Object));
                        break;
                    
                    case "wall_reply_delete":
                        await _wallPostCommentDeleted.InvokeAsync(this, new WallPostCommentDeletedEventArgs(payload.Object));
                        break;
                    
                    case "wall_reply_edit":
                        await _wallPostCommentEdited.InvokeAsync(this, new WallPostCommentEditedEventArgs(payload.Object));
                        break;
                    
                    case "wall_reply_restore":
                        await _wallPostCommentRestored.InvokeAsync(this, new WallPostCommentRestoredEventArgs(payload.Object));
                        break;
                    #endregion
                    
                    #region Photo
                    case "photo_new":
                        await _photoAdded.InvokeAsync(this, new PhotoAddedEventArgs(payload.Object));
                        break;

                    case "photo_comment_new":
                        await _photoCommentCreated.InvokeAsync(this, new PhotoCommentCreatedEventArgs(payload.Object));
                        break;
                    
                    case "photo_comment_edit":
                        await _photoCommentEdited.InvokeAsync(this, new PhotoCommentEditedEventArgs(payload.Object));
                        break;
                    
                    case "photo_comment_restore":
                        await _photoCommentRestored.InvokeAsync(this, new PhotoCommentRestoredEventArgs(payload.Object));
                        break;
                    
                    case "photo_comment_delete":
                        await _photoCommentDeleted.InvokeAsync(this, new PhotoCommentDeletedEventArgs(payload.Object));
                        break;
                    #endregion
                    
                    #region Audio
                    
                    case "audio_new":
                        await _audioAdded.InvokeAsync(this, new AudioAddedEventArgs(payload.Object));
                        break;
                    
                    #endregion
                    
                    #region Video
                    
                    case "video_new":
                        await _videoAdded.InvokeAsync(this, new VideoAddedEventArgs(payload.Object));
                        break;
                    
                    case "video_comment_new":
                        await _videoCommentCreated.InvokeAsync(this, new VideoCommentCreatedEventArgs(payload.Object));
                        break;
                    
                    case "video_comment_edit":
                        await _videoCommentEdited.InvokeAsync(this, new VideoCommentEditedEventArgs(payload.Object));
                        break;
                    
                    case "video_comment_restore":
                        await _videoCommentRestored.InvokeAsync(this, new VideoCommentRestoredEventArgs(payload.Object));
                        break;
                    
                    case "video_comment_delete":
                        await _videoCommentDeleted.InvokeAsync(this, new VideoCommentDeletedEventArgs(payload.Object));
                        break;
                    
                    #endregion
                    
                    #region Group
                    case "group_join":
                        await _groupMemberJoined.InvokeAsync(this, new GroupMemberJoinedEventArgs(payload.Object));
                        break;
                    
                    case "group_leave":
                        await _groupMemberLeft.InvokeAsync(this, new GroupMemberLeftEventArgs(payload.Object));
                        break;
                    
                    case "user_block":
                        await _userBlacklisted.InvokeAsync(this, new GroupUserBlacklistedEventArgs(payload.Object));
                        break;
                    
                    case "user_unblock":
                        await _userUnblacklisted.InvokeAsync(this, new GroupUserUnblacklistedEventArgs(payload.Object));
                        break;
                    
                    case "group_officers_edit":
                        await _groupOfficerEdited.InvokeAsync(this, new GroupOfficerEditedEventArgs(payload.Object));
                        break;
                    
                    case "group_change_photo":
                        await _groupPhotoChanged.InvokeAsync(this, new GroupPhotoChangedEventArgs(payload.Object));
                        break;
                    #endregion

                    #region Donut
                    case "donut_subscription_create":
                        await _donutSubscriptionCreated.InvokeAsync(this, new DonutSubscriptionCreatedEventArgs(payload.Object));
                        break;
                    
                    case "donut_subscription_prolonged":
                        await _donutSubscriptionProlonged.InvokeAsync(this, new DonutSubscriptionProlongedEventArgs(payload.Object));
                        break;
                    
                    case "donut_subscription_expired":
                        await _donutSubscriptionExpired.InvokeAsync(this, new DonutSubscriptionExpiredEventArgs(payload.Object));
                        break;
                    
                    case "donut_subscription_cancelled":
                        await _donutSubscriptionCancelled.InvokeAsync(this, new DonutSubscriptionCancelledEventArgs(payload.Object));
                        break;
                    
                    case "donut_subscription_price_changed":
                        await _donutSubscriptionPriceChanged.InvokeAsync(this, new DonutSubscriptionPriceChangedEventArgs(payload.Object));
                        break;
                    
                    case "donut_money_withdraw":
                        await _donutMoneyWithdrawn.InvokeAsync(this, new DonutMoneyWithdrawnEventArgs(payload.Object));
                        break;
                    
                    case "donut_money_withdraw_error":
                        await _donutMoneyWithdrawErrored.InvokeAsync(this, new DonutMoneyWithdrawErroredEventArgs(payload.Object));
                        break;
                    #endregion
                    
                    
                    case "like_add":
                        await _likeAdded.InvokeAsync(this, new LikeAddedEventArgs(payload.Object));
                        break;

                    case "like_remove":
                        await _likeRemoved.InvokeAsync(this, new LikeRemovedEventArgs(payload.Object));
                        break;
                    
                    case "vkpay_transaction":
                        await _vkPayTransaction.InvokeAsync(this, new VkPayTransactionEventArgs(payload.Object));
                        break;
                    
                    case "app_payload":
                        await _appPayloadReceived.InvokeAsync(this, new AppPayloadReceivedEventArgs(payload.Object));
                        break;
                    
                    case "poll_vote_new":
                        await _pollVoteCreated.InvokeAsync(this, new PollVoteCreatedEventArgs(payload.Object));
                        break;
                    
                    default:
                        Console.WriteLine(payload.Type + " | " + payload.Object.ToString());
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            return "ok";
        }
    }
}