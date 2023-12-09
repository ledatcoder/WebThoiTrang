﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebThoiTrang.DataAccess.Data;

#nullable disable

namespace WebThoiTrang.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebThoiTrang.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Áo Sơ Mi"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Áo Polo Thể Thao"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Áo Len Nam"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Áo Len Nữ"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Áo Polo Nam"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Váy Nữ"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
