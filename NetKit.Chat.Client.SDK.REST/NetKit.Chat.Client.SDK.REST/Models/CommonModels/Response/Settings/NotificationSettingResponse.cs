// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using NetKit.Chat.Client.SDK.REST.Enums;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Settings
{
   public class NotificationSettingResponse
    {
        public Guid MemberId { get; set; }
        public NotificationSettingValue IsChannelNotificationsDisabled { get; set; }
    }
}
