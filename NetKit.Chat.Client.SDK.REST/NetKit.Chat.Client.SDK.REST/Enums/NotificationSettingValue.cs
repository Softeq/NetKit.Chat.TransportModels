// Developed by Softeq Development Corporation
// http://www.softeq.com

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetKit.Chat.Client.SDK.REST.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationSettingValue
    {
        Enabled = 0,
        Disabled = 1
    }
}
