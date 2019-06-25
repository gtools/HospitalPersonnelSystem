﻿// <auto-generated />
using System;
using HospitalPersonnelSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalPersonnelSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190625011324_insert")]
    partial class insert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComAdminDuty", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComAdminDuty");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComDegree", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComDegree");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComEducation", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComEducation");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComGender", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComGender");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComMarriage", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComMarriage");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComNation", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComNation");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComPolitical", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComPolitical");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComPost", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComPost");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionExtent", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComProfessionExtent");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionRegister", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComProfessionRegister");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionTitle", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("LevelCode");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.Property<Guid>("TypeCode");

                    b.HasKey("Code");

                    b.HasIndex("LevelCode");

                    b.HasIndex("TypeCode");

                    b.ToTable("ComProfessionTitle");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionTitleLevel", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComProfessionTitleLevel");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionTitleType", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComProfessionTitleType");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionType", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("ComProfessionType");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.HPSRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.HPSUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EmpCode");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EmpCode");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysContract", b =>
                {
                    b.Property<string>("EmpCode");

                    b.Property<Guid>("Code");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreateEmp");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Remark");

                    b.Property<string>("SN");

                    b.Property<int>("YearLimit");

                    b.HasKey("EmpCode");

                    b.ToTable("SysContract");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysDept", b =>
                {
                    b.Property<string>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("DeptName")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("DeptCode");

                    b.ToTable("SysDept");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysEducation", b =>
                {
                    b.Property<string>("EmpCode");

                    b.Property<DateTime?>("FirstDate");

                    b.Property<string>("FirstEducation");

                    b.Property<string>("FirstForm");

                    b.Property<string>("FirstSchool");

                    b.Property<string>("FirstSubject");

                    b.Property<int?>("FirstSys");

                    b.Property<DateTime?>("MaxDate");

                    b.Property<string>("MaxEducation");

                    b.Property<string>("MaxForm");

                    b.Property<string>("MaxSchool");

                    b.Property<string>("MaxSubject");

                    b.Property<int?>("MaxSys");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("SecondDate");

                    b.Property<string>("SecondEducation");

                    b.Property<string>("SecondForm");

                    b.Property<string>("SecondSchool");

                    b.Property<string>("SecondSubject");

                    b.Property<int?>("SecondSys");

                    b.HasKey("EmpCode");

                    b.ToTable("SysEducation");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysEmp", b =>
                {
                    b.Property<string>("EmpCode")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AdminDutyCode");

                    b.Property<int>("Age");

                    b.Property<string>("ArchivesNo");

                    b.Property<string>("BankCard");

                    b.Property<DateTime>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<Guid?>("ComPostCode");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreateEmp");

                    b.Property<Guid?>("DegreeCode");

                    b.Property<string>("DeptCode")
                        .IsRequired();

                    b.Property<Guid?>("EducationCode");

                    b.Property<DateTime?>("EducationDate");

                    b.Property<string>("EmpName")
                        .IsRequired();

                    b.Property<Guid>("GenderCode");

                    b.Property<DateTime?>("GraduationDate");

                    b.Property<string>("HomeAdd");

                    b.Property<int>("HospitalAge");

                    b.Property<DateTime>("HospitalDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("IdentityAdd");

                    b.Property<string>("IdentityCard")
                        .IsRequired();

                    b.Property<bool>("IsPost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("IsStop")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<Guid?>("MarriageCode");

                    b.Property<Guid>("NationCode");

                    b.Property<string>("NativePlace");

                    b.Property<string>("OldName");

                    b.Property<string>("OpenBank");

                    b.Property<string>("Photo");

                    b.Property<Guid>("PoliticalCode");

                    b.Property<DateTime?>("PoliticalDate");

                    b.Property<Guid>("PostCode");

                    b.Property<string>("Practice");

                    b.Property<DateTime?>("PracticeDate");

                    b.Property<Guid?>("ProfessionTitleCode");

                    b.Property<Guid?>("ProfessionTitleLevelCode");

                    b.Property<Guid?>("ProfessionTitleTypeCode");

                    b.Property<string>("PublicMoneyNo");

                    b.Property<string>("Remark");

                    b.Property<string>("School");

                    b.Property<string>("SchoolMajor");

                    b.Property<string>("SocialInsuranceNo");

                    b.Property<string>("Spell");

                    b.Property<string>("Telephone");

                    b.Property<Guid?>("TypeCode");

                    b.Property<int>("WorkAge");

                    b.Property<DateTime?>("WorkDate");

                    b.HasKey("EmpCode");

                    b.HasIndex("AdminDutyCode");

                    b.HasIndex("ComPostCode");

                    b.HasIndex("DegreeCode");

                    b.HasIndex("DeptCode");

                    b.HasIndex("EducationCode");

                    b.HasIndex("GenderCode");

                    b.HasIndex("MarriageCode");

                    b.HasIndex("NationCode");

                    b.HasIndex("PoliticalCode");

                    b.HasIndex("ProfessionTitleCode");

                    b.HasIndex("ProfessionTitleLevelCode");

                    b.HasIndex("ProfessionTitleTypeCode");

                    b.HasIndex("TypeCode");

                    b.ToTable("SysEmp");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysEmpType", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("SysEmpType");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysNavbar", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Action");

                    b.Property<string>("Area");

                    b.Property<string>("Controller");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.Property<Guid>("TypeCode");

                    b.HasKey("Code");

                    b.HasIndex("TypeCode");

                    b.ToTable("SysNavbar");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysNavbarType", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Spell");

                    b.HasKey("Code");

                    b.ToTable("SysNavbarType");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysProfessionInfo", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreateEmp");

                    b.Property<string>("EmpCode")
                        .IsRequired();

                    b.Property<DateTime?>("EngageDate");

                    b.Property<bool>("IsEngage")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("No1");

                    b.Property<string>("No2");

                    b.Property<string>("No3");

                    b.Property<string>("No4");

                    b.Property<string>("No5");

                    b.Property<Guid?>("ProfessionExtentCode");

                    b.Property<Guid?>("ProfessionRegisterCode");

                    b.Property<Guid?>("ProfessionTitleCode");

                    b.Property<Guid?>("ProfessionTitleLevelCode");

                    b.Property<Guid?>("ProfessionTitleTypeCode");

                    b.Property<Guid?>("ProfessionTypeCode");

                    b.Property<string>("ProfessionalName");

                    b.Property<string>("Remark");

                    b.Property<string>("TypeCode");

                    b.Property<DateTime>("UpDate");

                    b.HasKey("Code");

                    b.HasIndex("EmpCode");

                    b.HasIndex("ProfessionExtentCode");

                    b.HasIndex("ProfessionRegisterCode");

                    b.HasIndex("ProfessionTitleCode");

                    b.HasIndex("ProfessionTitleLevelCode");

                    b.HasIndex("ProfessionTitleTypeCode");

                    b.HasIndex("ProfessionTypeCode");

                    b.ToTable("SysProfessionInfo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.ComProfessionTitle", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleLevel", "ComProfessionTitleLevel")
                        .WithMany("ComProfessionTitles")
                        .HasForeignKey("LevelCode")
                        .HasConstraintName("FK_LevelCode_ComProfessionTitle")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleType", "ComProfessionTitleType")
                        .WithMany("ComProfessionTitles")
                        .HasForeignKey("TypeCode")
                        .HasConstraintName("FK_TypeCode_ComProfessionTitle")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.HPSUser", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.SysEmp", "SysEmp")
                        .WithMany()
                        .HasForeignKey("EmpCode");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysContract", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.SysEmp", "SysEmp")
                        .WithMany("SysContracts")
                        .HasForeignKey("EmpCode")
                        .HasConstraintName("FK_EmpCode_SysEmp_SysContract")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysEducation", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.SysEmp", "SysEmp")
                        .WithMany("SysEducations")
                        .HasForeignKey("EmpCode")
                        .HasConstraintName("FK_EmpCode_SysEmp_SysEducation")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysEmp", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.ComAdminDuty", "ComAdminDuty")
                        .WithMany("SysEmps")
                        .HasForeignKey("AdminDutyCode")
                        .HasConstraintName("FK_AdminDutyCode_ComAdminDuty_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.ComPost", "ComPost")
                        .WithMany("SysEmps")
                        .HasForeignKey("ComPostCode");

                    b.HasOne("HospitalPersonnelSystem.Models.ComDegree", "ComDegree")
                        .WithMany("SysEmps")
                        .HasForeignKey("DegreeCode")
                        .HasConstraintName("FK_DegreeCode_ComDegree_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.SysDept", "SysDept")
                        .WithMany("SysEmps")
                        .HasForeignKey("DeptCode")
                        .HasConstraintName("FK_DeptCode_SysDept_SysEmp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComEducation", "ComEducation")
                        .WithMany("SysEmps")
                        .HasForeignKey("EducationCode")
                        .HasConstraintName("FK_EducationCode_ComEducation_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.ComGender", "ComGender")
                        .WithMany("SysEmps")
                        .HasForeignKey("GenderCode")
                        .HasConstraintName("FK_GenderCode_ComGender_SysEmp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComMarriage", "ComMarriage")
                        .WithMany("SysEmps")
                        .HasForeignKey("MarriageCode")
                        .HasConstraintName("FK_MarriageCode_ComMarriage_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.ComNation", "ComNation")
                        .WithMany("SysEmps")
                        .HasForeignKey("NationCode")
                        .HasConstraintName("FK_NationCode_ComNation_SysEmp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComPolitical", "ComPolitical")
                        .WithMany("SysEmps")
                        .HasForeignKey("PoliticalCode")
                        .HasConstraintName("FK_PoliticalCode_ComPolitical_SysEmp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitle", "ComProfessionTitle")
                        .WithMany("SysEmps")
                        .HasForeignKey("ProfessionTitleCode")
                        .HasConstraintName("FK_PTCode_ComProfessionTitle_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleLevel", "ComProfessionTitleLevel")
                        .WithMany("SysEmps")
                        .HasForeignKey("ProfessionTitleLevelCode")
                        .HasConstraintName("FK_PTLCode_ComProfessionTitleLevel_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleType", "ComProfessionTitleType")
                        .WithMany("SysEmps")
                        .HasForeignKey("ProfessionTitleTypeCode")
                        .HasConstraintName("FK_PTTCode_ComProfessionTitleType_SysEmp");

                    b.HasOne("HospitalPersonnelSystem.Models.SysEmpType", "SysEmpType")
                        .WithMany("SysEmps")
                        .HasForeignKey("TypeCode")
                        .HasConstraintName("FK_TypeCode_SysEmpType_SysEmp");
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysNavbar", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.SysNavbarType", "SysNavbarType")
                        .WithMany("SysNavbars")
                        .HasForeignKey("TypeCode")
                        .HasConstraintName("FK_TypeCode_SysNavbarType_SysNavbar")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalPersonnelSystem.Models.SysProfessionInfo", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.SysEmp", "SysEmp")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("EmpCode")
                        .HasConstraintName("FK_EmpCode_SysEmp_SysProfessionInfo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionExtent", "ComProfessionExtent")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionExtentCode")
                        .HasConstraintName("FK_ExtentCode_Extent_SysProfessionInfo");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionRegister", "ComProfessionRegister")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionRegisterCode")
                        .HasConstraintName("FK_RegisterCode_Register_SysProfessionInfo");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitle", "ComProfessionTitle")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionTitleCode")
                        .HasConstraintName("FK_TitleCode_Title_SysProfessionInfo");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleLevel", "ComProfessionTitleLevel")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionTitleLevelCode")
                        .HasConstraintName("FK_LevelCode_TitleLevel_SysProfessionInfo");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionTitleType", "ComProfessionTitleType")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionTitleTypeCode")
                        .HasConstraintName("FK_TypeCode_TitleType_SysProfessionInfo");

                    b.HasOne("HospitalPersonnelSystem.Models.ComProfessionType", "ComProfessionType")
                        .WithMany("SysProfessionInfos")
                        .HasForeignKey("ProfessionTypeCode")
                        .HasConstraintName("FK_TypeCode_Type_SysProfessionInfo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.HPSRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.HPSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.HPSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.HPSRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalPersonnelSystem.Models.HPSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("HospitalPersonnelSystem.Models.HPSUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}