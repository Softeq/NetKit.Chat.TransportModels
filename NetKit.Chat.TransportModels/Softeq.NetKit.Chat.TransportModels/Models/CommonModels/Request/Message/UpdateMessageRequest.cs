﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Message
{
    public class UpdateMessageRequest : BaseRequest
    {
        public Guid MessageId { get; set; }
        public string Body { get; set; }
    }
}
