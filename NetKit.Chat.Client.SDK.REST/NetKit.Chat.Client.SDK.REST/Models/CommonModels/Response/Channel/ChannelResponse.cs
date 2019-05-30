// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using Newtonsoft.Json;
using Softeq.NetKit.Chat.Client.SDK.REST.Enums;

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Channel
{
    public class ChannelResponse
    {
        public Guid Id { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public bool IsClosed { get; set; }
        public string Description { get; set; }
        public string WelcomeMessage { get; set; }
        public ChannelType Type { get; set; }

        [JsonIgnore]
        public Guid CreatorId { get; set; }

        public int MembersCount { get; set; }
        public string PhotoUrl { get; set; }
    }
}
