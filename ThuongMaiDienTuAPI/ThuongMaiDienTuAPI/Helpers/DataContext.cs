using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuAPI.Entities;
namespace ThuongMaiDienTuAPI.Helpers
{
    /// <summary>
    /// Connect database map entities
    /// </summary>
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> op) : base(op) { }
        public virtual DbSet<User> User{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
