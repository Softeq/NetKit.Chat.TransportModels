﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Channel
{
    public class MuteChannelRequest
    {
        public Guid ChannelId { get; set; }
        public bool IsMuted { get; set; }
    }
}
