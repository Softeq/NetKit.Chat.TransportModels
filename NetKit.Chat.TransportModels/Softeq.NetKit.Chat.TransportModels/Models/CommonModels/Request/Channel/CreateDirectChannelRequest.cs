// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Channel
{
    public class CreateDirectChannelRequest : BaseRequest
    {
        public Guid MemberId { get; set; }
    }
}
