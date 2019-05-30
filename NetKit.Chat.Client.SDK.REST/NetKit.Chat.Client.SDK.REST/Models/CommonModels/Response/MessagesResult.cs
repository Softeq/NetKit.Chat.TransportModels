// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response.Message;

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Response
{
   public class MessagesResult
    {
        public int? PageSize { get; set; }
        public IEnumerable<MessageResponse> Results { get; set; }
    }
}
