﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wildcatMicroFund.Data;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("wildcatMicroFund.Models.AdminReviewApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationStatusId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("StatusId");

                    b.ToTable("AdminReviewApplication");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppStatus")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ApplicationStatus", b =>
                {
                    b.Property<int>("AppStat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppStat"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AppStat");

                    b.ToTable("ApplicationStatus");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Availability", b =>
                {
                    b.Property<int>("AvailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailID"), 1L, 1);

                    b.Property<DateTime>("AvailEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AvailID");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Award", b =>
                {
                    b.Property<int>("AwardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwardId"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<double>("AwardAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("AwardDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AwardTypeID")
                        .HasColumnType("int");

                    b.Property<bool>("WasRecieved")
                        .HasColumnType("bit");

                    b.HasKey("AwardId");

                    b.ToTable("Award");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.AwardType", b =>
                {
                    b.Property<int>("AwardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwardTypeId"), 1L, 1);

                    b.Property<string>("AwardTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AwardTypeId");

                    b.ToTable("AwardType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Document", b =>
                {
                    b.Property<int>("DocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocID"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<string>("DocFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.DocumentType", b =>
                {
                    b.Property<int>("DocTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocTypeID"), 1L, 1);

                    b.Property<string>("DocTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocTypeID");

                    b.ToTable("DocumentType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Note", b =>
                {
                    b.Property<int>("NoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteID"), 1L, 1);

                    b.Property<string>("NoteContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoteCreator")
                        .HasColumnType("int");

                    b.Property<bool>("NoteInternal")
                        .HasColumnType("bit");

                    b.Property<int>("NoteVisibility")
                        .HasColumnType("int");

                    b.HasKey("NoteID");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.NoteType", b =>
                {
                    b.Property<int>("NoteTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteTypeID"), 1L, 1);

                    b.Property<string>("NoteTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoteTypeID");

                    b.ToTable("NoteType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.PitchEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("PitchEventDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PitchEvent");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.PitchEventApplication", b =>
                {
                    b.Property<int>("PitchEvAppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PitchEvAppID"), 1L, 1);

                    b.Property<int>("PitchID")
                        .HasColumnType("int");

                    b.Property<int>("UserAppID")
                        .HasColumnType("int");

                    b.HasKey("PitchEvAppID");

                    b.ToTable("PitchEventApplication");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("QuestDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("QuestIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SurveyQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Response", b =>
                {
                    b.Property<int>("ResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResponseID"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<string>("Responses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SurveyQuestionID")
                        .HasColumnType("int");

                    b.HasKey("ResponseID");

                    b.ToTable("Response");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ReviewApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationStatusId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("StatusId");

                    b.ToTable("ReviewApplication");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Score", b =>
                {
                    b.Property<int>("ScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreID"), 1L, 1);

                    b.Property<int>("PitchEvAppID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.Property<string>("ScoreComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ScoreValue")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ScoreID");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"), 1L, 1);

                    b.Property<string>("StatusDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Survey", b =>
                {
                    b.Property<int>("SurveyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurveyID"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<int>("SurveyQID")
                        .HasColumnType("int");

                    b.Property<int>("SurveyTypeID")
                        .HasColumnType("int");

                    b.HasKey("SurveyID");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.SurveyQuestion", b =>
                {
                    b.Property<int>("SurveyQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurveyQuestionID"), 1L, 1);

                    b.Property<int>("QuestID")
                        .HasColumnType("int");

                    b.Property<int>("SurvID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SurveyQuestionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SurveyQuestionID");

                    b.ToTable("SurveyQuestion");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.SurveyType", b =>
                {
                    b.Property<int>("SurveyTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurveyTypeID"), 1L, 1);

                    b.Property<string>("SurveyTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurveyTypeID");

                    b.ToTable("SurveyType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("UserCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFirst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserSpanishPref")
                        .HasColumnType("bit");

                    b.Property<string>("UserState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStreet1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStreet2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.UserAssignment", b =>
                {
                    b.Property<int>("UserAppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAppID"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<int>("UserAppAssignType")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserAppID");

                    b.ToTable("UserAssignment");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.UserRole", b =>
                {
                    b.Property<int>("URID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("URID"), 1L, 1);

                    b.HasKey("URID");

                    b.ToTable("UserRole");
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

            modelBuilder.Entity("wildcatMicroFund.Models.AdminReviewApplication", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wildcatMicroFund.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Application");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ReviewApplication", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wildcatMicroFund.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Application");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
