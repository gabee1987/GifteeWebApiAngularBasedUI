﻿// <auto-generated />
using GifteeWebApiAngularBasedUI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GifteeWebApiAngularBasedUI.Migrations
{
    [DbContext(typeof(GifteeDbContext))]
    [Migration("20180221095658_AddGifteeTables")]
    partial class AddGifteeTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FromMeToYou.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventName")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FromMeToYou.Models.EventGift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("GiftId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("GiftId");

                    b.ToTable("EventsGifts");
                });

            modelBuilder.Entity("FromMeToYou.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("StoreLink");

                    b.HasKey("Id");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("FromMeToYou.Models.GifteeEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("GifteeId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("GifteeId");

                    b.ToTable("GifteesEvents");
                });

            modelBuilder.Entity("FromMeToYou.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GiftId");

                    b.Property<int>("GifteeId");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.HasIndex("GifteeId");

                    b.ToTable("Whislists");
                });

            modelBuilder.Entity("GifteeWebApiAngularBasedUI.Models.Giftee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<string>("NickName")
                        .HasMaxLength(255);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Giftees");
                });

            modelBuilder.Entity("GifteeWebApiAngularBasedUI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FromMeToYou.Models.EventGift", b =>
                {
                    b.HasOne("FromMeToYou.Models.Event", "Event")
                        .WithMany("EventGifts")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FromMeToYou.Models.Gift", "Gift")
                        .WithMany("EventGifts")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FromMeToYou.Models.GifteeEvent", b =>
                {
                    b.HasOne("FromMeToYou.Models.Event", "Event")
                        .WithMany("GifteeEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GifteeWebApiAngularBasedUI.Models.Giftee", "Giftee")
                        .WithMany("GifteeEvents")
                        .HasForeignKey("GifteeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FromMeToYou.Models.Wishlist", b =>
                {
                    b.HasOne("FromMeToYou.Models.Gift", "Gift")
                        .WithMany("Wishlist")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GifteeWebApiAngularBasedUI.Models.Giftee", "Giftee")
                        .WithMany("Wishlist")
                        .HasForeignKey("GifteeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GifteeWebApiAngularBasedUI.Models.Giftee", b =>
                {
                    b.HasOne("GifteeWebApiAngularBasedUI.Models.User", "User")
                        .WithMany("Giftees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
