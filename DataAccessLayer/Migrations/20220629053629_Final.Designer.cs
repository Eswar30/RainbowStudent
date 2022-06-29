﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RainbowStudent;

namespace RainbowStudent.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    [Migration("20220629053629_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RainbowStudent.StudentRain", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Mathematics")
                        .HasColumnType("int");

                    b.Property<int>("Science")
                        .HasColumnType("int");

                    b.Property<int>("SocialScience")
                        .HasColumnType("int");

                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.Property<int>("Tamil")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
