﻿// Developed for EPSON AMERICA INC. by Softeq Development Corporation
// http://www.softeq.com

using System;
using NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Channel;
using NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Member;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Message
{
   public class ForwardMessageResponse
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public Guid ChannelId { get; set; }
        public Guid? OwnerId { get; set; }
        public ChannelSummaryResponse Channel { get; set; }
        public MemberSummaryResponse Owner { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
