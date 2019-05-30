// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace NetKit.Chat.Client.SDK.REST.Models.CommonModels.Request.Member
{
    public class GetPotentialChannelMembersRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string NameFilter { get; set; }
    }
}
