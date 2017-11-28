﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalesApi.DataContext.Contexts;
using System;

namespace SalesApi.DataContext.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20171122114548_AddSubArea")]
    partial class AddSubArea
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesApi.Models.Settings.DeliveryVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<int>("DistributionGroupId");

                    b.Property<int?>("DistributionGroupId1");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LegacyAreaId")
                        .HasMaxLength(10);

                    b.Property<int>("Order");

                    b.Property<int>("SalesType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("VehicleId");

                    b.Property<int?>("VehicleId1");

                    b.HasKey("Id");

                    b.HasIndex("DistributionGroupId");

                    b.HasIndex("DistributionGroupId1");

                    b.HasIndex("VehicleId");

                    b.HasIndex("VehicleId1");

                    b.HasIndex("SalesType", "VehicleId", "DistributionGroupId")
                        .IsUnique();

                    b.ToTable("DeliveryVehicles");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.DistributionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("No");

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("No")
                        .IsUnique();

                    b.ToTable("DistributionGroups");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.SubArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<int>("DeliveryVehicleId");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LegacySubAreaId")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DeliveryVehicleId");

                    b.ToTable("SubAreas");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Order");

                    b.Property<string>("Owner")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.DeliveryVehicle", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.DistributionGroup", "DistributionGroup")
                        .WithMany()
                        .HasForeignKey("DistributionGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Settings.DistributionGroup")
                        .WithMany("DeliveryVehicles")
                        .HasForeignKey("DistributionGroupId1");

                    b.HasOne("SalesApi.Models.Settings.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Settings.Vehicle")
                        .WithMany("DeliveryVehicles")
                        .HasForeignKey("VehicleId1");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.SubArea", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.DeliveryVehicle", "DeliveryVehicle")
                        .WithMany("SubAreas")
                        .HasForeignKey("DeliveryVehicleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
