// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Channel
{
    public class MuteChannelRequest : BaseRequest
    {
        public Guid ChannelId { get; set; }
        public bool IsMuted { get; set; }
    }
}
