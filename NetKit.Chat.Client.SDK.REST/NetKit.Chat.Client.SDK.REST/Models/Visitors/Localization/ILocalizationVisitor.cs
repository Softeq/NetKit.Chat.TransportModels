// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace NetKit.Chat.Client.SDK.REST.Models.Visitors.Localization
{
    public interface ILocalizationVisitor<T> where T : class, new()
    {
        void Visit(T entity);
    }
}
