// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using NetKit.Chat.Client.SDK.REST.Enums;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Message
{
   public class AddMessageRequest
    {
        public Guid ChannelId { get; set; }

        public string Body { get; set; }

        public MessageType Type { get; set; }

        // If Message type is Notification
        public string ImageUrl { get; set; }

        // If Message type is Forward
        public Guid ForwardedMessageId { get; set; }
    }
}
