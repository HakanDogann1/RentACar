﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.DataAccessLayer.Concrete;

namespace RentACar.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230518071437_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.AboutUs", b =>
                {
                    b.Property<int>("AboutUsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutUsImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutUsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutUsID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogContentDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContentDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContentTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContentTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.BlogComment", b =>
                {
                    b.Property<int>("BlogCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogCommentEMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogCommentMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogCommentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogCommentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.HasKey("BlogCommentID");

                    b.HasIndex("BlogID");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.BlogWithTagCloud", b =>
                {
                    b.Property<int>("BlogWithTagCloudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("TagCloudID")
                        .HasColumnType("int");

                    b.HasKey("BlogWithTagCloudID");

                    b.HasIndex("BlogID");

                    b.HasIndex("TagCloudID");

                    b.ToTable("BlogWithTagClouds");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.ContactMe", b =>
                {
                    b.Property<int>("ContactMeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactMeImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactMeID");

                    b.ToTable("ContactMes");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Header", b =>
                {
                    b.Property<int>("HeaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeaderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderVideo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeaderID");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Reference", b =>
                {
                    b.Property<int>("ReferenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceID");

                    b.ToTable("References");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Reserve", b =>
                {
                    b.Property<int>("ReserveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DropOfDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DropOffLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PickUpTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PıckUpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PıckUpLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReserveID");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.ReserveService", b =>
                {
                    b.Property<int>("ReserveServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReserveServiceIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReserveServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReserveServiceID");

                    b.ToTable("ReserveServices");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.Statistic", b =>
                {
                    b.Property<int>("StatisticID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatisticTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatisticValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatisticID");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.TagCloud", b =>
                {
                    b.Property<int>("TagCloudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagCloudTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagCloudID");

                    b.ToTable("TagClouds");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.BlogComment", b =>
                {
                    b.HasOne("RentACar.EntityLayer.Concrete.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("RentACar.EntityLayer.Concrete.BlogWithTagCloud", b =>
                {
                    b.HasOne("RentACar.EntityLayer.Concrete.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACar.EntityLayer.Concrete.TagCloud", "TagCloud")
                        .WithMany()
                        .HasForeignKey("TagCloudID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("TagCloud");
                });
#pragma warning restore 612, 618
        }
    }
}
