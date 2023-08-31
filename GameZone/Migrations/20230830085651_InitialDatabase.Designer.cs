﻿// <auto-generated />
using GameZone.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameZone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230830085651_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameZone.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Sport"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Racing"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Film"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Figting"
                        });
                });

            modelBuilder.Entity("GameZone.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceId"));

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeviceId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            DeviceName = "PlayStation"
                        },
                        new
                        {
                            DeviceId = 2,
                            DeviceName = "xbox"
                        },
                        new
                        {
                            DeviceId = 3,
                            DeviceName = "Nintendo Switch"
                        },
                        new
                        {
                            DeviceId = 4,
                            DeviceName = "PC"
                        });
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameZone.Models.GameDevice", b =>
                {
                    b.Property<int>("GameDeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameDeviceId"));

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("GameDeviceId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("GameId");

                    b.ToTable("GameDevices");
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.HasOne("GameZone.Models.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GameZone.Models.GameDevice", b =>
                {
                    b.HasOne("GameZone.Models.Device", "Devices")
                        .WithMany("Games")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameZone.Models.Game", "Games")
                        .WithMany("Devices")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Devices");

                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameZone.Models.Category", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameZone.Models.Device", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}