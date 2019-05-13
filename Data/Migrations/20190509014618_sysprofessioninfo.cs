using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class sysprofessioninfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    CreateDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
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
                    UpDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    No1 = table.Column<string>(nullable: true),
                    No2 = table.Column<string>(nullable: true),
                    No3 = table.Column<string>(nullable: true),
                    No4 = table.Column<string>(nullable: true),
                    No5 = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreateEmp = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
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
                    { new Guid("f800b24b-fc43-427d-9d90-a56f52d4265b"), "院长", 1, "YC,YZ" },
                    { new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"), "无", 15, "M,W" },
                    { new Guid("bb456397-4673-49a5-9526-7572b4d5ee5d"), "返聘", 14, "FP" },
                    { new Guid("09d44606-3aa4-4367-b5fb-dbebac08b08c"), "干事", 13, "GS" },
                    { new Guid("5f8604ec-34ff-4b43-8bd6-8d611d0a5388"), "科员", 12, "KY" },
                    { new Guid("320279c7-bbb9-4262-9a43-7fa85356335c"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("ece3c907-8057-413d-985a-f2584a8def24"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("2024eba6-ac7f-45ad-b21a-cd5b336b058f"), "副主任", 9, "FZR" },
                    { new Guid("2fa3b120-a4cb-4f9c-ac31-4ecc630b719a"), "大科主任", 7, "DKZR" },
                    { new Guid("c7ca203c-c15f-4dec-b503-d3f3c1c99001"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("aec03cba-6bac-4c96-88c5-6ec2e88becb6"), "团委书记", 5, "TWSJ" },
                    { new Guid("fa561b31-d4a4-4b6a-962e-1947c5c1eaf0"), "副书记", 4, "FSJ" },
                    { new Guid("4b387d33-f311-4cb9-abb5-2727c61ad2ad"), "书记", 3, "SJ" },
                    { new Guid("ac0f0d91-6b03-47be-a0f2-820831c9d326"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("286a86d9-2ab4-45d5-920f-be3dc60e0173"), "科主任", 8, "KZR" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cc978d3-8cbb-4c8d-bdb1-48023dd64add"), "无", 5, "M,W" },
                    { new Guid("5d852860-dfa1-4708-b432-cc8810a6eb29"), "学士", 4, "XS" },
                    { new Guid("85c5b5d4-ea36-4042-a755-a0ce02dd9a39"), "博士", 2, "BS" },
                    { new Guid("554d2c3b-e7c7-4b9a-893a-9e2180343389"), "博士后", 1, "BSH" },
                    { new Guid("f100668c-222e-4681-9d36-af0c93b85850"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6dac8482-92a1-4f57-bc6d-89c21549720a"), "博士研究生", 1, "BSYJS" },
                    { new Guid("db9e701b-3b09-4a7b-9d39-84ca17e240d3"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("bd1c32fa-48ab-4899-83c0-a35be8a3bef3"), "本科", 3, "BK" },
                    { new Guid("b171ef51-4722-40c2-a685-1919399bac96"), "专科", 4, "ZK" },
                    { new Guid("9f9f5c22-d510-441b-86be-d06179d9ed1e"), "中专", 5, "ZZ" },
                    { new Guid("5669eb3e-5360-4827-9a4d-ea93f108c478"), "高中及以下", 6, "GZJYX" },
                    { new Guid("2a385ff2-8529-4438-8694-3993df4732cf"), "技校", 7, "JJ,JX" },
                    { new Guid("c633c4a8-781c-42ae-bac1-5fe71d6e1ad4"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("234787a3-434e-4df5-9d28-e46c074450bf"), "男", 1, "N" },
                    { new Guid("465e560c-0b4c-4a86-92b5-7ca0b1f35b41"), "女", 2, "N" },
                    { new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"), "未知", 3, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"), "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK" },
                    { new Guid("7a722c59-5109-4b90-bb9f-6d6ab02efd7c"), "离婚", 4, "LH" },
                    { new Guid("00f91eff-9ba4-41ba-a3bf-acfd9ff56347"), "未婚", 1, "WH" },
                    { new Guid("22224e56-f836-4c87-8d27-e74027a4db00"), "已婚", 2, "YH" },
                    { new Guid("68e0e6ae-b40c-49d8-9760-38339e8d72a7"), "丧偶", 3, "SO" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("53630487-63fa-428a-88b4-d6e6bac460ee"), "仫佬族", 32, "MLZ" },
                    { new Guid("05ec5d06-c629-49ed-a3bd-b71a123a3a35"), "羌族", 33, "QZ" },
                    { new Guid("d80ab5dc-7b8d-47ee-b6c8-9ca8cf57ee1c"), "布朗族", 34, "BLZ" },
                    { new Guid("b3ae22af-4665-4be1-918b-5fe01e051410"), "撒拉族", 35, "SLZ" },
                    { new Guid("77faece3-2bca-41c3-9cae-7f8af9bf5edd"), "毛难族", 36, "MNZ" },
                    { new Guid("4fb34841-b4de-40f9-b365-18c0557676a2"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("f9818ca3-7fea-43af-9b5b-f35d905d0df0"), "锡伯族", 38, "XBZ" },
                    { new Guid("ed6f817b-15c4-42cb-97c8-3d117b47ed99"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("8719e87f-6514-4449-82ca-d6d7051e0ca7"), "普米族", 40, "PMZ" },
                    { new Guid("e32aafb9-278f-4a8a-99ea-20b0d50115b9"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("f9b16030-1d52-4db5-8074-8e5c55a6ebba"), "怒族", 42, "NZ" },
                    { new Guid("6afe203d-321c-4ccc-8bae-415b138e044b"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("35ecd349-5907-4365-9c5b-88852bbd4e98"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("253c0ffb-98ae-4ce9-9fa2-81f5ebffdd77"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("5bea2367-4330-4214-acf3-acef955e25f3"), "保安族", 47, "BAZ" },
                    { new Guid("3c7e9eec-7d4c-4aa6-beb7-5506a0e07be4"), "裕固族", 48, "YGZ" },
                    { new Guid("4274e477-8f25-4019-9254-3eb0ab53eeff"), "京族", 49, "JZ" },
                    { new Guid("436ae831-a80f-42c4-a914-f25e0cee9838"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("6288f040-b496-47dd-8cb3-c09637b05b53"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("7336ded3-59df-41ed-a3e9-6f5e6c57306f"), "赫哲族", 53, "HZZ" },
                    { new Guid("5214254f-29f3-47a9-af69-85f8ada1baf5"), "门巴族", 54, "MBZ" },
                    { new Guid("9a1a1f53-e95f-49f4-99e0-e6c407384936"), "珞巴族", 55, "LBZ" },
                    { new Guid("358a9a11-8246-4690-855f-6776037782a0"), "基诺族", 56, "JNZ" },
                    { new Guid("ac274152-d226-4429-a900-9866b664ba8f"), "其他", 57, "JT,QT" },
                    { new Guid("a32f7f6c-3352-4430-a95e-1a843390a4a2"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("dc267b1f-cb70-4ccb-bc39-748b6c991dc6"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("80bbb5cc-0145-4da8-af4c-68fa9c191c33"), "崩龙族", 46, "BLZ" },
                    { new Guid("66555381-4ce2-49b7-8d12-26ebe58ab62b"), "土族", 30, "TZ" },
                    { new Guid("f7781123-a3da-4920-aa1b-174ef903e2c1"), "独龙族", 51, "DLZ" },
                    { new Guid("28ed9f87-21b4-4b03-b3e7-8c20130ddc86"), "景颇族", 28, "JPZ" },
                    { new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"), "汉族", 1, "HZ" },
                    { new Guid("8d99f97d-2d8c-4071-b4c3-d9e9d8bae9c7"), "蒙古族", 2, "MGZ" },
                    { new Guid("aec05b85-f859-49b6-8b7b-1848ab10867c"), "回族", 3, "HZ" },
                    { new Guid("5d28ef7e-c289-4504-89e8-c255815f3711"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("96c5c71b-48a5-490d-9426-2f669ce91115"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("bfba1095-d528-4dc1-a2c0-56d538fd0741"), "苗族", 6, "MZ" },
                    { new Guid("5a4c50a1-10bf-4d8c-aad7-244b91a77928"), "彝族", 7, "YZ" },
                    { new Guid("365160cf-aa14-40df-aeea-9063ca544f1a"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("e912911e-8693-487d-8144-e6a29a722135"), "壮族", 8, "ZZ" },
                    { new Guid("83ba89ae-17ac-4ce4-95f1-8ab7cd49efab"), "布依族", 9, "BYZ" },
                    { new Guid("fd57b633-3cd7-45a2-8c98-a2ae094955ef"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("fc5f5357-6fb2-4f3a-a162-35ca43a2ba8a"), "侗族", 12, "DZ,TZ" },
                    { new Guid("47c9ef38-b342-45a8-88eb-4a3dd4d6a404"), "瑶族", 13, "YZ" },
                    { new Guid("0aff322c-b25f-4f53-a087-04925a131bbc"), "满族", 11, "MZ" },
                    { new Guid("f9ba51a4-bdcb-497d-82d4-4863f530c2f9"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("b2fe0952-cc28-412e-ba5a-75e2336e13ea"), "纳西族", 27, "NXZ" },
                    { new Guid("eb4ecdde-354f-42bb-82cd-6946e53e3383"), "东乡族", 26, "DXZ" },
                    { new Guid("aa1f110a-481d-4942-8783-f9a507432334"), "水族", 25, "SZ" },
                    { new Guid("99681f1a-bdaf-459a-87e4-b47f330544b5"), "拉祜族", 24, "LHZ" },
                    { new Guid("5ca35e9a-dcfe-4ce9-aa6c-6dfb0fadbc10"), "白族", 14, "BZ" },
                    { new Guid("c94e76f5-a711-4761-be5c-18a24d77f34c"), "畲族", 22, "SZ" },
                    { new Guid("e9fc1d27-02ae-40b1-87a7-daa9d0863160"), "高山族", 23, "GSZ" },
                    { new Guid("dfc60a4f-3548-4b51-95a2-0b48a36fdb88"), "傈僳族", 20, "LSZ" },
                    { new Guid("9f0b0010-41ce-48dd-8b22-5a0616291289"), "黎族", 19, "LZ" },
                    { new Guid("5ba6b87a-fc50-40e6-9970-7f8cf7e44eb3"), "傣族", 18, "DZ" },
                    { new Guid("8f23cb48-ce7c-428a-b287-97f3fcd61d14"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("6e24f333-0e61-47ff-9b33-96b0888481dd"), "哈尼族", 16, "HNZ" },
                    { new Guid("679a4a94-4f2a-4c8b-87e6-5622297488fc"), "佤族", 21, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("74b6f438-bb44-4c01-afdb-73a582554115"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"), "群众", 13, "QZ" },
                    { new Guid("37249887-a399-403d-956c-6f3a1194e815"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("94937f1a-46a6-430e-8ada-6e331aa5b6bc"), "台盟盟员", 11, "TMMY" },
                    { new Guid("8ecfd8cd-6663-4c44-bb63-0b90567d5c89"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("700bb7cc-9593-476e-baf7-f4172cdd50f6"), "农工党党员", 8, "NGDDY" },
                    { new Guid("09031b4b-54b5-476f-a9f9-09943c11db61"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("224b452e-343e-4113-bd9a-f3c7425fed84"), "民盟盟员", 5, "MMMY" },
                    { new Guid("480a29d2-2fb7-41e4-9a3f-f1ac5b363a8e"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("a82a84ba-5c4e-463d-ad02-1614addb2da7"), "共青团员", 3, "GQTY" },
                    { new Guid("05c75d7a-a5f9-44ef-98d7-a42414b89663"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("ca5a7f6a-9a27-4d24-a3d7-ae1db3bc69a0"), "中共党员", 1, "ZGDY" },
                    { new Guid("178a6a1c-d760-42a6-9195-a7523506f2d6"), "民进会员", 7, "MJHY,MJKY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("d66743da-5026-4497-80eb-ff43bf8107a2"), "卫", 1, "W" },
                    { new Guid("b7ce2a10-4ed1-4812-8945-1d297b9d6c3d"), "工", 2, "G" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionExtent",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("34a13030-a065-4799-a307-ea9938eef90c"), "护理专业", 1, "HLZY" },
                    { new Guid("88b2cdfa-f391-4bf8-b6c8-4cfcd7e7041b"), "外科专业", 2, "WKZY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionRegister",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("77aa99bd-d60b-4294-b8ad-fae4ff12c4d8"), "无", 3, "M,W" },
                    { new Guid("36b4846b-b378-491b-a3a6-af39c5ed8a93"), "执业护士", 1, "ZYHS" },
                    { new Guid("8e92185f-985a-439c-bd7e-f87efe6de9fd"), "执业医师", 2, "ZYYS" }
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
                    { new Guid("f7babd0b-9f5d-43b0-9013-a7eb06fa5e4d"), "公证员", 24, "GZY" },
                    { new Guid("98589976-6f49-4c4f-a15d-f73ad3da5cf1"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("b5c9cfc3-8deb-4b36-9c88-d1b4973d1eca"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("ddbf729e-6831-4342-9ea8-83361656d89f"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("995c1385-df05-4aaa-a491-eadd9cc641e9"), "翻译人员", 22, "FYRY" },
                    { new Guid("673a911a-3a72-4cfd-ba8c-00d2133cf6c1"), "律师", 23, "LS" },
                    { new Guid("681eac44-bc34-4d40-8e7b-a7088d5d0e2e"), "海关人员", 25, "HGRY" },
                    { new Guid("dbc07db1-6ba2-4770-a388-3793d2a086f4"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("64c2fb07-7bc9-4243-92e9-6275c3fc389d"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("8d1e6660-db76-4506-8d9d-efd7cb849263"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("26df2ba3-50ff-4a84-aa05-58b1a0bb5980"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("aae4c713-ae8a-49cf-9b4b-e3f64f97ac4c"), "体育教练员", 30, "TYJLY" },
                    { new Guid("5ec590b1-c671-4fd1-b23a-96d1d3121e2e"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"), "无", 32, "M,W" },
                    { new Guid("4ed0edf8-d5ca-415c-bcb2-3a82cc23feab"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("c8d1d14e-4041-4147-ba55-60b7c6ceeda0"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"), "卫生技术人员", 1, "WSJSRY,WSJZRY" },
                    { new Guid("91b918ee-1285-4841-b194-95bb18140b5a"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("3b4c0478-962a-4ba0-986e-5fffbd29a37d"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("dd2594b7-6578-47ff-9452-2e30a8da5cb0"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("599fe444-7311-4021-bdc8-6b7a67dd5035"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("95c29787-fa91-4584-8923-3e1cd3bde425"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("36e21dae-7b9c-4a79-9252-b5251f7b8e25"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("be83c8e3-5f01-4b57-9074-1609ec9d9c01"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("1d589043-bf83-450d-b5e9-9d60df8c2562"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" },
                    { new Guid("c9537aae-ae32-4347-89db-c898de080636"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("6aefd430-ad80-4a8f-a070-5334be7980f2"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("9c9523b5-229c-476d-8e21-e11cc2c66d38"), "中学教师", 5, "ZXJS" },
                    { new Guid("78e50585-50a2-45d1-91b2-65707b588093"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("e197f9a9-0a8c-45ad-ae03-c6259fb35999"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("40dbc973-2eb8-49f5-9c15-921a7bf95524"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("a1c0bf8f-3127-4690-83ac-098bf5030cc4"), "新闻专业人员", 16, "XWZYRY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("151ff3c8-45dc-4f2f-9e15-1d4596aa8cc1"), "公卫", 3, "GW" },
                    { new Guid("39708d18-d96e-452a-b45d-305c0b01012e"), "中医", 4, "ZY" },
                    { new Guid("722f37e4-9aa0-46f9-93ae-e4d006a65f18"), "临床", 1, "LC" },
                    { new Guid("e7daea22-52c4-4344-8c2e-9d227cf8664d"), "口腔", 2, "KQ" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"), "试用人员", 16, "SYRY" },
                    { new Guid("0569922c-a4e0-4325-aa97-306fa963ae7b"), "内部退养", 15, "NBTY" },
                    { new Guid("dd0aff53-bdf1-48e3-9d31-2e4893ddaafa"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("8f0e6cf0-9771-496e-bccf-8f9914048c79"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("a9b0c6fc-4455-46cd-a72d-6581c52ae737"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("daa5c488-440d-492a-a07f-42528bf3c702"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("57fc6d99-d361-451f-84a8-f5abe8ed12a6"), "借出人员", 10, "JCRY" },
                    { new Guid("fcbca461-8a0a-444b-b897-ae40f6d2fb08"), "实习进修", 9, "SXJX" },
                    { new Guid("4f200f88-b616-4e45-8de4-715cb3d53414"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("3739b8e5-51ca-4f24-b807-8102640f7a2f"), "返聘人员", 6, "FPRY" },
                    { new Guid("ea1071a4-4882-4b78-9b2d-01ce7314b3a5"), "辞职人员", 5, "CZRY" },
                    { new Guid("ada3bfd5-8514-4134-a12f-ff26ceb51b8c"), "离退人员", 4, "LTRY" },
                    { new Guid("0e74da0b-8a42-4235-9155-acf1fa05631b"), "临时人员", 3, "LSRY" },
                    { new Guid("a01cc9b6-274d-4349-9a8f-2876ef42b9b7"), "人事代理", 2, "RSDL" },
                    { new Guid("2ac49c65-f5d8-45d2-95d7-329bc04ec9a8"), "在编人员", 1, "ZBRY" },
                    { new Guid("a8a5a161-d807-43a6-8ba1-0709cfc4dad8"), "除名人员", 8, "CMRY" }
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
                    { new Guid("ef724365-0936-4f05-a514-32a5fc0c4f16"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("efcd26a4-083b-4065-af68-a70569c827a2"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("4ab1a14d-8862-42d6-b958-50317c0cacb3"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("cbcc32d4-e9e8-49b4-a3c2-b52839551cf7"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("ebf53274-3824-4fe2-97b0-aeddbef5a400"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("bb435c19-721b-47c2-a295-9f9f93aff4a6"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("babe1eb4-0b20-45cf-96a3-2e73556cd030"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("03ba6f16-f26c-4539-a51e-e8aa5ccb54c9"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("6b2865dc-026b-4f22-9540-f2cdc48689cf"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("33f23837-3159-4641-93f7-d2cece34d474"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("301129ca-7765-427d-abc9-23ecc758a21c"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("dc50d875-82d7-4260-8bd9-dd6d3809317e"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("77d517d5-40fc-4b1e-87b4-217e9d113e33"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("09157ba1-de45-46a1-bd10-5fd851e76c82"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("000a5829-0547-4266-b616-ac46f17690fe"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("8cae3ef1-5c1d-46bd-a05e-4d0ac17f3ecf"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("f60e8312-aecd-4f02-b380-2885f71b714c"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("9cc75689-0e1e-4012-9d07-3d3581997a35"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d834d5cc-e111-46af-af78-49d2c72a8b73"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("973a4395-9220-4aac-bba6-f86748bbb085"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("292e5904-db7c-462b-b4a0-792bb0bd757a"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("924ea9fc-c495-450d-929d-31d7b73ee5f1"), "Index", "ComProfessionType", "执业类别", 12, "ZYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("a593f37a-0dfa-4630-b9f5-1976c817e565"), "Index", "ComAdminDuty", "行政职务", 13, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("b2e6861b-d7ba-49ee-b086-e0a6a0e18ab5"), "Index", "SysDept", "科室信息", 17, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("80ef68f8-e79a-47bb-a083-4d6d9da59a24"), "Index", "ComEducation", "学历", 15, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("270831a9-b086-498f-b2a3-c7d74641f280"), "Index", "ComDegree", "学位", 16, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("bdaeef5d-1135-469f-8afd-4e123a3307dc"), "Index", "ComProfessionExtent", "执业范围", 11, "ZYFW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("e589ad6a-662e-4aab-8d5d-b437e7a06989"), "Index", "SysEmpType", "人员类别", 14, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("6804dc66-f38b-4c66-a7ea-40aa14c331b2"), "Index", "ComProfessionRegister", "执业资格", 10, "ZYZG", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("eaa9f1f3-eb57-4d36-92e1-c159829813e3"), "Index", "ComNation", "民族", 5, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("f80dd01a-7241-4841-8718-185e18c308c9"), "Index", "ComProfessionTitleLevel", "职称级别", 8, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("3d054230-1c76-43bd-9567-4e89f8a8fbbe"), "Index", "ComProfessionTitle", "职称", 7, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("a672faab-4fd5-4384-a35c-233693716b78"), "Index", "ComPolitical", "政治面貌", 6, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("cd0de0d2-aea3-4041-b49e-c288c511fa12"), "Index", "ComPost", "岗位", 4, "GW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("909a6329-e081-4ccf-b1e5-661b168cdd81"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("adec8b92-afbc-4611-af78-0af171087c3b"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("926b6469-e6c3-485d-bde2-67a74b40b158"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0b502b34-eefd-42b4-9b3d-12306ba1947b"), "Index", "SysEmp", "人员管理", 18, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") },
                    { new Guid("49b6f718-4c65-4a86-8b70-760963d7a194"), "Index", "ComProfessionTitleType", "职称系列", 9, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("96af7e39-a390-4b47-82f7-9ca0b119308f"), "Index", "SysProfessionInfo", "职称评定", 19, "ZCPD", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
                });

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
        }
    }
}
