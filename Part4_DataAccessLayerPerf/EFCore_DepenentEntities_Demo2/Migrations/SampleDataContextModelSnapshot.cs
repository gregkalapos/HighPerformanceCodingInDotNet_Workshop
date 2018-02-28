﻿// <auto-generated />
using EFCore_DepenentEntities_Demo2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFCore_DepenentEntities_Demo2.Migrations
{
    [DbContext(typeof(SampleDataContext))]
    partial class SampleDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore_DepenentEntities_Demo2.Data.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EFCore_DepenentEntities_Demo2.Data.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastLogin");

                    b.Property<string>("LastName");

                    b.Property<string>("MidName");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCore_DepenentEntities_Demo2.Data.Comment", b =>
                {
                    b.HasOne("EFCore_DepenentEntities_Demo2.Data.UserData", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}