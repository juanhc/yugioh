﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YuGiOh.Infraestructure;

namespace YuGiOh.Infraestructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YuGiOh.Domain.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Archetype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlSmall")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardImage");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmazonPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("CardmarketPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EbayPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcgplayerPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardPrice");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("SetCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRarity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardSet");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardImage", b =>
                {
                    b.HasOne("YuGiOh.Domain.Card", null)
                        .WithMany("CardImages")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardPrice", b =>
                {
                    b.HasOne("YuGiOh.Domain.Card", null)
                        .WithMany("CardPrices")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YuGiOh.Domain.CardSet", b =>
                {
                    b.HasOne("YuGiOh.Domain.Card", null)
                        .WithMany("CardSets")
                        .HasForeignKey("CardId");
                });
#pragma warning restore 612, 618
        }
    }
}
