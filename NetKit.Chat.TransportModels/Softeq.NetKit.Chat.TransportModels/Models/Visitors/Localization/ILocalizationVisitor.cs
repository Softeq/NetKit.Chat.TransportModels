// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.TransportModels.Models.Visitors.Localization
{
    public interface ILocalizationVisitor<T> where T : class, new()
    {
        void Visit(T entity);
    }
}
