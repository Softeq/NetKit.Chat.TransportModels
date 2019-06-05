// Developed by Softeq Development Corporation
// http://www.softeq.com

using System.Collections.Generic;

namespace Softeq.NetKit.Chat.Client.SDK.Models.CommonModels.Response
{
    public class QueryResult<T>
    {
        public int TotalNumberOfPages { get; set; }
        public int TotalNumberOfItems { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
