using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class QLQKOKDbContext : DbContext
    {
        public DbSet<Phong> Phong { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLQKOKConnection"].ConnectionString);
        }
    }
}
