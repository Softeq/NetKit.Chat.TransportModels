// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Channel
{
    public class CreateDirectChannelRequest
    {
        public Guid MemberId { get; set; }

       // Need to discuss
       // public ChannelType Type { get; } = ChannelType.Direct;
    }
}
