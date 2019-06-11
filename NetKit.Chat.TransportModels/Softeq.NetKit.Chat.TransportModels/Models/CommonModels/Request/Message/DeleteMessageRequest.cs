// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Message
{
   public class DeleteMessageRequest : BaseRequest
    {
        public Guid MessageId { get; set; }
    }
}
