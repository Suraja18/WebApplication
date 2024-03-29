﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eLearning.Data;

namespace eLearning.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230311063114_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eLearning.Models.Book_Writer", b =>
                {
                    b.Property<int>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int>("Writer_ID")
                        .HasColumnType("int");

                    b.HasKey("Book_ID", "Writer_ID");

                    b.HasIndex("Writer_ID");

                    b.ToTable("Book_Writers");
                });

            modelBuilder.Entity("eLearning.Models.Books", b =>
                {
                    b.Property<int>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Publishdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Book_ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("eLearning.Models.Writer", b =>
                {
                    b.Property<int>("Writer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Profilepic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Writer_ID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("eLearning.Models.Book_Writer", b =>
                {
                    b.HasOne("eLearning.Models.Books", "Books")
                        .WithMany("Book_Writer")
                        .HasForeignKey("Book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eLearning.Models.Writer", "Writer")
                        .WithMany("Book_Writer")
                        .HasForeignKey("Writer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("eLearning.Models.Books", b =>
                {
                    b.Navigation("Book_Writer");
                });

            modelBuilder.Entity("eLearning.Models.Writer", b =>
                {
                    b.Navigation("Book_Writer");
                });
#pragma warning restore 612, 618
        }
    }
}
