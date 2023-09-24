﻿// <auto-generated />
using System;
using ITI_Project_withDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITI_Project_withDB.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20230924074048_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ITI_Project_withDB.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FullMark")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PassMark")
                        .HasColumnType("int");

                    b.Property<int?>("ins_Id")
                        .HasColumnType("int");

                    b.Property<int?>("totalHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ins_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.StudentCourse", b =>
                {
                    b.Property<int>("Std_id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_id")
                        .HasColumnType("int");

                    b.Property<int?>("grade")
                        .HasColumnType("int");

                    b.HasKey("Std_id", "Crs_id");

                    b.HasIndex("Crs_id");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Course", b =>
                {
                    b.HasOne("ITI_Project_withDB.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("ins_Id");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.StudentCourse", b =>
                {
                    b.HasOne("ITI_Project_withDB.Models.Course", "Course")
                        .WithMany("studentCourses")
                        .HasForeignKey("Crs_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITI_Project_withDB.Models.Student", "Student")
                        .WithMany("studentCourses")
                        .HasForeignKey("Std_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Course", b =>
                {
                    b.Navigation("studentCourses");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ITI_Project_withDB.Models.Student", b =>
                {
                    b.Navigation("studentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
