// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using System.IO;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.MessageAttachment
{
    public class AddMessageAttachmentRequest
    {
        public Guid MessageId { get; set; }

        public Stream Content { get; set; }
    }
}
