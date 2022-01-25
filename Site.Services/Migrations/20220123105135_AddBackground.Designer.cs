﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Site.Services;

namespace Site.Services.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20220123105135_AddBackground")]
    partial class AddBackground
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Site.Models.HeadModel", b =>
                {
                    b.Property<Guid>("HeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Canonical")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastReviewed")
                        .HasColumnType("date");

                    b.Property<long>("PageNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeadId");

                    b.ToTable("HeadModels");
                });

            modelBuilder.Entity("Site.Models.ImageModel", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageCaption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageContentUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ImageName")
                        .IsUnique();

                    b.ToTable("ImageModels");
                });

            modelBuilder.Entity("Site.Models.PageModel", b =>
                {
                    b.Property<Guid>("PageModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HeadModelHeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImageModelImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LeftBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PageNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("RightBackground")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageModelId");

                    b.HasIndex("HeadModelHeadId");

                    b.HasIndex("ImageModelImageId");

                    b.ToTable("PageModels");
                });

            modelBuilder.Entity("Site.Models.PageModel", b =>
                {
                    b.HasOne("Site.Models.HeadModel", "HeadModel")
                        .WithMany()
                        .HasForeignKey("HeadModelHeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Site.Models.ImageModel", "ImageModel")
                        .WithMany()
                        .HasForeignKey("ImageModelImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadModel");

                    b.Navigation("ImageModel");
                });
#pragma warning restore 612, 618
        }
    }
}
