// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using Softeq.NetKit.Chat.Client.SDK.REST.Enums;

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Settings
{
   public class NotificationSettingResponse
    {
        public Guid MemberId { get; set; }
        public NotificationSettingValue IsChannelNotificationsDisabled { get; set; }
    }
}
