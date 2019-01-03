﻿// <auto-generated />
using System;
using BookMenagement.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMenagement.DAL.Migrations
{
    [DbContext(typeof(BookMenagementContext))]
    [Migration("20181228161659_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMenagement.DAL.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName")
                        .HasMaxLength(150);

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<int?>("AuthorId");

                    b.Property<int?>("BookCategoryId");

                    b.Property<int?>("CurrencyId");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookCategoryId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<decimal>("DefaultRatio");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Surname")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.RecieptHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CostumerId");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("Id");

                    b.HasIndex("CostumerId");

                    b.ToTable("RecieptHeader");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.RecieptLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrencyId");

                    b.Property<int>("LineNo");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductIdId");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ProductIdId");

                    b.ToTable("RecieptLine");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.Author", b =>
                {
                    b.HasOne("BookMenagement.DAL.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.Book", b =>
                {
                    b.HasOne("BookMenagement.DAL.Model.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("BookMenagement.DAL.Model.BookCategory", "BookCategory")
                        .WithMany()
                        .HasForeignKey("BookCategoryId");

                    b.HasOne("BookMenagement.DAL.Model.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.RecieptHeader", b =>
                {
                    b.HasOne("BookMenagement.DAL.Model.Person", "Costumer")
                        .WithMany()
                        .HasForeignKey("CostumerId");
                });

            modelBuilder.Entity("BookMenagement.DAL.Model.RecieptLine", b =>
                {
                    b.HasOne("BookMenagement.DAL.Model.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookMenagement.DAL.Model.Book", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
