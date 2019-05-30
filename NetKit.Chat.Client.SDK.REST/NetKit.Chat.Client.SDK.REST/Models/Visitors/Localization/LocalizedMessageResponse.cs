// Developed by Softeq Development Corporation
// http://www.softeq.com

using Softeq.NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Localization;

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.Visitors.Localization
{
   public abstract class LocalizedMessageResponse<T> where T : class, new()
    {
        public LocalizationResponse Localization { get; set; }

        public abstract void Accept(ILocalizationVisitor<T> visitor);
    }
}
