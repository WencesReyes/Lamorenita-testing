﻿// <auto-generated />
using System;
using Lamorenita.Data_Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lamorenita.Migrations
{
    [DbContext(typeof(LamorenitaDbContext))]
    partial class LamorenitaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lamorenita.Data_Entities.ContactDirectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("DirectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("DirectionId");

                    b.ToTable("ContactDirection");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ContactEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("SecondLastName")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.DirectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Colony")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Direction");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.PhoneNumberEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ProductTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreDirectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DirectionId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreDirection");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreManagerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreManager");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecondLastName")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ContactDirectionEntity", b =>
                {
                    b.HasOne("Lamorenita.Data_Entities.ContactEntity", "Contact")
                        .WithMany("ContactDirection")
                        .HasForeignKey("ContactId");

                    b.HasOne("Lamorenita.Data_Entities.DirectionEntity", "Direction")
                        .WithMany("ContactDirection")
                        .HasForeignKey("DirectionId");

                    b.Navigation("Contact");

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.PhoneNumberEntity", b =>
                {
                    b.HasOne("Lamorenita.Data_Entities.ContactEntity", "Contact")
                        .WithMany("PhoneNumber")
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ProductEntity", b =>
                {
                    b.HasOne("Lamorenita.Data_Entities.ProductTypeEntity", "ProductType")
                        .WithMany("Product")
                        .HasForeignKey("ProductTypeId");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreDirectionEntity", b =>
                {
                    b.HasOne("Lamorenita.Data_Entities.DirectionEntity", "Direction")
                        .WithMany("StoreDirection")
                        .HasForeignKey("DirectionId");

                    b.HasOne("Lamorenita.Data_Entities.StoreEntity", "Store")
                        .WithMany("StoreDirection")
                        .HasForeignKey("StoreId");

                    b.Navigation("Direction");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreManagerEntity", b =>
                {
                    b.HasOne("Lamorenita.Data_Entities.ContactEntity", "Contact")
                        .WithMany("StoreManager")
                        .HasForeignKey("ContactId");

                    b.HasOne("Lamorenita.Data_Entities.StoreEntity", "Store")
                        .WithMany("StoreManager")
                        .HasForeignKey("StoreId");

                    b.Navigation("Contact");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ContactEntity", b =>
                {
                    b.Navigation("ContactDirection");

                    b.Navigation("PhoneNumber");

                    b.Navigation("StoreManager");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.DirectionEntity", b =>
                {
                    b.Navigation("ContactDirection");

                    b.Navigation("StoreDirection");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.ProductTypeEntity", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lamorenita.Data_Entities.StoreEntity", b =>
                {
                    b.Navigation("StoreDirection");

                    b.Navigation("StoreManager");
                });
#pragma warning restore 612, 618
        }
    }
}
