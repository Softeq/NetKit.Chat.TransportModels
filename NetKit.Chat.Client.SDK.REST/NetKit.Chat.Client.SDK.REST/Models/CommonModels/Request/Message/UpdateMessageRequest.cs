// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Message
{
    public class UpdateMessageRequest
    {
        public Guid MessageId { get; set; }

        public string Body { get; set; }
    }
}
