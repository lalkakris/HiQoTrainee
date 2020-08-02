﻿// <auto-generated />
using System;
using DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB.Migrations
{
    [DbContext(typeof(HqrbContext))]
    [Migration("20200801105116_UpdateUserEntity")]
    partial class UpdateUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Entity.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("desk_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Camera")
                        .HasColumnName("camera")
                        .HasColumnType("bit");

                    b.Property<short?>("DeskStatusLoockupID")
                        .HasColumnType("smallint");

                    b.Property<bool>("Headset")
                        .HasColumnName("headset")
                        .HasColumnType("bit");

                    b.Property<bool>("MacBook")
                        .HasColumnName("macBook")
                        .HasColumnType("bit");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("room_id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DeskStatusLoockupID");

                    b.HasIndex("room_id");

                    b.ToTable("Desks");
                });

            modelBuilder.Entity("DB.Entity.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("order_id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("BookingStatusLoockupID")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnName("date")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<int?>("desk_id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookingStatusLoockupID");

                    b.HasIndex("desk_id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DB.Entity.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("room_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Floor")
                        .HasColumnName("floor")
                        .HasColumnType("smallint");

                    b.Property<short>("MaxEmployees")
                        .HasColumnName("max_employees")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DB.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("user_email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PlanChangeDate")
                        .HasColumnName("date_of_change_plan")
                        .HasColumnType("datetime2");

                    b.Property<short>("Role")
                        .HasColumnType("smallint");

                    b.Property<short?>("UserRoleLoockupID")
                        .HasColumnType("smallint");

                    b.Property<int?>("desk_id")
                        .HasColumnType("int");

                    b.Property<short?>("positions_id")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<int?>("room_id")
                        .HasColumnType("int");

                    b.Property<int?>("workplan_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasAlternateKey("Email");

                    b.HasIndex("UserRoleLoockupID");

                    b.HasIndex("desk_id");

                    b.HasIndex("positions_id");

                    b.HasIndex("room_id");

                    b.HasIndex("workplan_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DB.Entity.UserPosition", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("position_id")
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("position_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DB.Entity.WorkPlan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("workplan_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DeskGuaranteed")
                        .HasColumnName("guaranteed_desk")
                        .HasColumnType("bit");

                    b.Property<byte>("MaxOfficeDay")
                        .HasColumnName("max_days_per_month")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MinOfficeDay")
                        .HasColumnName("min_days_per_month")
                        .HasColumnType("tinyint");

                    b.Property<string>("Plan")
                        .IsRequired()
                        .HasColumnName("workplan_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Priority")
                        .HasColumnName("priority")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("WorkPlans");
                });

            modelBuilder.Entity("DB.Entity.WorkingDaysCalendar", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("day_id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOff")
                        .HasColumnName("is_dayoff")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("WorkEndTime")
                        .HasColumnName("end_of_work")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("WorkStartTime")
                        .HasColumnName("start_of_work")
                        .HasColumnType("time");

                    b.Property<int?>("room_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("room_id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("DB.LookupTable.BookingStatusLoockup", b =>
                {
                    b.Property<short>("ID")
                        .HasColumnName("booking_status_id")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Booking_status");

                    b.HasData(
                        new
                        {
                            ID = (short)1,
                            Description = "Booked"
                        },
                        new
                        {
                            ID = (short)2,
                            Description = "Waiting"
                        },
                        new
                        {
                            ID = (short)3,
                            Description = "Cancelled"
                        },
                        new
                        {
                            ID = (short)4,
                            Description = "Rejected"
                        },
                        new
                        {
                            ID = (short)5,
                            Description = "Used"
                        });
                });

            modelBuilder.Entity("DB.LookupTable.DeskStatusLookup", b =>
                {
                    b.Property<short>("ID")
                        .HasColumnName("desks_status_id")
                        .HasColumnType("smallint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Desks_status");

                    b.HasData(
                        new
                        {
                            ID = (short)1,
                            Status = "Fixed"
                        },
                        new
                        {
                            ID = (short)2,
                            Status = "Available"
                        },
                        new
                        {
                            ID = (short)3,
                            Status = "Booked"
                        },
                        new
                        {
                            ID = (short)4,
                            Status = "Out of service"
                        });
                });

            modelBuilder.Entity("DB.LookupTable.UserRoleLoockup", b =>
                {
                    b.Property<short>("ID")
                        .HasColumnName("roles_id")
                        .HasColumnType("smallint");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnName("role_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = (short)1,
                            Role = "User"
                        },
                        new
                        {
                            ID = (short)2,
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("DB.Entity.Desk", b =>
                {
                    b.HasOne("DB.LookupTable.DeskStatusLookup", null)
                        .WithMany("Desks")
                        .HasForeignKey("DeskStatusLoockupID");

                    b.HasOne("DB.Entity.Room", "Room")
                        .WithMany("Desks")
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DB.Entity.Order", b =>
                {
                    b.HasOne("DB.LookupTable.BookingStatusLoockup", null)
                        .WithMany("Orders")
                        .HasForeignKey("BookingStatusLoockupID");

                    b.HasOne("DB.Entity.Desk", "Desk")
                        .WithMany("Orders")
                        .HasForeignKey("desk_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DB.Entity.User", b =>
                {
                    b.HasOne("DB.LookupTable.UserRoleLoockup", null)
                        .WithMany("Users")
                        .HasForeignKey("UserRoleLoockupID");

                    b.HasOne("DB.Entity.Desk", "Desk")
                        .WithMany("Users")
                        .HasForeignKey("desk_id");

                    b.HasOne("DB.Entity.UserPosition", "Position")
                        .WithMany("Users")
                        .HasForeignKey("positions_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Entity.Room", "Room")
                        .WithMany("Users")
                        .HasForeignKey("room_id");

                    b.HasOne("DB.Entity.WorkPlan", "WorkPlan")
                        .WithMany("Users")
                        .HasForeignKey("workplan_id");
                });

            modelBuilder.Entity("DB.Entity.WorkingDaysCalendar", b =>
                {
                    b.HasOne("DB.Entity.Room", "Room")
                        .WithMany("BookingCalendars")
                        .HasForeignKey("room_id");
                });
#pragma warning restore 612, 618
        }
    }
}
