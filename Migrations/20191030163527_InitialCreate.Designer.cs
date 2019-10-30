﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WOI;

namespace WOI.Migrations
{
    [DbContext(typeof(_databaseContext))]
    [Migration("20191030163527_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WOI.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bsc_start")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Del_qty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MRP_ctrlr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Release")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seq_no_")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("System_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Target_qty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
