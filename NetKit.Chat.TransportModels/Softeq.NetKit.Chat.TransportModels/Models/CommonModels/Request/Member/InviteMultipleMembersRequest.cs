// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using System.Collections.Generic;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Member
{
    public class InviteMultipleMembersRequest : BaseRequest
    {
        public InviteMultipleMembersRequest()
        {
            InvitedMembersIds = new List<Guid>();
        }

        public Guid ChannelId { get; set; }
        public List<Guid> InvitedMembersIds { get; set; }
    }
}
