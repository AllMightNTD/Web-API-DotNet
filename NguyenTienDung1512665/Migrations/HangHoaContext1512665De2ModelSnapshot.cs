﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenTienDung1512665.DbContexts;

#nullable disable

namespace NguyenTienDung1512665.Migrations
{
    [DbContext(typeof(HangHoaContext1512665De2))]
    partial class HangHoaContext1512665De2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NguyenTienDung1512665.Entities.Certification1512665De2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MaChungChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChungChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDonViCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certification1512665De2s");
                });

            modelBuilder.Entity("NguyenTienDung1512665.Entities.HangHoa1512665De2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHangHoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHangHoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangHoaContext1512665De2s");
                });

            modelBuilder.Entity("NguyenTienDung1512665.Entities.ItemsCertification1512665De2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificationId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CertificationId");

                    b.HasIndex("ItemId");

                    b.ToTable("itemsCertification1512665De2s2");
                });

            modelBuilder.Entity("NguyenTienDung1512665.Entities.ItemsCertification1512665De2", b =>
                {
                    b.HasOne("NguyenTienDung1512665.Entities.Certification1512665De2", "Certification")
                        .WithMany("ItemCertifications")
                        .HasForeignKey("CertificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NguyenTienDung1512665.Entities.HangHoa1512665De2", "Item")
                        .WithMany("ItemCertifications")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certification");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("NguyenTienDung1512665.Entities.Certification1512665De2", b =>
                {
                    b.Navigation("ItemCertifications");
                });

            modelBuilder.Entity("NguyenTienDung1512665.Entities.HangHoa1512665De2", b =>
                {
                    b.Navigation("ItemCertifications");
                });
#pragma warning restore 612, 618
        }
    }
}
