﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using Softeq.NetKit.Chat.Client.SDK.REST.Enums;

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Channel
{
    public class CreateChannelRequest
    {
        public CreateChannelRequest()
        {
            AllowedMembers = new List<string>();
        }

        public string Name { get; set; }

        public ChannelType Type { get; set; }

        public string Description { get; set; }

        public string WelcomeMessage { get; set; }

        public List<string> AllowedMembers { get; set; }

        public string PhotoUrl { get; set; }
    }
}
