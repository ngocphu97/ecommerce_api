using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Helpers
{
    public class GetResult
    {
        public int Total { get; set; }
        public object Content { get; set; }
        public GetResult(int total, object Content){
            this.Total = total;
            this.Content = Content;
        }
        public object Get()
        {
            return new
            {
                Total = this.Total,
                Content = this.Content
            };
        }
    }
}
