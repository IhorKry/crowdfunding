﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crowdfunding.Data;

namespace crowdfunding.Migrations
{
    [DbContext(typeof(CrowdfundingDbContext))]
    [Migration("20200316150452_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("crowdfunding.Models.Aim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FounderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SumToClose")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FounderId");

                    b.ToTable("Aims");
                });

            modelBuilder.Entity("crowdfunding.Models.Backer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("backers");
                });

            modelBuilder.Entity("crowdfunding.Models.Founder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Founders");
                });

            modelBuilder.Entity("crowdfunding.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AimId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("BackerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AimId");

                    b.HasIndex("BackerId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("crowdfunding.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BackerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FounderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("crowdfunding.Models.Aim", b =>
                {
                    b.HasOne("crowdfunding.Models.Founder", null)
                        .WithMany("Aims")
                        .HasForeignKey("FounderId");
                });

            modelBuilder.Entity("crowdfunding.Models.Transaction", b =>
                {
                    b.HasOne("crowdfunding.Models.Aim", "Aim")
                        .WithMany("TransactionHistory")
                        .HasForeignKey("AimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("crowdfunding.Models.Backer", "Backer")
                        .WithMany("TransactionHistory")
                        .HasForeignKey("BackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
