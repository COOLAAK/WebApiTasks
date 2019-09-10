﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiTasks.DataBase;

namespace WebApiTasks.Migrations
{
    [DbContext(typeof(JobsContext))]
    partial class JobsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiTasks.DataBase.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Jobid");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("Jobid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApiTasks.DataBase.Model.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeadLine");

                    b.Property<string>("Description");

                    b.Property<int>("Priority");

                    b.Property<int>("StatusJob");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("WebApiTasks.DataBase.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("WebApiTasks.DataBase.Model.TagJob", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<int>("TagId");

                    b.HasKey("JobId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagJobs");
                });

            modelBuilder.Entity("WebApiTasks.DataBase.Model.Category", b =>
                {
                    b.HasOne("WebApiTasks.DataBase.Model.Job", "Job")
                        .WithMany("Categories")
                        .HasForeignKey("Jobid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApiTasks.DataBase.Model.TagJob", b =>
                {
                    b.HasOne("WebApiTasks.DataBase.Model.Job", "Job")
                        .WithMany("TagJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApiTasks.DataBase.Model.Tag", "Tag")
                        .WithMany("TagJobs")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
