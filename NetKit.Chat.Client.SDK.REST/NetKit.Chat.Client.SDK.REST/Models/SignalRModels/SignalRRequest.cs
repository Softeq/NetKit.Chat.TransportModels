// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.Client.SDK.REST.Models.SignalRModels
{
    public class SignalRRequest<T>
    {
        public string RequestId { get; set; }
        public T Request { get; set; }
    }
}
