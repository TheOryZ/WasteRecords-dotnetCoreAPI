﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;

#nullable disable

namespace WasteRecords.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WasteRecords.Core.Entities.KindOfWaste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("KindOfWastes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Konserve",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Unlu Mamüller",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Şaraplar",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            Description = "Et",
                            IsActive = false,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.ReceivingCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("ReceivingCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Çöp - Belediye",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hayvan Barınağı",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Geri Dönüşüm",
                            IsActive = false,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsUnicode(false)
                        .HasColumnType("ntext");

                    b.Property<string>("ContentLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("KindOfWasteId")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReceivingCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<int>("WasteTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KindOfWasteId");

                    b.HasIndex("ReceivingCompanyId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UnitId");

                    b.HasIndex("WasteTypeId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bahçelievler - İstanbul",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Bahçelievler Mağazası",
                            Phone = "0212 000 11 22"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Güneşli - İstanbul",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Güneşli Mağazası",
                            Phone = "0212 000 11 22"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Beşiktaş - İstanbul",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Beşiktaş Mağazası",
                            Phone = "0212 000 11 22"
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "KG",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Adet",
                            IsActive = false,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            IsActive = false,
                            IsDeleted = false,
                            Name = "John Doe",
                            Password = "YWRtaW4xMjNKb2huRG9lMjNAYXNkYXNkQEA="
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.WasteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("WasteTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Çöp",
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Barınak",
                            IsActive = false,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Record", b =>
                {
                    b.HasOne("WasteRecords.Core.Entities.KindOfWaste", "KindOfWaste")
                        .WithMany("Records")
                        .HasForeignKey("KindOfWasteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WasteRecords.Core.Entities.ReceivingCompany", "ReceivingCompany")
                        .WithMany("Records")
                        .HasForeignKey("ReceivingCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WasteRecords.Core.Entities.Store", "Store")
                        .WithMany("Records")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WasteRecords.Core.Entities.Unit", "Unit")
                        .WithMany("Records")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WasteRecords.Core.Entities.WasteType", "WasteType")
                        .WithMany("Records")
                        .HasForeignKey("WasteTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KindOfWaste");

                    b.Navigation("ReceivingCompany");

                    b.Navigation("Store");

                    b.Navigation("Unit");

                    b.Navigation("WasteType");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.KindOfWaste", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.ReceivingCompany", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Store", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.Unit", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("WasteRecords.Core.Entities.WasteType", b =>
                {
                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
