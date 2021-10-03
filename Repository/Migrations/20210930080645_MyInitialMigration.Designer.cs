﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210930080645_MyInitialMigration")]
    partial class MyInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.SportsBet", b =>
                {
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Competition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BetId");

                    b.ToTable("SportsBet");
                });
#pragma warning restore 612, 618
        }
    }
}