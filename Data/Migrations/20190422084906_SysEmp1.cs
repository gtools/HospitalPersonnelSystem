using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class SysEmp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComAdminDuty",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComPolitical", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ComProfessionTitleLevel",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComProfessionTitleType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SysDept",
                columns: table => new
                {
                    DeptCode = table.Column<string>(nullable: false, defaultValueSql: "newid()"),
                    DeptName = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
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
                    AdminDutyCode = table.Column<Guid>(nullable: false),
                    IsPost = table.Column<bool>(nullable: false, defaultValue: true),
                    TypeCode = table.Column<Guid>(nullable: false),
                    WorkDate = table.Column<DateTime>(nullable: true),
                    HospitalDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
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
                    MarriageCode = table.Column<Guid>(nullable: false),
                    BirthAdd = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ComAdminDuty",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("87982a0b-6472-403a-b2cc-f29531a768fd"), "院长", 1, "YC,YZ" },
                    { new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"), "无", 15, "M,W" },
                    { new Guid("d4356916-eed6-4c84-bf38-3e207b1cd8f5"), "返聘", 14, "FP" },
                    { new Guid("f6de592d-a65f-4e89-bf18-40729bb2529a"), "干事", 13, "GS" },
                    { new Guid("f63b0e64-8c18-496c-bcb7-084ca602afd6"), "科员", 12, "KY" },
                    { new Guid("bcaeaa1f-bfcd-475b-87be-7ddd56d9d8bb"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("0df02067-9b98-4a72-b1ff-fb5aebd01dc4"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("35f72ccf-5a27-4de6-8a1d-2ab54efd9ce3"), "副主任", 9, "FZR" },
                    { new Guid("46812b55-7b90-42bd-ad96-1c671d24dead"), "大科主任", 7, "DKZR" },
                    { new Guid("39a83fd5-a6a7-4bd8-a09d-7bf3b58428cf"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("60415184-d114-4319-9017-07df70edaa6f"), "团委书记", 5, "TWSJ" },
                    { new Guid("5644b8b2-e96f-4580-bfdc-96d3cca9977d"), "副书记", 4, "FSJ" },
                    { new Guid("7dc140aa-48f4-431a-a453-35b329ad8dde"), "书记", 3, "SJ" },
                    { new Guid("c2d9eaf2-a3f9-4a7f-a3eb-832514c333a1"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("2921a8a8-caf8-41eb-8f26-b7deb86487f4"), "科主任", 8, "KZR" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("82fbc87b-2395-456c-8f5d-1c057f4c4f23"), "无", 5, "M,W" },
                    { new Guid("8706f3c5-77de-4f05-89ed-836abe03ce88"), "学士", 4, "XS" },
                    { new Guid("f4b6484e-375c-4b56-bbcc-2921526b7515"), "博士", 2, "BS" },
                    { new Guid("cff00a02-34fe-4edb-910e-a8279c789bf2"), "博士后", 1, "BSH" },
                    { new Guid("cff3ecd0-3a6c-4345-b334-541b588f1558"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("c5b558b8-ce10-437d-ab14-21ff32fda67d"), "博士研究生", 1, "BSYJS" },
                    { new Guid("0ac6285e-b0c8-417b-bb36-69a5f05488a2"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("ec171bfd-8ff5-4240-9750-7f6e0a291153"), "本科", 3, "BK" },
                    { new Guid("dd9159b1-b5e1-4bd2-8592-693c3da3de75"), "专科", 4, "ZK" },
                    { new Guid("849e5df0-f441-405e-a6cf-eead95c9de9f"), "中专", 5, "ZZ" },
                    { new Guid("0cfe317b-7e3a-4430-8723-14f31f56bc94"), "高中及以下", 6, "GZJYX" },
                    { new Guid("b3c0fe4c-0a6d-4ca7-9684-92ea578667e5"), "技校", 7, "JJ,JX" },
                    { new Guid("400d57e3-cf50-4342-81ed-61abc8d4a73f"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("0630a5c8-f534-4f0a-bb7c-6f5d502f6775"), "男", 1, "N" },
                    { new Guid("654216e7-20ef-4fd8-91a9-997140d385bd"), "女", 2, "N" },
                    { new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"), "未知", 3, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"), "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK" },
                    { new Guid("3454f308-3d1a-4238-b840-33a11e30f0fa"), "离婚", 4, "LH" },
                    { new Guid("f74b78e0-6d65-434b-80b3-31e1af8bfe3c"), "未婚", 1, "WH" },
                    { new Guid("bce6742e-1175-4866-b449-e4d1c11a75d1"), "已婚", 2, "YH" },
                    { new Guid("f52b4cd1-59c1-40af-9f5c-2221639f3a69"), "丧偶", 3, "SO" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("89e49664-e93c-4052-98bd-791fb1fb4d80"), "仫佬族", 32, "MLZ" },
                    { new Guid("61edbd56-9baa-42b7-9ad9-5a30f5352e6b"), "羌族", 33, "QZ" },
                    { new Guid("0e932375-9ef5-4534-910d-7f6fde59fa85"), "布朗族", 34, "BLZ" },
                    { new Guid("025318a9-4c13-40cd-87cc-d090b0c46991"), "撒拉族", 35, "SLZ" },
                    { new Guid("74874774-c46d-4455-bb2f-35e6d06a4a5a"), "毛难族", 36, "MNZ" },
                    { new Guid("3c690c36-4850-4a80-aa55-af1229f73d6a"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("76b50b3a-724f-4745-84b0-4e51d1f9d7da"), "锡伯族", 38, "XBZ" },
                    { new Guid("bdccf2af-4055-4d35-a108-df6c43a02196"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("e2453a91-963e-46c4-a035-db3a2e3080ee"), "普米族", 40, "PMZ" },
                    { new Guid("a32e26c4-569b-4c48-830e-2e853ddaeb34"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("75237aad-ce10-4424-a5f3-d39e5dd64938"), "怒族", 42, "NZ" },
                    { new Guid("0a29476d-7c6a-4042-9973-4ed7b203d4f2"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("bc00f0ef-fb13-45f0-b519-595d2f9eba01"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("57d74f6e-3d3f-445d-a8de-f235166ada20"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("02bdbce2-ae42-4d8d-b1b9-c3895b2b8a9f"), "裕固族", 48, "YGZ" },
                    { new Guid("0b6a1d95-e2b9-4580-976f-cf68410de1c7"), "京族", 49, "JZ" },
                    { new Guid("fd957d18-c306-4f38-b579-a602884846f2"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("f6af5586-c80f-40ed-8076-1a5460dd1bdd"), "独龙族", 51, "DLZ" },
                    { new Guid("0254d292-9d71-4630-bb42-d8d58a07ae6c"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("9a3068c1-b136-40f7-8354-3ee482f1b706"), "赫哲族", 53, "HZZ" },
                    { new Guid("43118796-f4e1-4fb6-9a08-36efa30ffa27"), "门巴族", 54, "MBZ" },
                    { new Guid("1b5c0484-7e18-4d60-94bd-75455b5415e0"), "珞巴族", 55, "LBZ" },
                    { new Guid("a5d60ce1-6377-4ebc-83a8-e6df83a76897"), "基诺族", 56, "JNZ" },
                    { new Guid("f2a1a5dc-eff9-4b82-a8a7-9de0004c04ef"), "其他", 57, "JT,QT" },
                    { new Guid("6d0371ab-e9b7-4270-bd3a-493d78833e82"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("8c9c7851-e2e9-4bf3-8c17-310c872e3297"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("bd469f69-b5db-4307-b0e4-d4fdb491c994"), "保安族", 47, "BAZ" },
                    { new Guid("c6ee7cd8-241a-4975-b898-c7bad83ca1ea"), "土族", 30, "TZ" },
                    { new Guid("c60508c0-e5d9-419d-af6e-896c75fd709c"), "崩龙族", 46, "BLZ" },
                    { new Guid("32111b8d-e77f-4a3d-97d0-e7802540a0c6"), "景颇族", 28, "JPZ" },
                    { new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"), "汉族", 1, "HZ" },
                    { new Guid("26c705d8-84c4-4190-8ee7-acab43911bff"), "蒙古族", 2, "MGZ" },
                    { new Guid("ee4d6d4b-88de-4fde-b636-010ea63a5b4a"), "回族", 3, "HZ" },
                    { new Guid("2eae0f9e-036d-4bea-8dde-171eb99f54a1"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("3a6952aa-3015-4b31-aaed-ccb660e4a864"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("740f6ed1-0ce0-4f62-bb54-9d9c55dad8e3"), "苗族", 6, "MZ" },
                    { new Guid("6fa2c84e-5b7a-4ebc-9598-94ff8606c91b"), "彝族", 7, "YZ" },
                    { new Guid("954184ff-29c0-486e-af9a-97e3b84da26f"), "壮族", 8, "ZZ" },
                    { new Guid("dc1d7ba0-f55e-411e-843a-d42e71177289"), "布依族", 9, "BYZ" },
                    { new Guid("3de54b02-f4f8-4cd5-961a-0adbaf324c73"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("dba2da62-50e8-4b07-ae00-6be79559b301"), "满族", 11, "MZ" },
                    { new Guid("825f27b2-7425-4952-a2af-9b70f9596dec"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("172712be-98a0-4e4f-8cdd-b5651a776f71"), "瑶族", 13, "YZ" },
                    { new Guid("fc55508d-48f6-46cb-b174-04a70206996d"), "侗族", 12, "DZ,TZ" },
                    { new Guid("5cba272e-0582-49cc-8f83-85ece943e17f"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("c10625ab-1684-4b27-af37-62ccddfd63b5"), "纳西族", 27, "NXZ" },
                    { new Guid("da4065ec-4989-4b48-9334-d68465c947d3"), "东乡族", 26, "DXZ" },
                    { new Guid("744d4e73-f4e5-4731-b5f3-57be7099c7d7"), "水族", 25, "SZ" },
                    { new Guid("62cec5c1-85ff-4111-b0fc-7cd5ac27efe9"), "拉祜族", 24, "LHZ" },
                    { new Guid("47e386ce-2719-4f65-8db4-2458f0f34d33"), "白族", 14, "BZ" },
                    { new Guid("e2404dae-fd5c-4342-892a-05bf48115fe1"), "畲族", 22, "SZ" },
                    { new Guid("b3bef724-0386-407e-840d-456b38e1746e"), "高山族", 23, "GSZ" },
                    { new Guid("a3e497c2-c08e-422c-8116-60685c499de2"), "傈僳族", 20, "LSZ" },
                    { new Guid("ef9936a8-a615-4636-b7b4-919e996a1629"), "黎族", 19, "LZ" },
                    { new Guid("4566040a-1f91-4cbe-9cf8-c5e1acbefab8"), "傣族", 18, "DZ" },
                    { new Guid("b983052e-1f79-4d52-904a-43187ae0882b"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("80036137-0fb7-41a2-ad90-26ad16538c42"), "哈尼族", 16, "HNZ" },
                    { new Guid("f69a45e4-6f4b-42f3-8368-890258a81769"), "佤族", 21, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("012f637c-2b3e-4c75-858e-7a5f9477815d"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"), "群众", 13, "QZ" },
                    { new Guid("64c693ab-475d-437c-b653-d04a2c7065f8"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("71fc9dd7-e7a1-49b2-ad99-bf3f5d043718"), "台盟盟员", 11, "TMMY" },
                    { new Guid("5816c78b-5187-4c85-959a-59bc50062a2d"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("550b5a20-74a9-4586-be8b-ee8818647715"), "农工党党员", 8, "NGDDY" },
                    { new Guid("0e140c62-ca4a-4617-b3a2-ca02e60b8b49"), "共青团员", 3, "GQTY" },
                    { new Guid("6dc94e40-3726-4de3-a89b-ec500f600b66"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("35900c9d-2334-41d9-9cee-6d124cfe15c0"), "民盟盟员", 5, "MMMY" },
                    { new Guid("0bef4ce4-e142-44f4-9a3b-a6db69c0087e"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("83178a88-6576-45cc-bb78-88a43cf4401c"), "民进会员", 7, "MJHY,MJKY" },
                    { new Guid("db49da61-7b25-4db0-ad0a-5ab053c20593"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("37ad68f0-54aa-4c03-ab08-10a918c4212b"), "中共党员", 1, "ZGDY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleLevel",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无", 5, "M,W" },
                    { new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "初级", 4, "CJ" },
                    { new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "中级", 3, "ZJ" },
                    { new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副高级", 2, "FGJ" },
                    { new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "正高级", 1, "ZGJ" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("0b964833-02cc-4560-9cb4-45aeea903537"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("ea43c76a-bf43-4d4d-b6b6-329202a9f33c"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("5580d019-858f-49fe-a0b3-0b13dc503d0a"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("3d8ede7d-2297-44bd-8f8e-bc910cc20703"), "翻译人员", 22, "FYRY" },
                    { new Guid("fd5a11e2-4872-4cb8-9596-80362e1438bb"), "律师", 23, "LS" },
                    { new Guid("001e00a2-f287-4ccb-9e0b-d2907cac7f0f"), "公证员", 24, "GZY" },
                    { new Guid("408fc627-234e-47d1-b479-41a3cf8dae93"), "海关人员", 25, "HGRY" },
                    { new Guid("81be1edc-70b5-4ac4-8a95-31f3bbcdfafe"), "体育教练员", 30, "TYJLY" },
                    { new Guid("2933457b-acf4-4587-8069-27bbe977e99e"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("16bbdff0-044b-4368-8dbb-2580be30be41"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("40ae0347-100b-40f4-9a99-5ce801b91ee8"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"), "无", 32, "M,W" },
                    { new Guid("b815b01d-0923-478a-88ef-3cb3d80ac254"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("9e7b3f3f-1b0a-4d50-aba1-32735087f5fa"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("27e13aee-8bdf-40c9-bf5d-76fee555b387"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("2ad1a450-78de-4b15-87f2-cf75640c26c7"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("2cc60d12-381c-45ab-956d-60089e51b22d"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("f681abea-1306-4949-bb53-f62b9ab1234e"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("bd3492c1-8051-4ab4-89f4-1a6cf03d2138"), "新闻专业人员", 16, "XWZYRY" },
                    { new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"), "卫生技术人员", 1, "WSJSRY,WSJZRY" },
                    { new Guid("92829a97-b381-4698-8f05-6869a5c4fc84"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("4c3affbf-5111-4973-8fbd-6b07fb9f63dd"), "中学教师", 5, "ZXJS" },
                    { new Guid("82544c43-a457-486a-a2cb-4b717eee17b8"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("1f1bffb9-7819-4b9c-a7f3-220c744a244a"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("e8a22bf0-7f42-4d66-89c5-2fa3fd5205fd"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("910f39af-b690-4a8a-aa11-62a495d8c4e7"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("a397e95f-b3bd-4071-b651-fec0aea062ca"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("fe237910-3e80-461c-ad42-69e9b5f2287f"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("a92e097b-fa47-45a9-b80f-ed7114782061"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("c24319b0-86ef-4da3-b87f-4f1d4af3910e"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("dcd9d524-8fa6-4f2f-9d79-db7019ac12db"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("db7df432-def4-466c-bb49-00c1cd9688b9"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("c3e49e81-4910-44af-8109-3fda1755f2f5"), "借出人员", 10, "JCRY" },
                    { new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"), "试用人员", 16, "SYRY" },
                    { new Guid("fea8c0d1-ebcd-4178-a292-0564742a9e3c"), "内部退养", 15, "NBTY" },
                    { new Guid("c26e1bb7-0e70-4ecb-8361-bbcbe3eb3414"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("a949359f-f90e-4394-821e-58c8dc0fce94"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("3637fca5-7cea-4c13-a523-797a97afcbac"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("5b89349a-7ec7-4d1a-b790-4b5a4cb37475"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("b68eb4d5-f0fb-435e-9629-042e04ed5edf"), "实习进修", 9, "SXJX" },
                    { new Guid("6fb7e11f-2ae1-419f-ae8e-2e6543326039"), "人事代理", 2, "RSDL" },
                    { new Guid("96ddfb3a-311e-4547-9093-9c772f5838d3"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("d465f5fa-538a-42d1-b873-b66fac5c2c22"), "返聘人员", 6, "FPRY" },
                    { new Guid("ab407b34-9559-4906-b598-7d6e6ec600fa"), "辞职人员", 5, "CZRY" },
                    { new Guid("bd74f213-bc03-4358-9061-38eadb99536e"), "离退人员", 4, "LTRY" },
                    { new Guid("20d948fc-7f06-4134-b83f-4a957996f51d"), "临时人员", 3, "LSRY" },
                    { new Guid("bb97bcdd-1cf0-4e9f-94b4-925a30ed331d"), "在编人员", 1, "ZBRY" },
                    { new Guid("4cb8ad1f-dfe0-45c0-8343-200f0ace364b"), "除名人员", 8, "CMRY" }
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
                    { new Guid("3572d2cd-b0be-44a2-9d21-8f90198684ee"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("4a8a8a1c-d30c-4e4e-aac9-9f35c2155377"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("e3c47067-00a9-42f5-a502-5c2244092004"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("73959df0-01c2-4f33-a73f-fc257e07bdf2"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("5723497f-ada6-404b-a287-d359c496b3fe"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("606dd894-d68b-4208-b1d6-6f41ad8e52d2"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("741d6189-e71c-4b32-9e2b-c077a7defe03"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("f1c3b99d-8c48-40f8-a8e3-55fb059c346b"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("dc98a5f0-109c-4dac-b70a-562800bee327"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("80d1cb2d-6e71-409d-992c-40473777fe77"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("05e76e6d-4ef7-4c86-adfa-6e1f64ac0258"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("25719e70-0d8f-4c1d-9f81-5755f94c979e"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("a9d9561c-75d8-473b-b759-76dac1046899"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("43f7d4a5-0d67-4d7b-a6b7-8af2ca6e2bf6"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("a3a48790-73db-4cef-a928-ed606e28689d"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("89f5ff32-9f1a-4a94-8bdd-a023c20057c0"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c7299e61-6f35-4fae-a32c-11401f89c9a5"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("483c24ea-0d17-47bd-ae93-507c08edad47"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e7624edf-e523-44de-ad86-6be4fe924e12"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("172da8e9-f6b6-481d-9d6c-aad1a7acb67c"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("0c957da8-6b27-45af-83ec-342e186442d5"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("5dd44a1e-ab5b-49f3-8a2a-d0fe8fb3b4e1"), "Index", "ComMarriage", "婚姻状况", 13, "HYZK", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("e93cc34f-07ae-4da4-a7c8-0600d40ad98f"), "Index", "ComDegree", "学位", 12, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("1690dbdf-e77d-40c4-8d49-b411aded3db4"), "Index", "ComEducation", "学历", 11, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ddf6d657-b15e-488f-820b-c49dc66c07d7"), "Index", "SysEmpType", "人员类别", 10, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("2a2670e6-ab5a-4422-8b5e-a44b18f6d70e"), "Index", "ComAdminDuty", "行政职务", 9, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("2ab63b5d-014a-4d37-979c-b6a6c28ef3f8"), "Index", "ComProfessionTitle", "职称", 8, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("2b295c68-ec11-4c12-a475-b0e1959d4bd4"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("f4e50ea0-b522-485f-9791-914783de91b8"), "Index", "ComProfessionTitleType", "职称系列", 6, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("29a846eb-2161-4a6d-a2a2-684120cef2c9"), "Index", "ComPolitical", "政治面貌", 5, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("b72755eb-5ece-4c7a-8271-617ff45bda85"), "Index", "ComNation", "民族", 4, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("e36df6ed-0dc0-4972-9d47-f17b55f972f8"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("d35f6cc5-9171-428a-b841-5bd69986b9db"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("d36fdad2-004d-4a3a-bcc3-30cdbbd6b9f9"), "Index", "SysDept", "科室信息", 14, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("482e2005-2f0f-4766-a7e8-a18126f7f0fc"), "Index", "ComProfessionTitleLevel", "职称级别", 7, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("8dfc9898-dbe4-48ab-bbcc-b758715af43a"), "Index", "SysEmp", "人员管理", 15, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysEmp");

            migrationBuilder.DropTable(
                name: "SysNavbar");

            migrationBuilder.DropTable(
                name: "ComAdminDuty");

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
                name: "SysNavbarType");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleLevel");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleType");
        }
    }
}
