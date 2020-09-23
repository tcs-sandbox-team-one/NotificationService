﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotificationService.Database;

namespace NotificationService.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200906115933_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NotificationService.Database.Entities.notification", b =>
                {
                    b.Property<int>("NotificationsId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Message");

                    b.Property<string>("Status");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("NotificationsId");

                    b.ToTable("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
