﻿// <auto-generated />
using System;
using DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB.Migrations
{
    [DbContext(typeof(HqrbContext))]
    partial class HqrbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Entity.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("desk_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Camera")
                        .HasColumnName("camera")
                        .HasColumnType("bit");

                    b.Property<short?>("DeskStatusLookupID")
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

                    b.HasKey("Id");

                    b.HasIndex("DeskStatusLookupID");

                    b.HasIndex("room_id");

                    b.ToTable("Desks");
                });

            modelBuilder.Entity("DB.Entity.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("order_id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("BookingStatusLookupID")
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

                    b.HasKey("Id");

                    b.HasIndex("BookingStatusLookupID");

                    b.HasIndex("desk_id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DB.Entity.Room", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DB.Entity.User", b =>
                {
                    b.Property<int>("Id")
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

                    b.Property<short?>("UserRoleLookupID")
                        .HasColumnType("smallint");

                    b.Property<int?>("desk_id")
                        .HasColumnType("int");

                    b.Property<short?>("positions_id")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<int?>("room_id")
                        .HasColumnType("int");

                    b.Property<int?>("work-plan_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasIndex("UserRoleLookupID");

                    b.HasIndex("desk_id");

                    b.HasIndex("positions_id");

                    b.HasIndex("room_id");

                    b.HasIndex("work-plan_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DB.Entity.UserPosition", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("position_id")
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("position_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DB.Entity.WorkPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("work-plan_id")
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
                        .HasColumnName("work-plan_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Priority")
                        .HasColumnName("priority")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("WorkPlans");
                });

            modelBuilder.Entity("DB.Entity.WorkingDaysCalendar", b =>
                {
                    b.Property<long>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("room_id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("DB.LookupTable.BookingStatusLookup", b =>
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

            modelBuilder.Entity("DB.LookupTable.UserRoleLookup", b =>
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
                        .HasForeignKey("DeskStatusLookupID");

                    b.HasOne("DB.Entity.Room", "Room")
                        .WithMany("Desks")
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DB.Entity.Order", b =>
                {
                    b.HasOne("DB.LookupTable.BookingStatusLookup", null)
                        .WithMany("Orders")
                        .HasForeignKey("BookingStatusLookupID");

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
                    b.HasOne("DB.LookupTable.UserRoleLookup", null)
                        .WithMany("Users")
                        .HasForeignKey("UserRoleLookupID");

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
                        .HasForeignKey("work-plan_id");
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
