using Microsoft.EntityFrameworkCore;
using TNTT.CMS.Models.Entities;

namespace TNTT.UserApi.Data
{
    public class TNContext : DbContext
    {
        public TNContext(DbContextOptions options) : base(options) { }
        public DbSet<XuDoan> XuDoan
        {
            get;
            set;
        }
        public DbSet<HiepDoan> HiepDoan
        {
            get;
            set;
        }
        public DbSet<LienDoan> LienDoan
        {
            get;
            set;
        }
        public DbSet<TongLienDoan> TongLienDoan
        {
            get;
            set;
        }
        public DbSet<Users> Profile
        {
            get;
            set;
        }
        public DbSet<KetQuaHocTap> KetQuaHocTap
        {
            get;
            set;
        }
        public DbSet<MonHoc> MonHoc
        {
            get;
            set;
        }
        public DbSet<LopHoc> LopHoc
        {
            get;
            set;
        }
        public DbSet<Role> Role
        {
            get;
            set;
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Users>()
                .HasIndex(u => u.PIN)
                .IsUnique();
        }
    }
}
