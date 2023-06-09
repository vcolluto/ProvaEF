﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaEF;

#nullable disable

namespace ProvaEF.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230421092925_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("FrequentedCoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsEnrolledStudentId")
                        .HasColumnType("int");

                    b.HasKey("FrequentedCoursesCourseId", "StudentsEnrolledStudentId");

                    b.HasIndex("StudentsEnrolledStudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("ProvaEF.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("ProvaEF.CourseImage", b =>
                {
                    b.Property<int>("CourseImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseImageId"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CourseImageId");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("course_image");
                });

            modelBuilder.Entity("ProvaEF.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("StudentId");

                    b.ToTable("review");
                });

            modelBuilder.Entity("ProvaEF.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("student_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("student");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("ProvaEF.Course", null)
                        .WithMany()
                        .HasForeignKey("FrequentedCoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaEF.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsEnrolledStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProvaEF.CourseImage", b =>
                {
                    b.HasOne("ProvaEF.Course", "Course")
                        .WithOne("CourseImage")
                        .HasForeignKey("ProvaEF.CourseImage", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ProvaEF.Review", b =>
                {
                    b.HasOne("ProvaEF.Student", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ProvaEF.Course", b =>
                {
                    b.Navigation("CourseImage")
                        .IsRequired();
                });

            modelBuilder.Entity("ProvaEF.Student", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
