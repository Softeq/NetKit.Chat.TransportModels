// Developed by Softeq Development Corporation
// http://www.softeq.com

namespace Softeq.NetKit.Chat.TransportModels.Models.CommonModels.Request.Member
{
    public class GetPotentialChannelMembersRequest : BaseRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string NameFilter { get; set; }
    }
}
