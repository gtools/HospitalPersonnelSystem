using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Migrations
{
    public partial class insert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComAdminDuty",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComAdminDuty", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComDegree",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComDegree", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComEducation",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComEducation", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComGender",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComGender", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComMarriage",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComMarriage", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComNation",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComNation", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComPolitical",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComPolitical", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComPost",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComPost", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionExtent",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionExtent", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionRegister",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionRegister", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionTitleLevel",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionTitleLevel", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionTitleType",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionTitleType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionType",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SysDept",
                columns: table => new
                {
                    DeptCode = table.Column<string>(nullable: false, defaultValueSql: "newid()"),
                    DeptName = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDept", x => x.DeptCode);
                });

            migrationBuilder.CreateTable(
                name: "SysEmpType",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEmpType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SysNavbarType",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysNavbarType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionTitle",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0),
                    TypeCode = table.Column<Guid>(nullable: false),
                    LevelCode = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionTitle", x => x.Code);
                    table.ForeignKey(
                        name: "FK_LevelCode_ComProfessionTitle",
                        column: x => x.LevelCode,
                        principalTable: "ComProfessionTitleLevel",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeCode_ComProfessionTitle",
                        column: x => x.TypeCode,
                        principalTable: "ComProfessionTitleType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysNavbar",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0),
                    TypeCode = table.Column<Guid>(nullable: false),
                    Controller = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysNavbar", x => x.Code);
                    table.ForeignKey(
                        name: "FK_TypeCode_SysNavbarType_SysNavbar",
                        column: x => x.TypeCode,
                        principalTable: "SysNavbarType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysEmp",
                columns: table => new
                {
                    EmpCode = table.Column<string>(nullable: false),
                    EmpName = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    DeptCode = table.Column<string>(nullable: false),
                    OldName = table.Column<string>(nullable: true),
                    GenderCode = table.Column<Guid>(nullable: false),
                    NationCode = table.Column<Guid>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    Age = table.Column<int>(nullable: false),
                    PoliticalCode = table.Column<Guid>(nullable: false),
                    PoliticalDate = table.Column<DateTime>(nullable: true),
                    IdentityCard = table.Column<string>(nullable: false),
                    ProfessionTitleTypeCode = table.Column<Guid>(nullable: true),
                    ProfessionTitleLevelCode = table.Column<Guid>(nullable: true),
                    ProfessionTitleCode = table.Column<Guid>(nullable: true),
                    AdminDutyCode = table.Column<Guid>(nullable: true),
                    IsPost = table.Column<bool>(nullable: false, defaultValue: true),
                    TypeCode = table.Column<Guid>(nullable: true),
                    WorkDate = table.Column<DateTime>(nullable: true),
                    HospitalDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    ArchivesNo = table.Column<string>(nullable: true),
                    PublicMoneyNo = table.Column<string>(nullable: true),
                    SocialInsuranceNo = table.Column<string>(nullable: true),
                    PostCode = table.Column<Guid>(nullable: false),
                    ComPostCode = table.Column<Guid>(nullable: true),
                    WorkAge = table.Column<int>(nullable: false),
                    HospitalAge = table.Column<int>(nullable: false),
                    Practice = table.Column<string>(nullable: true),
                    PracticeDate = table.Column<DateTime>(nullable: true),
                    OpenBank = table.Column<string>(nullable: true),
                    BankCard = table.Column<string>(nullable: true),
                    EducationCode = table.Column<Guid>(nullable: true),
                    EducationDate = table.Column<DateTime>(nullable: true),
                    DegreeCode = table.Column<Guid>(nullable: true),
                    School = table.Column<string>(nullable: true),
                    SchoolMajor = table.Column<string>(nullable: true),
                    GraduationDate = table.Column<DateTime>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    MarriageCode = table.Column<Guid>(nullable: true),
                    HomeAdd = table.Column<string>(nullable: true),
                    IdentityAdd = table.Column<string>(nullable: true),
                    NativePlace = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    IsStop = table.Column<bool>(nullable: false, defaultValue: false),
                    Remark = table.Column<string>(nullable: true),
                    CreateEmp = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEmp", x => x.EmpCode);
                    table.ForeignKey(
                        name: "FK_AdminDutyCode_ComAdminDuty_SysEmp",
                        column: x => x.AdminDutyCode,
                        principalTable: "ComAdminDuty",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysEmp_ComPost_ComPostCode",
                        column: x => x.ComPostCode,
                        principalTable: "ComPost",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DegreeCode_ComDegree_SysEmp",
                        column: x => x.DegreeCode,
                        principalTable: "ComDegree",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeptCode_SysDept_SysEmp",
                        column: x => x.DeptCode,
                        principalTable: "SysDept",
                        principalColumn: "DeptCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationCode_ComEducation_SysEmp",
                        column: x => x.EducationCode,
                        principalTable: "ComEducation",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GenderCode_ComGender_SysEmp",
                        column: x => x.GenderCode,
                        principalTable: "ComGender",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarriageCode_ComMarriage_SysEmp",
                        column: x => x.MarriageCode,
                        principalTable: "ComMarriage",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationCode_ComNation_SysEmp",
                        column: x => x.NationCode,
                        principalTable: "ComNation",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoliticalCode_ComPolitical_SysEmp",
                        column: x => x.PoliticalCode,
                        principalTable: "ComPolitical",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PTCode_ComProfessionTitle_SysEmp",
                        column: x => x.ProfessionTitleCode,
                        principalTable: "ComProfessionTitle",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PTLCode_ComProfessionTitleLevel_SysEmp",
                        column: x => x.ProfessionTitleLevelCode,
                        principalTable: "ComProfessionTitleLevel",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PTTCode_ComProfessionTitleType_SysEmp",
                        column: x => x.ProfessionTitleTypeCode,
                        principalTable: "ComProfessionTitleType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypeCode_SysEmpType_SysEmp",
                        column: x => x.TypeCode,
                        principalTable: "SysEmpType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    EmpCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_SysEmp_EmpCode",
                        column: x => x.EmpCode,
                        principalTable: "SysEmp",
                        principalColumn: "EmpCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysContract",
                columns: table => new
                {
                    EmpCode = table.Column<string>(nullable: false),
                    Code = table.Column<Guid>(nullable: false),
                    YearLimit = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    SN = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateEmp = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysContract", x => x.EmpCode);
                    table.ForeignKey(
                        name: "FK_EmpCode_SysEmp_SysContract",
                        column: x => x.EmpCode,
                        principalTable: "SysEmp",
                        principalColumn: "EmpCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysEducation",
                columns: table => new
                {
                    EmpCode = table.Column<string>(nullable: false),
                    MaxEducation = table.Column<string>(nullable: true),
                    MaxSys = table.Column<int>(nullable: true),
                    MaxForm = table.Column<string>(nullable: true),
                    MaxSubject = table.Column<string>(nullable: true),
                    MaxDate = table.Column<DateTime>(nullable: true),
                    MaxSchool = table.Column<string>(nullable: true),
                    FirstEducation = table.Column<string>(nullable: true),
                    FirstSys = table.Column<int>(nullable: true),
                    FirstForm = table.Column<string>(nullable: true),
                    FirstSubject = table.Column<string>(nullable: true),
                    FirstDate = table.Column<DateTime>(nullable: true),
                    FirstSchool = table.Column<string>(nullable: true),
                    SecondEducation = table.Column<string>(nullable: true),
                    SecondSys = table.Column<int>(nullable: true),
                    SecondForm = table.Column<string>(nullable: true),
                    SecondSubject = table.Column<string>(nullable: true),
                    SecondDate = table.Column<DateTime>(nullable: true),
                    SecondSchool = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEducation", x => x.EmpCode);
                    table.ForeignKey(
                        name: "FK_EmpCode_SysEmp_SysEducation",
                        column: x => x.EmpCode,
                        principalTable: "SysEmp",
                        principalColumn: "EmpCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysProfessionInfo",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    EmpCode = table.Column<string>(nullable: false),
                    ProfessionRegisterCode = table.Column<Guid>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    ProfessionExtentCode = table.Column<Guid>(nullable: true),
                    ProfessionTitleTypeCode = table.Column<Guid>(nullable: true),
                    ProfessionTitleLevelCode = table.Column<Guid>(nullable: true),
                    ProfessionTitleCode = table.Column<Guid>(nullable: true),
                    IsEngage = table.Column<bool>(nullable: false, defaultValue: false),
                    EngageDate = table.Column<DateTime>(nullable: true),
                    ProfessionTypeCode = table.Column<Guid>(nullable: true),
                    ProfessionalName = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    No1 = table.Column<string>(nullable: true),
                    No2 = table.Column<string>(nullable: true),
                    No3 = table.Column<string>(nullable: true),
                    No4 = table.Column<string>(nullable: true),
                    No5 = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateEmp = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysProfessionInfo", x => x.Code);
                    table.ForeignKey(
                        name: "FK_EmpCode_SysEmp_SysProfessionInfo",
                        column: x => x.EmpCode,
                        principalTable: "SysEmp",
                        principalColumn: "EmpCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtentCode_Extent_SysProfessionInfo",
                        column: x => x.ProfessionExtentCode,
                        principalTable: "ComProfessionExtent",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegisterCode_Register_SysProfessionInfo",
                        column: x => x.ProfessionRegisterCode,
                        principalTable: "ComProfessionRegister",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TitleCode_Title_SysProfessionInfo",
                        column: x => x.ProfessionTitleCode,
                        principalTable: "ComProfessionTitle",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LevelCode_TitleLevel_SysProfessionInfo",
                        column: x => x.ProfessionTitleLevelCode,
                        principalTable: "ComProfessionTitleLevel",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypeCode_TitleType_SysProfessionInfo",
                        column: x => x.ProfessionTitleTypeCode,
                        principalTable: "ComProfessionTitleType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypeCode_Type_SysProfessionInfo",
                        column: x => x.ProfessionTypeCode,
                        principalTable: "ComProfessionType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpCode",
                table: "AspNetUsers",
                column: "EmpCode");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ComProfessionTitle_LevelCode",
                table: "ComProfessionTitle",
                column: "LevelCode");

            migrationBuilder.CreateIndex(
                name: "IX_ComProfessionTitle_TypeCode",
                table: "ComProfessionTitle",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_AdminDutyCode",
                table: "SysEmp",
                column: "AdminDutyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_ComPostCode",
                table: "SysEmp",
                column: "ComPostCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_DegreeCode",
                table: "SysEmp",
                column: "DegreeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_DeptCode",
                table: "SysEmp",
                column: "DeptCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_EducationCode",
                table: "SysEmp",
                column: "EducationCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_GenderCode",
                table: "SysEmp",
                column: "GenderCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_MarriageCode",
                table: "SysEmp",
                column: "MarriageCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_NationCode",
                table: "SysEmp",
                column: "NationCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_PoliticalCode",
                table: "SysEmp",
                column: "PoliticalCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_ProfessionTitleCode",
                table: "SysEmp",
                column: "ProfessionTitleCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_ProfessionTitleLevelCode",
                table: "SysEmp",
                column: "ProfessionTitleLevelCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_ProfessionTitleTypeCode",
                table: "SysEmp",
                column: "ProfessionTitleTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysEmp_TypeCode",
                table: "SysEmp",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysNavbar_TypeCode",
                table: "SysNavbar",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_EmpCode",
                table: "SysProfessionInfo",
                column: "EmpCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionExtentCode",
                table: "SysProfessionInfo",
                column: "ProfessionExtentCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionRegisterCode",
                table: "SysProfessionInfo",
                column: "ProfessionRegisterCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionTitleCode",
                table: "SysProfessionInfo",
                column: "ProfessionTitleCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionTitleLevelCode",
                table: "SysProfessionInfo",
                column: "ProfessionTitleLevelCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionTitleTypeCode",
                table: "SysProfessionInfo",
                column: "ProfessionTitleTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_SysProfessionInfo_ProfessionTypeCode",
                table: "SysProfessionInfo",
                column: "ProfessionTypeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "SysContract");

            migrationBuilder.DropTable(
                name: "SysEducation");

            migrationBuilder.DropTable(
                name: "SysNavbar");

            migrationBuilder.DropTable(
                name: "SysProfessionInfo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SysNavbarType");

            migrationBuilder.DropTable(
                name: "ComProfessionExtent");

            migrationBuilder.DropTable(
                name: "ComProfessionRegister");

            migrationBuilder.DropTable(
                name: "ComProfessionType");

            migrationBuilder.DropTable(
                name: "SysEmp");

            migrationBuilder.DropTable(
                name: "ComAdminDuty");

            migrationBuilder.DropTable(
                name: "ComPost");

            migrationBuilder.DropTable(
                name: "ComDegree");

            migrationBuilder.DropTable(
                name: "SysDept");

            migrationBuilder.DropTable(
                name: "ComEducation");

            migrationBuilder.DropTable(
                name: "ComGender");

            migrationBuilder.DropTable(
                name: "ComMarriage");

            migrationBuilder.DropTable(
                name: "ComNation");

            migrationBuilder.DropTable(
                name: "ComPolitical");

            migrationBuilder.DropTable(
                name: "ComProfessionTitle");

            migrationBuilder.DropTable(
                name: "SysEmpType");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleLevel");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleType");
        }
    }
}
