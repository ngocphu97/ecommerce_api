using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuAPI.Interfaces;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Helpers;

namespace ThuongMaiDienTuAPI.Services
{
    public class SlideService : ISlideService
    {
        public DataContext db;
        public SlideService(DataContext db)
        {
            this.db = db;
        }
        public async Task<object> Get(SlideQuery query)
        {
            var slides = Sorting<Slide>.Get(Filtering(db.Slide,query),query);
            return new
            {
                Total = slides.Count(),
                Content = await Paging<Slide>.Get(slides, query).ToListAsync()
            };
        }
        private IQueryable<Slide> Filtering(IQueryable<Slide> slides, SlideQuery query)
        {
            if (query.TrangThai != null)
            {
                slides = slides.Where(x => x.TrangThai == query.TrangThai);
            }
            return slides;
        }
    }
}
