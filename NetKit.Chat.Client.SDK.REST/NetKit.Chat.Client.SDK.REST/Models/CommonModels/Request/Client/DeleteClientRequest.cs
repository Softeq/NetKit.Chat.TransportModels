// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Client
{
   public class DeleteClientRequest
    {
        public DeleteClientRequest(string clientConnectionId)
        {
            ClientConnectionId = clientConnectionId;
        }

        public string ClientConnectionId { get; }
    }
}
