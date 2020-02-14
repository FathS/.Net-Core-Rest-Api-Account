﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi.Models.Data;

namespace TestApi.Migrations
{
    [DbContext(typeof(PersonelContext))]
    partial class PersonelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApi.Models.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age");

                    b.Property<DateTime?>("ChangePassTime");

                    b.Property<string>("ConfirPassword");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Surname");

                    b.Property<bool?>("isActive");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName");

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.UserPassword", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ActivePassword");

                    b.Property<string>("ConfirmPassword");

                    b.Property<DateTime>("CreatedPassword");

                    b.Property<string>("Password");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserPassword");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("CityId");

                    b.Property<string>("Department");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<bool?>("IsActive");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.District", b =>
                {
                    b.HasOne("TestApi.Models.Data.Entities.City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestApi.Models.Data.Entities.Users", b =>
                {
                    b.HasOne("TestApi.Models.Data.Entities.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");

                    b.HasOne("TestApi.Models.Data.Entities.District", "District")
                        .WithMany("User")
                        .HasForeignKey("DistrictId");

                    b.HasOne("TestApi.Models.Data.Entities.Manager", "Manager")
                        .WithMany("Users")
                        .HasForeignKey("ManagerId");
                });
#pragma warning restore 612, 618
        }
    }
}
