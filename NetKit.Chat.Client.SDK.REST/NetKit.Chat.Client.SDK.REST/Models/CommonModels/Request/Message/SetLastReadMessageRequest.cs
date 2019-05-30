// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Message
{
    public class SetLastReadMessageRequest
    {
        public Guid MessageId { get; set; }

        public Guid ChannelId { get; set; }
    }
}
