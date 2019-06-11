// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Client
{
   public class DeleteClientRequest : BaseRequest
    {
        public DeleteClientRequest(string clientConnectionId)
        {
            ClientConnectionId = clientConnectionId;
        }

        public string ClientConnectionId { get; }
    }
}
