﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exam.Models;

namespace exam.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("exam.Models.GetTogether", b =>
                {
                    b.Property<int>("GetTogetherId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JawnId");

                    b.Property<int>("UserId");

                    b.HasKey("GetTogetherId");

                    b.HasIndex("JawnId");

                    b.HasIndex("UserId");

                    b.ToTable("GetTogethers");
                });

            modelBuilder.Entity("exam.Models.Jawn", b =>
                {
                    b.Property<int>("JawnId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("JawnId");

                    b.HasIndex("UserId");

                    b.ToTable("Jawns");
                });

            modelBuilder.Entity("exam.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("exam.Models.GetTogether", b =>
                {
                    b.HasOne("exam.Models.Jawn", "ThisJawn")
                        .WithMany("Attendees")
                        .HasForeignKey("JawnId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("exam.Models.User", "JawnGoer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("exam.Models.Jawn", b =>
                {
                    b.HasOne("exam.Models.User", "Organizer")
                        .WithMany("MyJawns")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
