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
    [Migration("20220207205838_CardDeleteImageModel")]
    partial class CardDeleteImageModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Site.Models.CardModel", b =>
                {
                    b.Property<Guid>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CardBody")
                        .HasColumnType("bit");

                    b.Property<string>("CardLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CardMovie")
                        .HasColumnType("bit");

                    b.Property<string>("CardText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("CardModels");
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

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ImageName")
                        .IsUnique();

                    b.ToTable("ImageModels");
                });

            modelBuilder.Entity("Site.Models.MovieModel", b =>
                {
                    b.Property<Guid>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actor01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatePublished")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFamilyFriendly")
                        .HasColumnType("bit");

                    b.Property<string>("MovieCaption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("РroductionCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("MovieModels");
                });

            modelBuilder.Entity("Site.Models.SitemapModel", b =>
                {
                    b.Property<Guid>("SitemapModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Changefreq")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageModelImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyWords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lastmod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("LeftBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PageNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("RightBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SitemapModelId");

                    b.HasIndex("ImageModelImageId");

                    b.HasIndex("PageNumber")
                        .IsUnique();

                    b.ToTable("SitemapModels");
                });

            modelBuilder.Entity("Site.Models.SitemapModel", b =>
                {
                    b.HasOne("Site.Models.ImageModel", "ImageModel")
                        .WithMany()
                        .HasForeignKey("ImageModelImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImageModel");
                });
#pragma warning restore 612, 618
        }
    }
}
