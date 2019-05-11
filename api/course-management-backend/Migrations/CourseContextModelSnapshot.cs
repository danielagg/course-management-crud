﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using course_management_backend.Contexts;

namespace course_management_backend.Migrations
{
    [DbContext(typeof(CourseContext))]
    partial class CourseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("course_management_backend.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AvailableOnTerm");

                    b.Property<int>("Credits");

                    b.Property<Guid>("DepartmentId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("NumberOfLecturesPerTerm");

                    b.Property<int?>("NumberOfSeminarsPerTerm");

                    b.Property<string>("RequirementsFromStudents")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<Guid>("ResponsibleId");

                    b.Property<int>("TypeOfExam");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ResponsibleId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = new Guid("46be3c38-b724-4839-b2bf-f09546964bad"),
                            AvailableOnTerm = 1,
                            Credits = 5,
                            DepartmentId = new Guid("7c9d3333-5cc0-43f5-aa21-728866a2ee27"),
                            Description = "Lorem ipsum of desc",
                            Name = "Course 1",
                            NumberOfLecturesPerTerm = 12,
                            NumberOfSeminarsPerTerm = 12,
                            RequirementsFromStudents = "Lorem ipsum of requirements",
                            ResponsibleId = new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"),
                            TypeOfExam = 0
                        });
                });

            modelBuilder.Entity("course_management_backend.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c9d3333-5cc0-43f5-aa21-728866a2ee27"),
                            Name = "Comparative and Institutional Economics"
                        },
                        new
                        {
                            Id = new Guid("68e51555-e380-4480-a5dc-6a2e02a7dcdd"),
                            Name = "Macroeconomics"
                        },
                        new
                        {
                            Id = new Guid("8ab9328e-8907-468e-b645-216e2a022ee7"),
                            Name = "Microeconomics"
                        },
                        new
                        {
                            Id = new Guid("6c37a919-2594-46a0-be86-846335a29cc1"),
                            Name = "Labour Economis"
                        },
                        new
                        {
                            Id = new Guid("daf07f8b-99ce-42ee-a1d5-b04d67ddebcc"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("3dee701c-1b3f-4c7f-8bb1-61bd5e0eb4c9"),
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = new Guid("a8e1df92-033e-4982-8d22-868a16639fb8"),
                            Name = "Statistics"
                        },
                        new
                        {
                            Id = new Guid("c1822dd1-1e85-4aa0-ae2b-ec7c21333fe5"),
                            Name = "Economic Policy"
                        },
                        new
                        {
                            Id = new Guid("bb8e5865-ef25-429e-b3ae-d722b0578387"),
                            Name = "Mathematical Economics and Economic Analysis"
                        });
                });

            modelBuilder.Entity("course_management_backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"),
                            FirstName = "Brian",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("6dbc0233-38d4-448b-94c8-11cc1fd4f06b"),
                            FirstName = "Anthony",
                            LastName = "Grayer"
                        },
                        new
                        {
                            Id = new Guid("70afba3f-a19f-45b6-b121-356472de7efb"),
                            FirstName = "Jean",
                            LastName = "Ashford"
                        },
                        new
                        {
                            Id = new Guid("54874529-e36d-495c-8735-87d1c7cdf7a4"),
                            FirstName = "Michelle",
                            LastName = "Reed"
                        },
                        new
                        {
                            Id = new Guid("cea5bd97-667a-427b-8199-60bf6f9518a6"),
                            FirstName = "Dave",
                            LastName = "Cuellar"
                        },
                        new
                        {
                            Id = new Guid("5dc84764-ed2e-4426-8296-2445948dc8ee"),
                            FirstName = "Frances",
                            LastName = "Bouie"
                        },
                        new
                        {
                            Id = new Guid("16d3ffe1-fda0-4cb4-840a-ed3995b3c5f5"),
                            FirstName = "Howard",
                            LastName = "Clay"
                        },
                        new
                        {
                            Id = new Guid("5e8d97f6-d9f6-46e7-970c-4e3b34e60d40"),
                            FirstName = "Jennifer",
                            LastName = "Spahr"
                        },
                        new
                        {
                            Id = new Guid("c9a4875b-1683-421b-9368-02a62a74794a"),
                            FirstName = "Patrick",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("d9e10ed8-39ef-4af5-a634-6ed947e57c86"),
                            FirstName = "John",
                            LastName = "Haas"
                        },
                        new
                        {
                            Id = new Guid("bed2bdfc-4178-44df-af46-48130ea87ae8"),
                            FirstName = "Ethel",
                            LastName = "Stebbins"
                        },
                        new
                        {
                            Id = new Guid("4972a9da-f532-4e6b-9b36-e845f63f6cd1"),
                            FirstName = "Henry",
                            LastName = "Arredondo"
                        },
                        new
                        {
                            Id = new Guid("9ee180e4-ee42-40c1-8f8b-dd6f95136108"),
                            FirstName = "Roseann",
                            LastName = "Hammel"
                        });
                });

            modelBuilder.Entity("course_management_backend.Models.Course", b =>
                {
                    b.HasOne("course_management_backend.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("course_management_backend.Models.User", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}