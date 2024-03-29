﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;
using Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Response.Message;

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Response
{
   public class MessagesResult
    {
        public int? PageSize { get; set; }
        public IEnumerable<MessageResponse> Results { get; set; }
    }
}
