// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Message
{
    public class SetLastReadMessageRequest : BaseRequest
    {
        public Guid MessageId { get; set; }

        public Guid ChannelId { get; set; }
    }
}
