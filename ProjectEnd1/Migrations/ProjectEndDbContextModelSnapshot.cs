﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectEnd1.Data;

#nullable disable

namespace ProjectEnd1.Migrations
{
    [DbContext(typeof(ProjectEndDbContext))]
    partial class ProjectEndDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeptMasterEmpProfile", b =>
                {
                    b.Property<int>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<int>("EmpProfileEmpCode")
                        .HasColumnType("int");

                    b.HasKey("DeptMasterDeptCode", "EmpProfileEmpCode");

                    b.HasIndex("EmpProfileEmpCode");

                    b.ToTable("DeptMasterEmpProfile");
                });

            modelBuilder.Entity("ProjectEnd1.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("DeptMaster");
                });

            modelBuilder.Entity("ProjectEnd1.Models.EmpProfile", b =>
                {
                    b.Property<int>("EmpCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCode"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpCode");

                    b.ToTable("EmpProfile");
                });

            modelBuilder.Entity("DeptMasterEmpProfile", b =>
                {
                    b.HasOne("ProjectEnd1.Models.DeptMaster", null)
                        .WithMany()
                        .HasForeignKey("DeptMasterDeptCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectEnd1.Models.EmpProfile", null)
                        .WithMany()
                        .HasForeignKey("EmpProfileEmpCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
