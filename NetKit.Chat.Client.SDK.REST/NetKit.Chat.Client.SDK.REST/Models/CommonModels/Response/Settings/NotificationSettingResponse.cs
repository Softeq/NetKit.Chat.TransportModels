// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using Softeq.NetKit.Chat.Client.SDK.Enums;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Response.Settings
{
   public class NotificationSettingResponse
    {
        public Guid MemberId { get; set; }
        public NotificationSettingValue IsChannelNotificationsDisabled { get; set; }
    }
}
