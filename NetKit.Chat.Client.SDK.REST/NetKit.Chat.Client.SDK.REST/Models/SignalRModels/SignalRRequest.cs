// Developed by Softeq Development Corporation
// http://www.softeq.com

using Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request;

namespace Softeq.NetKit.Chat.Client.SDK.Models.SignalRModels
{
    public class SignalRRequest<T> where T : BaseRequest
    {
        public string RequestId { get; set; }
        public T Request { get; set; }
    }
}
