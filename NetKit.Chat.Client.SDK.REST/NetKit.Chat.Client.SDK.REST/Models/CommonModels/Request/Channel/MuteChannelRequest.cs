// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Channel
{
    public class MuteChannelRequest
    {
        public Guid ChannelId { get; set; }
        public bool IsMuted { get; set; }
    }
}
