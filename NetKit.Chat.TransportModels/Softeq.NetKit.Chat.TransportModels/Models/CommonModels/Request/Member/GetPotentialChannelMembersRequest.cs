// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Member
{
    public class GetPotentialChannelMembersRequest : BaseRequest
    {
        public Guid ChannelId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string NameFilter { get; set; }
    }
}
