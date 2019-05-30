// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Message
{
    public class SetLastReadMessageRequest
    {
        public Guid MessageId { get; set; }

        public Guid ChannelId { get; set; }
    }
}
