﻿// <auto-generated />
using System;
using CheckMyDropi.Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheckMyDropi.Api.Migrations
{
    [DbContext(typeof(DroppyContext))]
    [Migration("20200329170617_AddTimeStampMigration")]
    partial class AddTimeStampMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("CheckMyDropi.Api.Data.Entities.MaliciousLink", b =>
                {
                    b.Property<int>("IdMaliciousLink")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMaliciousLink");

                    b.ToTable("MaliciousLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
