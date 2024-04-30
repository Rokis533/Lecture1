﻿// <auto-generated />
using JWTProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTProject.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20240424164201_Admin")]
    partial class Admin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JWTProject.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 9999,
                            PasswordHash = new byte[] { 194, 95, 197, 191, 132, 192, 0, 168, 62, 255, 87, 141, 53, 147, 12, 244, 104, 135, 220, 2, 134, 21, 71, 226, 63, 87, 207, 137, 52, 156, 45, 67, 168, 2, 175, 18, 65, 117, 71, 167, 30, 113, 74, 93, 57, 61, 19, 236, 138, 65, 203, 252, 193, 66, 27, 122, 63, 158, 242, 244, 157, 248, 95, 9 },
                            PasswordSalt = new byte[] { 135, 171, 12, 160, 54, 181, 240, 33, 15, 49, 33, 119, 168, 107, 206, 124, 111, 40, 36, 87, 151, 211, 176, 150, 156, 106, 138, 223, 168, 234, 192, 244, 165, 127, 35, 17, 110, 207, 103, 107, 39, 20, 161, 6, 202, 180, 174, 55, 177, 139, 141, 215, 107, 32, 233, 153, 152, 202, 70, 73, 182, 201, 48, 218, 162, 128, 37, 120, 195, 70, 10, 3, 79, 217, 134, 126, 70, 254, 199, 100, 245, 200, 104, 116, 137, 141, 9, 171, 202, 103, 81, 89, 197, 107, 58, 118, 113, 66, 201, 2, 242, 245, 62, 34, 246, 169, 199, 154, 141, 107, 214, 56, 234, 232, 8, 177, 34, 150, 174, 219, 191, 239, 99, 107, 74, 178, 104, 166 },
                            Role = "Admin",
                            Username = "Admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
