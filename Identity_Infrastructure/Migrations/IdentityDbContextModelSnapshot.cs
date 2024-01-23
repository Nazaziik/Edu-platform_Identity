﻿// <auto-generated />
using System;
using Identity_Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity_Infrastructure.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Identity_Domain.Entities.Additional.ClaimIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClaimsId")
                        .HasColumnType("int");

                    b.Property<int?>("IdentitiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaimsId");

                    b.HasIndex("IdentitiesId");

                    b.ToTable("ClaimIdentity");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Additional.ClaimRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClaimsId")
                        .HasColumnType("int");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaimsId");

                    b.HasIndex("RolesId");

                    b.ToTable("ClaimRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimsId = 1,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 2,
                            ClaimsId = 2,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 3,
                            ClaimsId = 3,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 4,
                            ClaimsId = 4,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 5,
                            ClaimsId = 5,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 6,
                            ClaimsId = 6,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 7,
                            ClaimsId = 7,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 8,
                            ClaimsId = 8,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 9,
                            ClaimsId = 9,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 10,
                            ClaimsId = 10,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 11,
                            ClaimsId = 11,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 12,
                            ClaimsId = 12,
                            RolesId = 1
                        },
                        new
                        {
                            Id = 13,
                            ClaimsId = 13,
                            RolesId = 1
                        });
                });

            modelBuilder.Entity("Identity_Domain.Entities.Additional.IdentityRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("IdentitiesId")
                        .HasColumnType("int");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdentitiesId");

                    b.HasIndex("RolesId");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdentitiesId = 1,
                            RolesId = 1
                        });
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Claim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ReadClaims"
                        },
                        new
                        {
                            Id = 2,
                            Name = "WriteClaim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ChangeClaim"
                        },
                        new
                        {
                            Id = 4,
                            Name = "DeleteClaim"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ReadRoles"
                        },
                        new
                        {
                            Id = 6,
                            Name = "WriteRole"
                        },
                        new
                        {
                            Id = 7,
                            Name = "ChangeRole"
                        },
                        new
                        {
                            Id = 8,
                            Name = "DeleteRole"
                        },
                        new
                        {
                            Id = 9,
                            Name = "ReadIdentities"
                        },
                        new
                        {
                            Id = 10,
                            Name = "ReadOwnIdentity"
                        },
                        new
                        {
                            Id = 11,
                            Name = "WriteIdentity"
                        },
                        new
                        {
                            Id = 12,
                            Name = "ChangeIdentity"
                        },
                        new
                        {
                            Id = 13,
                            Name = "DeleteIdentity"
                        });
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Identity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastLogout")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "eduplatform@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastLogout = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "0n2D6RfevH0iAO2odcm6QcsXPxSnTQMeT1VaCpVZ4qc=",
                            PasswordSalt = "GWJHabKuRfxzdRAMvdjGxQ==",
                            RegistrationDate = new DateTime(2024, 1, 11, 4, 23, 43, 492, DateTimeKind.Unspecified).AddTicks(5829),
                            Username = "superadmin"
                        });
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdentityId")
                        .HasColumnType("int");

                    b.Property<bool>("Invalidated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId")
                        .IsUnique();

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        });
                });

            modelBuilder.Entity("Identity_Domain.Entities.Additional.ClaimIdentity", b =>
                {
                    b.HasOne("Identity_Domain.Entities.Base.Claim", "Claims")
                        .WithMany("ClaimIdentity")
                        .HasForeignKey("ClaimsId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Identity_Domain.Entities.Base.Identity", "Identities")
                        .WithMany("ClaimIdentities")
                        .HasForeignKey("IdentitiesId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Claims");

                    b.Navigation("Identities");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Additional.ClaimRole", b =>
                {
                    b.HasOne("Identity_Domain.Entities.Base.Claim", "Claims")
                        .WithMany("ClaimRole")
                        .HasForeignKey("ClaimsId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Identity_Domain.Entities.Base.Role", "Roles")
                        .WithMany("ClaimRole")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Claims");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Additional.IdentityRole", b =>
                {
                    b.HasOne("Identity_Domain.Entities.Base.Identity", "Identities")
                        .WithMany("IdentityRole")
                        .HasForeignKey("IdentitiesId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Identity_Domain.Entities.Base.Role", "Roles")
                        .WithMany("IdentityRole")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Identities");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.RefreshToken", b =>
                {
                    b.HasOne("Identity_Domain.Entities.Base.Identity", "Identity")
                        .WithOne("Token")
                        .HasForeignKey("Identity_Domain.Entities.Base.RefreshToken", "IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identity");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Claim", b =>
                {
                    b.Navigation("ClaimIdentity");

                    b.Navigation("ClaimRole");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Identity", b =>
                {
                    b.Navigation("ClaimIdentities");

                    b.Navigation("IdentityRole");

                    b.Navigation("Token");
                });

            modelBuilder.Entity("Identity_Domain.Entities.Base.Role", b =>
                {
                    b.Navigation("ClaimRole");

                    b.Navigation("IdentityRole");
                });
#pragma warning restore 612, 618
        }
    }
}
