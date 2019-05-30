// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.MessageAttachment
{
    public class DeleteMessageAttachmentRequest
    {
        public Guid MessageId { get; set; }

        public Guid AttachmentId { get; set; }
    }
}
