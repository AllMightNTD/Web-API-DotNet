using Microsoft.EntityFrameworkCore;
using NguyenTienDung1512665.Entities;

namespace NguyenTienDung1512665.DbContexts
{
    public class HangHoaContext1512665De2 : DbContext
    {
        public HangHoaContext1512665De2(DbContextOptions<HangHoaContext1512665De2> options) : base(options) { 
       
        }
        public DbSet<HangHoa1512665De2> HangHoaContext1512665De2s { get; set; }
        public DbSet<ItemsCertification1512665De2> itemsCertification1512665De2s2 { get; set; } 
        public DbSet<Certification1512665De2> Certification1512665De2s { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa quan hệ n - n giữa bảng Items và Certifications
            modelBuilder.Entity<ItemsCertification1512665De2>()
                .HasKey(ic => ic.Id);
            modelBuilder.Entity<ItemsCertification1512665De2>()
                .HasOne(ic => ic.Item)
                .WithMany(i => i.ItemCertifications)
                .HasForeignKey(ic => ic.ItemId);
            modelBuilder.Entity<ItemsCertification1512665De2>()
                .HasOne(ic => ic.Certification) 
                .WithMany(c => c.ItemCertifications)
                .HasForeignKey(ic => ic.CertificationId);
        }
    }
}
