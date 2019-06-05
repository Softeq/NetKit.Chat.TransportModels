// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Response.ChannelMember
{
    public class ChannelMemberResponse
    {
        public Guid MemberId { get; set; }
        public Guid ChannelId { get; set; }
        public bool IsMuted { get; set; }
        public bool IsPinned { get; set; }
        public Guid? LastReadMessageId { get; set; }
    }
}
