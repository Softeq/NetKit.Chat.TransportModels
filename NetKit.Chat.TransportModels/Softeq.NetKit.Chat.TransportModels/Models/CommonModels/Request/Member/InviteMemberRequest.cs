// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Member
{
    public class InviteMemberRequest : BaseRequest
    {
        public Guid ChannelId { get; set; }
        public Guid MemberId { get; set; }
    }
}
