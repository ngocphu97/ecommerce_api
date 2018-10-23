using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Interfaces;

namespace ThuongMaiDienTuAPI.Helpers
{
    public class Paging<T>
    {
        public static IQueryable<T> Get(IQueryable<T> query,IPaging page)
        {
            return query.Skip(page.PageSize * (page.Page - 1)).Take(page.PageSize);
        }
    }
}
