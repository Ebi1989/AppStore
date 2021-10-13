using System.Collections.Generic;

namespace Asp06Store.Framwork.Infra
{
    public class PagedData<T>
    {
        public List<T> Data { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
