using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class education : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpCode",
                table: "AspNetUsers",
                nullable: true);

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
                    Action = table.Column<string>(nullable: true)
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

            migrationBuilder.InsertData(
                table: "ComAdminDuty",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("15e26d40-69c9-4c45-aed7-28ddd118d0ac"), "院长", 1, "YC,YZ" },
                    { new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"), "无", 15, "M,W" },
                    { new Guid("4f10ca3d-01d6-490f-8ec5-f9c470b985d7"), "返聘", 14, "FP" },
                    { new Guid("b9e5bfd3-0a9d-4b7e-b5f8-bf260f430d4d"), "干事", 13, "GS" },
                    { new Guid("c4e7bb33-9b50-403f-afe1-57d8c1b0985a"), "科员", 12, "KY" },
                    { new Guid("adb9206f-c60e-4b2a-8710-2ca206a67b8f"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("7f978b1d-bd3c-4597-918f-34b9dd98b709"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("8d59a3df-b632-4933-a374-37da1ba78bf2"), "副主任", 9, "FZR" },
                    { new Guid("44044bf2-579c-4990-acfb-fbc10a66f7d2"), "大科主任", 7, "DKZR" },
                    { new Guid("642a3ab6-754e-4576-883a-60e7eeac1331"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("f6a7eca4-08e6-46e3-a431-f6eb66d44242"), "团委书记", 5, "TWSJ" },
                    { new Guid("fc8a10aa-7b48-4486-be71-eeb5e7a70e96"), "副书记", 4, "FSJ" },
                    { new Guid("b066badb-467b-4dc2-8dd7-f81483a5cfb6"), "书记", 3, "SJ" },
                    { new Guid("16536c03-2ed5-441b-8c61-dddf7d613586"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("29e86610-5218-4c0d-8d39-2ec82ac85cd0"), "科主任", 8, "KZR" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("62a25a12-7501-422a-852b-727d85b99e30"), "无", 5, "M,W" },
                    { new Guid("58b23fd8-131f-4fd3-b2d7-672c40197703"), "学士", 4, "XS" },
                    { new Guid("c010283c-7e1b-4633-90c1-c8570210c298"), "博士", 2, "BS" },
                    { new Guid("1f4aaf56-db9e-45ef-a917-236a7a09b909"), "博士后", 1, "BSH" },
                    { new Guid("a43f6076-ead4-425d-b618-9bf123d6cb9d"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("fda338f1-d526-4448-a6fc-ab3c93adb618"), "博士研究生", 1, "BSYJS" },
                    { new Guid("1b4c5076-16c3-4c78-aca3-f975880403f5"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("cfa3c390-d686-4ccf-8e12-06d3bc55ba25"), "本科", 3, "BK" },
                    { new Guid("3fe824ec-552b-45f7-b645-58c2056939c6"), "专科", 4, "ZK" },
                    { new Guid("77fecfb7-5c67-4e00-b76b-7121f402b9b1"), "中专", 5, "ZZ" },
                    { new Guid("9ceb7bf9-8e80-4280-925d-c0d96571f85b"), "高中及以下", 6, "GZJYX" },
                    { new Guid("ba19d445-db01-454c-aae6-f5f84923e1a7"), "技校", 7, "JJ,JX" },
                    { new Guid("c789347d-e391-45b1-b305-db24ab7ff5c8"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("aa34ed0e-9476-4866-a3f4-e4e5715992e1"), "男", 1, "N" },
                    { new Guid("4f9df203-1db6-4a7e-8d1a-63df949955d9"), "女", 2, "N" },
                    { new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"), "未知", 3, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"), "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK" },
                    { new Guid("c89eaf2d-af88-4c37-be9d-2a8786eda072"), "离婚", 4, "LH" },
                    { new Guid("78ec60fc-b367-46cc-9785-fe7d54f13a41"), "未婚", 1, "WH" },
                    { new Guid("1a35167f-6f9f-4b8e-9521-f9787d0103fc"), "已婚", 2, "YH" },
                    { new Guid("c680acce-7ed3-4c2c-8c65-e5923a881327"), "丧偶", 3, "SO" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("c0f7f944-7c9c-4c3f-bfed-1b26969f6fda"), "仫佬族", 32, "MLZ" },
                    { new Guid("1839ce83-832e-4f92-a671-333d1590bb8d"), "羌族", 33, "QZ" },
                    { new Guid("569ee6d6-4fce-4fe8-8b68-4589efd84986"), "布朗族", 34, "BLZ" },
                    { new Guid("96852b0e-bcfa-4096-b0b8-eaa01135d85c"), "撒拉族", 35, "SLZ" },
                    { new Guid("7a5c87d8-5aa2-4af7-83c2-94ad1adde49a"), "毛难族", 36, "MNZ" },
                    { new Guid("d58f9ad8-8ec8-4000-8cdd-f46a65c5d87d"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("5cbd8eb4-db86-4bb9-85af-9b024625dc8b"), "锡伯族", 38, "XBZ" },
                    { new Guid("07228aac-9de6-4a5b-87f1-b809bc81dfaf"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("3b1b58ff-1d62-43ad-bf73-5b3304f034e0"), "普米族", 40, "PMZ" },
                    { new Guid("df7b16c0-35c0-434b-8cf5-ec114485418e"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("ce380886-08aa-456d-9fd5-0e107e55e842"), "怒族", 42, "NZ" },
                    { new Guid("5bf3000f-79b4-4614-8eda-371cf6343f81"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("f53250d8-4600-4507-9155-4878fcefbfca"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("52330e79-f1b8-4f01-aa8c-4a50c0f20954"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("4e31543e-c301-4a5c-8b7f-ca7e69b55adc"), "保安族", 47, "BAZ" },
                    { new Guid("96d5a8ce-75b3-4098-b8f8-26b70b99c566"), "裕固族", 48, "YGZ" },
                    { new Guid("35a8c0c0-07a1-4e7a-8497-7b92137e3aa9"), "京族", 49, "JZ" },
                    { new Guid("0745b1d4-498d-490f-b623-2eb07ef5dc40"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("ba8b7cb8-5334-4a71-91c6-8cf69503dd97"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("960bfe8e-2193-4b6f-853d-41ebee3cc334"), "赫哲族", 53, "HZZ" },
                    { new Guid("78841b22-c6c0-4b6e-8c9b-3ba4def0e2b2"), "门巴族", 54, "MBZ" },
                    { new Guid("cee64d2c-71f9-4a38-98bf-490db605ef4e"), "珞巴族", 55, "LBZ" },
                    { new Guid("f71283e7-3948-4d2f-8017-2c43339bfde6"), "基诺族", 56, "JNZ" },
                    { new Guid("0523f3fe-7106-488b-832e-1d399778f1cb"), "其他", 57, "JT,QT" },
                    { new Guid("7f647fef-c490-4009-baec-8a02bff35d0d"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("933b09a5-da7a-4549-968e-0b3057afe7af"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("a1714750-2b04-4083-b147-c014cba09e45"), "崩龙族", 46, "BLZ" },
                    { new Guid("5aec5936-2f50-4fc6-932b-ebe38e1441c0"), "土族", 30, "TZ" },
                    { new Guid("b9fe03ec-68c9-4b6c-9135-b94fbd9fe08a"), "独龙族", 51, "DLZ" },
                    { new Guid("6f5f8a18-69c4-4829-b401-5d7cb08339a6"), "景颇族", 28, "JPZ" },
                    { new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"), "汉族", 1, "HZ" },
                    { new Guid("df3f6023-eefe-46d4-bb27-22a68490811a"), "蒙古族", 2, "MGZ" },
                    { new Guid("74ea325a-6959-4492-b098-dfe8c4e0eadd"), "回族", 3, "HZ" },
                    { new Guid("2ebceeb9-324d-4e1f-9230-70ac835acdb7"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("f514fdd7-51d4-41c0-a929-8e1ae1597fe0"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("a7bfa064-325e-4cdc-b4d1-a9136ebb38f5"), "苗族", 6, "MZ" },
                    { new Guid("ea0ef78e-ab1b-416b-9f89-ff1d27684927"), "彝族", 7, "YZ" },
                    { new Guid("91125fa1-2139-4294-bfca-ad5af7484b50"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("3b082784-9253-4322-93e7-17694bbde498"), "壮族", 8, "ZZ" },
                    { new Guid("7924741a-0d64-4550-bf1b-4386e0d7c270"), "布依族", 9, "BYZ" },
                    { new Guid("116b2502-8384-4180-bb8e-bcaea8d1c37c"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("7b4dc616-e2ca-45dc-bbf9-479393e68142"), "侗族", 12, "DZ,TZ" },
                    { new Guid("215a80a0-4327-4a42-9786-4cbfbbe51b6f"), "瑶族", 13, "YZ" },
                    { new Guid("40076430-0c0f-41fc-8993-3f092a1301d3"), "满族", 11, "MZ" },
                    { new Guid("08260920-7938-4b20-8ba7-2148d7501a29"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("23c6bd01-a11c-4d6b-adec-cdaf2ad2dcc9"), "纳西族", 27, "NXZ" },
                    { new Guid("92db426e-728a-49b1-88dc-d7694babc550"), "东乡族", 26, "DXZ" },
                    { new Guid("740a9785-b940-4e78-8c25-447779b9248b"), "水族", 25, "SZ" },
                    { new Guid("065bd3db-dfc3-4b4f-abdb-bcfac37c7c48"), "拉祜族", 24, "LHZ" },
                    { new Guid("42415a34-ea43-4f6e-8ce0-67a8b6e1bd2b"), "白族", 14, "BZ" },
                    { new Guid("1ff3f119-f85a-4376-a9d2-199d905e996c"), "畲族", 22, "SZ" },
                    { new Guid("be780db8-3cf4-4c96-861a-f446945da63f"), "高山族", 23, "GSZ" },
                    { new Guid("158b8554-72af-4eb4-9143-abe205f185fe"), "傈僳族", 20, "LSZ" },
                    { new Guid("3fb9192c-1f45-411f-9965-835724c8766e"), "黎族", 19, "LZ" },
                    { new Guid("dc5a1b3a-e3d2-41db-a1a9-960650119ec8"), "傣族", 18, "DZ" },
                    { new Guid("7d4c2e40-63ea-431f-8616-069a824a1409"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("a84f77c8-d932-498b-b5b2-410ff4cb065b"), "哈尼族", 16, "HNZ" },
                    { new Guid("b2a28cb2-0696-4bba-948d-1ba25c2cf839"), "佤族", 21, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("5d2638f6-f71c-4ab0-8957-0cafc4637717"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"), "群众", 13, "QZ" },
                    { new Guid("a4538294-9f2a-446f-b1ba-eb16a3cfc5d6"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("00621ace-803d-4fe5-af8a-50498394cfcc"), "台盟盟员", 11, "TMMY" },
                    { new Guid("f64916c0-9354-4c08-b5f0-718ff728fc2d"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("019a2158-f4f7-4b3d-bb28-2c8f6857eb72"), "农工党党员", 8, "NGDDY" },
                    { new Guid("69047a02-8836-4fb1-88b2-867be7909cf2"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("701b353e-93a6-4971-91c4-6f0659d936a4"), "民盟盟员", 5, "MMMY" },
                    { new Guid("de6319db-e1d4-4dd7-a405-c99da0f61ba5"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("cf398d3c-2d34-4d9c-a704-cc4dafab9873"), "共青团员", 3, "GQTY" },
                    { new Guid("6c85ae88-80cc-4fca-98bb-86de65403b54"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("15298025-1e68-4ecf-858d-cf7e3d1832e5"), "中共党员", 1, "ZGDY" },
                    { new Guid("1ceeb87c-715f-4a91-92ab-b6b1e04ee01c"), "民进会员", 7, "MJHY,MJKY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("79442565-250b-4927-aee1-e95da76596bf"), "卫", 1, "W" },
                    { new Guid("98e2fc14-6bda-4805-8b02-29aba01c3457"), "工", 2, "G" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionExtent",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("d42a0a86-b615-42e7-99e5-9d621eff367b"), "护理专业", 1, "HLZY" },
                    { new Guid("214826eb-4690-4966-b4ac-d86ac5a9aa40"), "外科专业", 2, "WKZY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionRegister",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("77aa99bd-d60b-4294-b8ad-fae4ff12c4d8"), "无", 3, "M,W" },
                    { new Guid("53608a31-e776-441a-ae89-63344c7bc208"), "执业护士", 1, "ZYHS" },
                    { new Guid("4e2d1d63-ea21-4900-ac49-e23f3a92d7a9"), "执业医师", 2, "ZYYS" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleLevel",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无", 5, "M,W" },
                    { new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "中级", 3, "ZJ" },
                    { new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "初级", 4, "CJ" },
                    { new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "正高级", 1, "ZGJ" },
                    { new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副高级", 2, "FGJ" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("1d3ca329-5b49-40fd-9a15-1878d3c368c5"), "公证员", 24, "GZY" },
                    { new Guid("a3ad7cfb-6dac-4435-86db-b630fb15dda2"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("c0ffb314-2029-413b-87ec-4a46731abd0e"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("127ccfd1-0fe6-4217-9d58-bb11d5a87e09"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("278a5a5d-5417-4f91-9293-ea4d2f7316d4"), "翻译人员", 22, "FYRY" },
                    { new Guid("d7e270c4-48b7-472f-bd56-4fb8889a5088"), "律师", 23, "LS" },
                    { new Guid("b07bd53d-421b-4467-808b-bb9cf771d670"), "海关人员", 25, "HGRY" },
                    { new Guid("755dacc0-ceda-4580-8986-e54771c4e18c"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("03ce302b-49fb-4dad-a866-cc417f97e787"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("cc4dd828-e9da-453b-a0b1-f6a927948e66"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("583c9795-b0ef-4455-949e-c5dda637c55b"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("e4a05dda-30a7-4521-8f5a-8c074de8952e"), "体育教练员", 30, "TYJLY" },
                    { new Guid("f35b9904-58b1-401e-b025-d7082f263e1e"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"), "无", 32, "M,W" },
                    { new Guid("708d2878-b506-4ef3-8c40-788ba06ca882"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("f445a1ab-c592-41b0-a624-deb7bea07eb3"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"), "卫生技术人员", 1, "WSJSRY,WSJZRY" },
                    { new Guid("c331e825-4929-4b5f-9d8a-9424d3099c25"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("35f9d093-ae18-4fb9-aafe-ee1670de364a"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("7a2d9196-9d25-4eca-b8c5-09f9c7e0b58e"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("1a7a172a-4aa2-4702-8764-4a4506988b8a"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("a8d9da55-8d7e-4e9a-a414-2692bb54cf49"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("eff8387d-f752-4bbb-a34e-353a8b8b5072"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("bfc96cd5-7748-426b-aaa5-841349e059a2"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("a4924b96-3361-46fb-84a5-499a98e6f0f7"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" },
                    { new Guid("8328343e-dbab-4bfd-9575-9e0a6fa19100"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("32a1c0cb-e639-4c2f-baa1-4084742546ba"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("adfca99d-ff25-4a5c-a907-5a492309830e"), "中学教师", 5, "ZXJS" },
                    { new Guid("9237091c-4cf2-4da6-ae8e-b7216817a3b5"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("9e41ffeb-4cfe-43c4-ba66-88f41721de66"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("507633ce-e08e-450d-88a2-412c51c736be"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("e14f1c81-ca3c-4157-8584-74d430feae0d"), "新闻专业人员", 16, "XWZYRY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("21ea0a48-17df-4e0b-ab02-1fef2bcf903f"), "公卫", 3, "GW" },
                    { new Guid("fb49af75-12d0-4940-aa8a-e4eaeaa52345"), "中医", 4, "ZY" },
                    { new Guid("658b6922-fb94-43f6-b22f-15fa0be08a76"), "临床", 1, "LC" },
                    { new Guid("1a9f6446-acc5-48b0-b419-2b1fcd074573"), "口腔", 2, "KQ" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"), "试用人员", 16, "SYRY" },
                    { new Guid("63dffcc7-1566-42a9-8271-d034a79797d6"), "内部退养", 15, "NBTY" },
                    { new Guid("356b44d9-d578-4785-b49c-cbbf3cb27696"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("023be8ef-c42e-422f-8f51-3d155ac0709c"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("c3c4395d-864b-4aa6-9363-b13c11441330"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("84dbe481-473e-4b00-878d-a2885367b438"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("25fc9450-ca20-499c-a1fd-e8b88d6b1057"), "借出人员", 10, "JCRY" },
                    { new Guid("dacc934a-4079-48b9-943d-751a911ab31e"), "实习进修", 9, "SXJX" },
                    { new Guid("be0cbcb8-6be2-440a-8ce4-a1371204831c"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("03fe1f70-9037-4ddb-882d-91cf8bc41d8a"), "返聘人员", 6, "FPRY" },
                    { new Guid("2c0385d2-b6b6-405c-9e85-b9ddf9b0e1fa"), "辞职人员", 5, "CZRY" },
                    { new Guid("367e9354-733c-494f-b0be-43b46b581d1a"), "离退人员", 4, "LTRY" },
                    { new Guid("f8a46c8c-e214-4a60-98f7-97e858a82a58"), "临时人员", 3, "LSRY" },
                    { new Guid("358f4830-92ed-47d5-8a14-60ae0a2c1a9f"), "人事代理", 2, "RSDL" },
                    { new Guid("69b93d12-c392-43e2-93a6-263b2110e135"), "在编人员", 1, "ZBRY" },
                    { new Guid("bfa39b7c-ab88-4bbf-9eb5-4a309f3513b6"), "除名人员", 8, "CMRY" }
                });

            migrationBuilder.InsertData(
                table: "SysNavbarType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e"), "机构管理", 2, "JGGL" },
                    { new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"), "基础数据维护", 1, "JCSJWH" },
                    { new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993"), "人事档案", 3, "RSDA" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitle",
                columns: new[] { "Code", "LevelCode", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("773e4ded-96e7-4879-950b-1a113baa4b81"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("be357d15-4a21-4ef2-8892-c99b5afd4500"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("0f291598-f584-42f8-99f1-c9821b6adda3"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("0b7fa4de-d555-4e3e-8b85-e39649587d8a"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("37cf6d32-e95c-4f20-99d6-0c88b9603b1d"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("9ac5f264-5ecc-4d19-814e-f84d1fac84cc"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("2e60d9a7-856b-4fd5-989f-f8898bc79138"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("40e95cc3-eec2-4c85-978b-05a35ba210d0"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("6e26fd8c-2ca9-4481-9b2e-8121f4c95053"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("3cb41995-d4d5-437c-8af5-9d7b5e314440"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e8dc6d06-2759-406a-aa91-49fe24238ce5"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("1c924c9f-1d7b-4082-9153-fa0964e36f07"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d4962f06-55ec-4552-98e2-8ecb106a85ab"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("32fae2ed-b16c-47be-b565-988318c54ce1"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("64d8fa60-bd26-4d7f-8fae-aa5940175b34"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("74583e12-e79b-4466-82e0-36000682d00f"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("0ab33680-811a-4930-a417-69b9765f1564"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d2224594-b7ac-4068-a5db-8df49107d96e"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("816cd696-c722-4c14-bc55-0a77421ed5ae"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("46ce6ba7-6a9e-48d5-91e0-6298e9bc6b34"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c9967c38-685a-4dfa-a825-132f13d3e5d2"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("07ce62fc-88ec-463f-8e4d-afb204666127"), "Index", "ComProfessionType", "执业类别", 12, "ZYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("6f4396b3-a58c-45a9-823e-aaf5275918fd"), "Index", "ComAdminDuty", "行政职务", 13, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("4dc9f202-2a10-4c06-b328-d8dd183e92a3"), "Index", "SysEmpType", "人员类别", 14, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("adde56fd-2682-4af9-940b-4348f8c0a66a"), "Index", "SysEmp", "人员管理", 18, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") },
                    { new Guid("6d7b1a09-127e-4149-9841-441d166a98b6"), "Index", "ComDegree", "学位", 16, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("1ec827b5-3d28-4a92-8d0f-3f852111d463"), "Index", "SysDept", "科室信息", 17, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("58a749b5-ff8a-4852-bef8-0e8c63ffaca4"), "Index", "ComProfessionExtent", "执业范围", 11, "ZYFW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("a906d1b6-15df-4dcf-a410-a02f567523e7"), "Index", "ComEducation", "学历", 15, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("6d38c1a9-91d0-4e29-be00-09428c8c185c"), "Index", "ComProfessionRegister", "执业资格", 10, "ZYZG", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("858033bb-1f82-433e-bfbc-8a58c2ecca9c"), "Index", "ComNation", "民族", 5, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("3dc6752e-a7de-4593-a789-995862635fad"), "Index", "ComProfessionTitleLevel", "职称级别", 8, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("4c2e1c2d-600b-4c5a-ae8b-6f9e16a700a8"), "Index", "ComProfessionTitle", "职称", 7, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("f23215d3-2437-4e1a-a3cc-3bf28e77e5c1"), "Index", "ComPolitical", "政治面貌", 6, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("e5824870-d78a-4f4b-a86d-9c3a16b916b8"), "Index", "ComPost", "岗位", 4, "GW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("940d85d4-f3e9-4854-94de-374320aefb26"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("afd5d978-54ea-4b7d-9902-ecbfaee29035"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("966a5fb7-23e9-4f82-bf94-442dcfd0a400"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("527bba39-46dd-4c85-b5b2-4db556409042"), "Index", "SysProfessionInfo", "职称评定", 19, "ZCPD", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") },
                    { new Guid("4641bdc3-aca3-4f4a-a372-5cd63dd2533a"), "Index", "ComProfessionTitleType", "职称系列", 9, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("60d7f19f-b99f-4356-b691-dec78826b19d"), "Index", "SysEducation", "学历评定", 20, "XLPD", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpCode",
                table: "AspNetUsers",
                column: "EmpCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SysEmp_EmpCode",
                table: "AspNetUsers",
                column: "EmpCode",
                principalTable: "SysEmp",
                principalColumn: "EmpCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SysEmp_EmpCode",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SysEducation");

            migrationBuilder.DropTable(
                name: "SysNavbar");

            migrationBuilder.DropTable(
                name: "SysProfessionInfo");

            migrationBuilder.DropTable(
                name: "SysNavbarType");

            migrationBuilder.DropTable(
                name: "SysEmp");

            migrationBuilder.DropTable(
                name: "ComProfessionExtent");

            migrationBuilder.DropTable(
                name: "ComProfessionRegister");

            migrationBuilder.DropTable(
                name: "ComProfessionType");

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

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmpCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmpCode",
                table: "AspNetUsers");
        }
    }
}
