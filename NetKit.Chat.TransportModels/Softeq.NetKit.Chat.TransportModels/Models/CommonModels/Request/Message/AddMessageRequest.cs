﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using Softeq.NetKit.Chat.TransportModels.Enums;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Message
{
   public class AddMessageRequest : BaseRequest
    {
        public Guid ChannelId { get; set; }

        public string ClientConnectionId { get; set; }

        public string Body { get; set; }

        public MessageType Type { get; set; }

        // If Message type is Notification
        public string ImageUrl { get; set; }

        // If Message type is Forward
        public Guid ForwardedMessageId { get; set; }
    }
}
