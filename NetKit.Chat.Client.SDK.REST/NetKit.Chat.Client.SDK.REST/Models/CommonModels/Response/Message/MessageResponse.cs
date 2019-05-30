// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using Softeq.NetKit.Chat.Client.SDK.REST.Enums;
using Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Member;
using Softeq.NetKit.Chat.Client.SDK.REST.Models.Visitors.Localization;

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Message
{
    public class MessageResponse : LocalizedMessageResponse<MessageResponse>
    {
        public Guid Id { get; set; }
        public Guid ChannelId { get; set; }
        public MemberSummaryResponse Sender { get; set; }
        public string Body { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public MessageType Type { get; set; }
        public bool IsRead { get; set; }
        public string ImageUrl { get; set; }
        public ForwardMessageResponse ForwardedMessage { get; set; }
        public ChannelType ChannelType { get; set; }

        public override void Accept(ILocalizationVisitor<MessageResponse> visitor)
        {
            visitor.Visit(this);
        }
    }
}
