// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Request.Member
{
    public class GetPotentialChannelMembersRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string NameFilter { get; set; }
    }
}
