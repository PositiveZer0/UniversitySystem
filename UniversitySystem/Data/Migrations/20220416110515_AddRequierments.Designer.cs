﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversitySystem.Data;

namespace UniversitySystem.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220416110515_AddRequierments")]
    partial class AddRequierments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Extension = "jpg",
                            Name = "AgrarenPU"
                        },
                        new
                        {
                            Id = 2,
                            Extension = "jpg",
                            Name = "AmtiiPU"
                        },
                        new
                        {
                            Id = 3,
                            Extension = "png",
                            Name = "AkademiqMVRSU"
                        },
                        new
                        {
                            Id = 4,
                            Extension = "png",
                            Name = "AUBG"
                        },
                        new
                        {
                            Id = 5,
                            Extension = "png",
                            Name = "BurgaskiSvobodenUni"
                        },
                        new
                        {
                            Id = 6,
                            Extension = "png",
                            Name = "VarnenskiSvobodenUniChernorizec"
                        },
                        new
                        {
                            Id = 7,
                            Extension = "png",
                            Name = "VTU"
                        },
                        new
                        {
                            Id = 8,
                            Extension = "png",
                            Name = "VoennomorskoUchilishteVaptsarov"
                        },
                        new
                        {
                            Id = 9,
                            Extension = "jpg",
                            Name = "VisheTransportnoKableshkov"
                        },
                        new
                        {
                            Id = 10,
                            Extension = "png",
                            Name = "VishteTransportnoPoAgrobiznesPu"
                        },
                        new
                        {
                            Id = 11,
                            Extension = "png",
                            Name = "VPZIFinansiSO"
                        },
                        new
                        {
                            Id = 12,
                            Extension = "png",
                            Name = "VPTIPoshtiSO"
                        },
                        new
                        {
                            Id = 13,
                            Extension = "jpg",
                            Name = "VisheLubenKaravelovSO"
                        },
                        new
                        {
                            Id = 14,
                            Extension = "jpg",
                            Name = "EuKolejIkonomikaPU"
                        },
                        new
                        {
                            Id = 15,
                            Extension = "png",
                            Name = "IkonomicheskiVarna"
                        },
                        new
                        {
                            Id = 16,
                            Extension = "jpg",
                            Name = "KolejPoIkonomikaIAdministraciq"
                        },
                        new
                        {
                            Id = 17,
                            Extension = "jpg",
                            Name = "LesotehnicheskiSO"
                        },
                        new
                        {
                            Id = 18,
                            Extension = "jpg",
                            Name = "MUVarna"
                        },
                        new
                        {
                            Id = 19,
                            Extension = "jpg",
                            Name = "MUPleven"
                        },
                        new
                        {
                            Id = 20,
                            Extension = "png",
                            Name = "MUPlovdiv"
                        },
                        new
                        {
                            Id = 21,
                            Extension = "png",
                            Name = "MUSO"
                        },
                        new
                        {
                            Id = 22,
                            Extension = "jpg",
                            Name = "MinnoGeolojkiIvanRilski"
                        },
                        new
                        {
                            Id = 23,
                            Extension = "gif",
                            Name = "NVULevski"
                        },
                        new
                        {
                            Id = 24,
                            Extension = "png",
                            Name = "NATFIZSO"
                        },
                        new
                        {
                            Id = 25,
                            Extension = "jpg",
                            Name = "MuzikalnaAkadPanchoVladigerov"
                        },
                        new
                        {
                            Id = 26,
                            Extension = "png",
                            Name = "NSASO"
                        },
                        new
                        {
                            Id = 27,
                            Extension = "png",
                            Name = "NHASO"
                        },
                        new
                        {
                            Id = 28,
                            Extension = "png",
                            Name = "NBUSO"
                        },
                        new
                        {
                            Id = 29,
                            Extension = "png",
                            Name = "PaisiiHilendarskiPU"
                        },
                        new
                        {
                            Id = 30,
                            Extension = "jpg",
                            Name = "RusenskiUniversitet"
                        },
                        new
                        {
                            Id = 31,
                            Extension = "png",
                            Name = "Sofiiski"
                        },
                        new
                        {
                            Id = 32,
                            Extension = "png",
                            Name = "StopanskaSvishtov"
                        },
                        new
                        {
                            Id = 33,
                            Extension = "png",
                            Name = "TUSO"
                        },
                        new
                        {
                            Id = 34,
                            Extension = "png",
                            Name = "TUVarna"
                        },
                        new
                        {
                            Id = 35,
                            Extension = "png",
                            Name = "TUGAB"
                        },
                        new
                        {
                            Id = 36,
                            Extension = "jpg",
                            Name = "TrakiiskiUni"
                        },
                        new
                        {
                            Id = 37,
                            Extension = "png",
                            Name = "AsenZlatarovBurgas"
                        },
                        new
                        {
                            Id = 38,
                            Extension = "png",
                            Name = "UNSS"
                        },
                        new
                        {
                            Id = 39,
                            Extension = "png",
                            Name = "UASGSO"
                        },
                        new
                        {
                            Id = 40,
                            Extension = "jpg",
                            Name = "BITSO"
                        },
                        new
                        {
                            Id = 41,
                            Extension = "png",
                            Name = "UHTSO"
                        },
                        new
                        {
                            Id = 42,
                            Extension = "png",
                            Name = "HTMUSO"
                        },
                        new
                        {
                            Id = 43,
                            Extension = "png",
                            Name = "Shumen"
                        },
                        new
                        {
                            Id = 44,
                            Extension = "jpg",
                            Name = "UgozapadenBlagoevgrad"
                        });
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MinimumScore")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Матура по български език"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Свободноизбираема матура"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Оценка по български език"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Втора оценка по избираем предмет"
                        });
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.UserSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSubjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Speciality", b =>
                {
                    b.HasOne("UniversitySystem.Data.Models.University", "University")
                        .WithMany("Specialities")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Subject", b =>
                {
                    b.HasOne("UniversitySystem.Data.Models.Speciality", null)
                        .WithMany("Subjects")
                        .HasForeignKey("SpecialityId");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.University", b =>
                {
                    b.HasOne("UniversitySystem.Data.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.UserSubject", b =>
                {
                    b.HasOne("UniversitySystem.Data.Models.Subject", "Subject")
                        .WithMany("UserSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Speciality", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.Subject", b =>
                {
                    b.Navigation("UserSubjects");
                });

            modelBuilder.Entity("UniversitySystem.Data.Models.University", b =>
                {
                    b.Navigation("Specialities");
                });
#pragma warning restore 612, 618
        }
    }
}
