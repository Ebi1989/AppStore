using System;

namespace Asp06Store.Framwork.Infra
{
    public class PageInfo
    {
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        
        public int PageNumber { get; set; }

        public int PageCount => (int)Math.Ceiling((decimal)TotalCount / PageSize);     
    }
}
