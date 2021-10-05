using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhanQuocKhanh.Models
{
    public partial class LTQLDb : DbContext

    {
        public LTQLDb() : base("name = LTQLDb")
        {
        }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSinhVien)
                .IsUnicode(false);
        }
    }
}