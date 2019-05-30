// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using NetKit.Chat.Client.SDK.REST.Enums;
using NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Member;
using NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Message;
using Newtonsoft.Json;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Channel
{
    public class ChannelSummaryResponse
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public int UnreadMessagesCount { get; set; }
        public string Name { get; set; }
        public bool IsClosed { get; set; }
        public bool IsMuted { get; set; }
        public bool IsPinned { get; set; }
        [JsonIgnore]
        public Guid CreatorId { get; set; }

        public MemberSummaryResponse Creator { get; set; }
        [JsonIgnore]
        public Guid DirectMemberId { get; set; }
        public MemberSummaryResponse DirectMember { get; set; }
        [JsonIgnore]
        public string CreatorSaasUserId { get; set; }
        public string Description { get; set; }
        public string WelcomeMessage { get; set; }
        public ChannelType Type { get; set; }
        public MessageResponse LastMessage { get; set; }
        public string PhotoUrl { get; set; }
    }
}
