﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Response.MessageAttachment
{
   public class AttachmentResponse
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
        public Guid MessageId { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
