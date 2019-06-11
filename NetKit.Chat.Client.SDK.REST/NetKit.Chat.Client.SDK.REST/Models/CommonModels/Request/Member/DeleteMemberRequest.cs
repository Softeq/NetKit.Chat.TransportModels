// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Member
{
    public class DeleteMemberRequest : BaseRequest
    {
        public Guid ChannelId { get; set; }

        public Guid MemberId { get; set; }
    }
}
