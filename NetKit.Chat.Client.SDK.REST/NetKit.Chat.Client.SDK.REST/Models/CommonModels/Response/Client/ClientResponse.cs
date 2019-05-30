// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Response.Client
{
   public class ClientResponse
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public string ConnectionClientId { get; set; }
        public string UserName { get; set; }
        public string SaasUserId { get; set; }
    }
}
