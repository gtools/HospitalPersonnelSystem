using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class frist : Migration
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
                    AdminDutyCode = table.Column<Guid>(nullable: false),
                    IsPost = table.Column<bool>(nullable: false, defaultValue: true),
                    TypeCode = table.Column<Guid>(nullable: false),
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
                    MarriageCode = table.Column<Guid>(nullable: false),
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
                    { new Guid("bb34f157-6cdf-4d9f-a850-780801500942"), "院长", 1, "YC,YZ" },
                    { new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"), "无", 15, "M,W" },
                    { new Guid("96038ac0-39db-4202-b8ee-361485f215b1"), "返聘", 14, "FP" },
                    { new Guid("33e214f5-7235-462b-9ab2-4f573ec0d7d3"), "干事", 13, "GS" },
                    { new Guid("b9676ec1-03a2-4879-86c2-4b28f04bb1b2"), "科员", 12, "KY" },
                    { new Guid("b2fddfb4-0040-4dfe-9f3b-e693b4d8e093"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("e9f4e130-aeed-4c4e-a9a9-5c5832d8dcc1"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("f12f7f92-3365-43ca-be3d-f90cc2dc785b"), "副主任", 9, "FZR" },
                    { new Guid("7eab3162-aaed-43b1-ad0d-d32b3599ac97"), "大科主任", 7, "DKZR" },
                    { new Guid("a03f376f-c6e1-4bd6-90e6-ae28c9c0964f"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("c2633dff-8499-4809-9e95-b1296159e523"), "团委书记", 5, "TWSJ" },
                    { new Guid("b543b9a0-4b67-412b-88d4-954f2e642346"), "副书记", 4, "FSJ" },
                    { new Guid("6f66db6f-4315-434a-a9eb-49d38aea1d55"), "书记", 3, "SJ" },
                    { new Guid("140064e5-adb0-4b51-930c-98f0a689ef34"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("26852689-2cf4-4fe4-b7ee-16b1f06d28cc"), "科主任", 8, "KZR" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("3002aa36-f309-47a5-a170-42f89f92ffc0"), "无", 5, "M,W" },
                    { new Guid("41e0d5f3-40f0-421f-ae06-bf7cc2acfb97"), "学士", 4, "XS" },
                    { new Guid("833045e2-bc21-4a5a-98cd-159892401293"), "博士", 2, "BS" },
                    { new Guid("a348b5a6-a6d2-4edf-9282-cb818f72de2d"), "博士后", 1, "BSH" },
                    { new Guid("c9652c38-a7a4-485b-ba65-0d20331faa09"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("61fbbb24-931f-4af8-b334-8d6ccf238e1a"), "博士研究生", 1, "BSYJS" },
                    { new Guid("5dcc9704-28e1-44f4-a1bd-50f3651d7611"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("32f8c1b7-5951-4d9d-9752-c52a8061fafb"), "本科", 3, "BK" },
                    { new Guid("3ec66f80-c869-40c2-a8b1-68c3806d5de7"), "专科", 4, "ZK" },
                    { new Guid("d2c2d95a-70ac-462d-8332-69416dd81dfd"), "中专", 5, "ZZ" },
                    { new Guid("a4178c88-4b84-4268-a91d-78272eab8f56"), "高中及以下", 6, "GZJYX" },
                    { new Guid("c3b13918-19c0-4e62-9996-3a5820e76062"), "技校", 7, "JJ,JX" },
                    { new Guid("f790ef85-6ab6-4d50-a568-d284ba2e11f7"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("e938b3d7-2153-4e3e-a235-da966f9cdcea"), "男", 1, "N" },
                    { new Guid("58e3d735-d6f1-4b2e-8898-5c4183e3bc81"), "女", 2, "N" },
                    { new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"), "未知", 3, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"), "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK" },
                    { new Guid("b98fcc64-5af9-4bae-96d3-5b3b91faec43"), "离婚", 4, "LH" },
                    { new Guid("224f2032-2a28-46ed-a69d-3fba3061398b"), "未婚", 1, "WH" },
                    { new Guid("76561c35-0a22-4c4e-8973-304f30490b0b"), "已婚", 2, "YH" },
                    { new Guid("dd504b02-d62d-4c93-bd92-0ced1a6ae345"), "丧偶", 3, "SO" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("152307be-cbdc-4720-bf2d-9664fc7b0904"), "仫佬族", 32, "MLZ" },
                    { new Guid("3ca80594-40d6-486b-be1c-48bbae272080"), "羌族", 33, "QZ" },
                    { new Guid("1209f40f-796b-4d69-b525-ef697931f646"), "布朗族", 34, "BLZ" },
                    { new Guid("9abc7544-4ad8-4f5f-a14f-bea6d13a9b33"), "撒拉族", 35, "SLZ" },
                    { new Guid("7f16ddf8-1f31-4ce1-bd9e-176bc1b0dbdb"), "毛难族", 36, "MNZ" },
                    { new Guid("168b895a-b4d5-456e-b37e-1e6bb4f78bab"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("d574499a-6039-4bd3-8da2-5164641fa549"), "锡伯族", 38, "XBZ" },
                    { new Guid("466c23f4-c7e4-440d-804f-ebf1cb76549e"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("2f79f709-f806-4046-bc28-159bca335ca9"), "普米族", 40, "PMZ" },
                    { new Guid("eacd5cca-8c3d-4d4f-b473-0e5aea715955"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("51c37d55-610e-481e-a9d6-5f97d685c09d"), "怒族", 42, "NZ" },
                    { new Guid("0f0a108b-6c5a-4943-ac23-ab53efda7099"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("ce579cb3-a590-4696-a77b-51cb8727d9e2"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("44f23afe-0a55-433d-8e4d-d95ab39e5e73"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("14c4aabf-833d-4ce2-ad6b-4c565f6f7e92"), "裕固族", 48, "YGZ" },
                    { new Guid("20dec25c-d768-47c7-ab12-5ec904d6e26b"), "京族", 49, "JZ" },
                    { new Guid("f9cd6996-7b08-4799-832a-683501c5b385"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("99e41b02-9ec1-4fbb-97e2-f493259a3ad8"), "独龙族", 51, "DLZ" },
                    { new Guid("92c9a26e-67d9-4782-a96c-c0c104aa150d"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("accf852a-a4e0-4b25-b12e-21e645d785cb"), "赫哲族", 53, "HZZ" },
                    { new Guid("83a97d2d-35fe-4d28-92d2-e50fd499710a"), "门巴族", 54, "MBZ" },
                    { new Guid("d6f7df00-b722-4e70-b4f7-88845fb0e539"), "珞巴族", 55, "LBZ" },
                    { new Guid("c14ef177-26b5-4e27-97e8-db922f11bb46"), "基诺族", 56, "JNZ" },
                    { new Guid("d7d1e688-e40b-48f2-9573-6d152dddcb95"), "其他", 57, "JT,QT" },
                    { new Guid("efc4b81d-d65d-4573-aad5-7a01df71402c"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("8eb796ca-7875-4233-bea7-5ec5833b2937"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("3123a89d-e97b-4491-bc4d-32cd31511694"), "崩龙族", 46, "BLZ" },
                    { new Guid("45a2357e-d525-4583-8788-2b11fa2b932f"), "土族", 30, "TZ" },
                    { new Guid("ec0e8873-2ba6-472b-a943-6ef5c2eb8d59"), "保安族", 47, "BAZ" },
                    { new Guid("efd6bd4f-8eb9-4118-859b-cbb660ca8741"), "景颇族", 28, "JPZ" },
                    { new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"), "汉族", 1, "HZ" },
                    { new Guid("8ffb4df6-a4a8-49fd-855d-6965910b83a5"), "蒙古族", 2, "MGZ" },
                    { new Guid("48d44109-0140-4797-a01c-7ff1a3c0bcd4"), "回族", 3, "HZ" },
                    { new Guid("a0318f52-d049-414e-a997-a7d15605c70f"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("fe07f3ba-26be-47db-b5a9-0fef14f552f4"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("324ba6c7-17c8-4b14-a6b0-be3d2e33fa46"), "苗族", 6, "MZ" },
                    { new Guid("15547824-c1b9-47b2-afc2-05df11c42e82"), "彝族", 7, "YZ" },
                    { new Guid("7bea4600-d252-4ee1-b140-8a65280defce"), "壮族", 8, "ZZ" },
                    { new Guid("07a34931-c620-4371-8c5f-7b67fc219349"), "布依族", 9, "BYZ" },
                    { new Guid("8cda4901-bfef-4a5c-ab96-46f4f2705271"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("f0fdc89f-d89a-4ab9-a298-45d7aad50de6"), "满族", 11, "MZ" },
                    { new Guid("0346d526-1a85-4074-8825-52de415ceffe"), "侗族", 12, "DZ,TZ" },
                    { new Guid("e00f72e6-b7f2-499e-ae90-b8f046f0389b"), "瑶族", 13, "YZ" },
                    { new Guid("d4ba2408-443e-4279-841b-5bf856920e99"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("abc5634f-648e-42f6-9b1c-c35536dbec72"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("e478d2d5-da32-45a6-a56b-e99254688eae"), "纳西族", 27, "NXZ" },
                    { new Guid("81e1f806-f6b6-485a-a7ae-cb4c31f76898"), "东乡族", 26, "DXZ" },
                    { new Guid("ec6688fc-809b-4990-98ec-19be9e08490f"), "水族", 25, "SZ" },
                    { new Guid("6d676c8b-3249-43a0-82df-6cf818089112"), "拉祜族", 24, "LHZ" },
                    { new Guid("6f15051a-a852-4bfb-bca6-48e29a3003cc"), "白族", 14, "BZ" },
                    { new Guid("3a582cd2-b976-4ccf-bd1e-0957080a372b"), "畲族", 22, "SZ" },
                    { new Guid("357748b8-2a3b-41c5-b0c6-38f589a9a021"), "高山族", 23, "GSZ" },
                    { new Guid("8dae7979-f7ed-4251-ae1a-2e4e26153651"), "傈僳族", 20, "LSZ" },
                    { new Guid("bfc768c1-6728-4c81-8033-ea359620e6ad"), "黎族", 19, "LZ" },
                    { new Guid("2052b3c4-99b9-4ba3-b631-c425bfd8056e"), "傣族", 18, "DZ" },
                    { new Guid("2638dd1c-d78d-4eaa-b577-3e89463229fb"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("b9f46974-ef79-4c50-bb68-347e0665b947"), "哈尼族", 16, "HNZ" },
                    { new Guid("10645c61-d75d-4370-892c-cb51c3753a22"), "佤族", 21, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("b68b4038-45c6-4aed-aab3-217059eec489"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"), "群众", 13, "QZ" },
                    { new Guid("98e5c6ba-d933-400c-b6cf-11ad60b7ed7c"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("b068773f-bd95-49e8-8a0b-852f5221e3f5"), "台盟盟员", 11, "TMMY" },
                    { new Guid("e6591dcc-f1ce-47ab-8ee6-e495d7700c58"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("f518f303-6559-4475-9950-9e49588e8f2a"), "农工党党员", 8, "NGDDY" },
                    { new Guid("4aba41fb-16be-42f1-bd22-74d6fe891749"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("595aa4b3-c527-47bb-a8cc-22599a409b06"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("707d385f-04d8-4185-b7d5-b60f603fb6fa"), "民盟盟员", 5, "MMMY" },
                    { new Guid("d6867a95-76dc-42c1-a6ff-c42e521581dd"), "民进会员", 7, "MJHY,MJKY" },
                    { new Guid("fa1aaf53-c56b-445a-a32f-c48d90892ad2"), "共青团员", 3, "GQTY" },
                    { new Guid("14c293bc-1c6e-491b-a0e6-c0cad522794a"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("0c263995-d371-4895-b95f-4a58850f19c8"), "中共党员", 1, "ZGDY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("62d5a48c-5452-488d-a1ea-6078949db110"), "卫", 1, "W" },
                    { new Guid("009a0766-43e0-4cda-a008-e705d8604dab"), "工", 2, "G" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleLevel",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无", 5, "M,W" },
                    { new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "初级", 4, "CJ" },
                    { new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副高级", 2, "FGJ" },
                    { new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "正高级", 1, "ZGJ" },
                    { new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "中级", 3, "ZJ" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("8ea26d25-52bc-444a-9c12-f84518078fae"), "公证员", 24, "GZY" },
                    { new Guid("84827a85-670c-4d28-ab54-11efcf04f353"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("62ebd591-0c68-4e6e-9bc0-24ed9e64611e"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("52a6e3f0-df88-4354-bee4-2deac97bfb25"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("ab8e374f-da79-4be5-a46c-4de747c78812"), "翻译人员", 22, "FYRY" },
                    { new Guid("ee15a20a-be29-4d7e-a95c-51e51ef398c8"), "律师", 23, "LS" },
                    { new Guid("aa276c49-bdd3-4f16-bd51-0d5317881d64"), "海关人员", 25, "HGRY" },
                    { new Guid("d662f8f0-d434-467b-81fc-1e1abaa831b0"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("f632075f-081a-416c-a69b-2f71a36e1de6"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("828b4c4d-a1a6-488d-9a1e-e23ff1c070e0"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("fbb926df-0ce9-4b84-94a5-b39176c6a88e"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("e7037510-b73b-4f75-8cc2-46aa85b9d1a3"), "体育教练员", 30, "TYJLY" },
                    { new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"), "无", 32, "M,W" },
                    { new Guid("6e3ee3de-2b73-4858-865b-7476124b4f81"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("4ea883d8-cf16-4a6e-8a5a-9b0b3f036708"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("5cce4e5d-c263-44b3-aa02-61404082f39e"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"), "卫生技术人员", 1, "WSJSRY,WSJZRY" },
                    { new Guid("433234ac-9c1a-41be-af32-b3c59c325e34"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("1fbf0519-36d5-4c20-b275-d108ec299ac3"), "新闻专业人员", 16, "XWZYRY" },
                    { new Guid("8eed4cff-7f80-4ecf-990a-c6888be90933"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("aa47aa17-feb8-4988-850d-ac152aab6a42"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("e3540f40-d87a-4237-ad66-6361a8544e06"), "中学教师", 5, "ZXJS" },
                    { new Guid("5b93f809-8fc1-4536-8303-de486848429d"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("fe6ed81e-c725-4229-9c20-a412502d07ce"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("55911415-fae3-489d-aaad-d62909abc425"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("1c99a8f6-95eb-4509-a324-88062cb347db"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("38dc4446-2fa4-4cf6-95a5-4e1fdb80ec3e"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("0f456314-ca2b-4348-a9ba-8006f2ff0d3f"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("1abc51e0-7961-4191-85be-c0d6f326ade8"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("69eb6a4c-e0c3-488a-8c3a-2df5e48ce834"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("b192f724-a637-4e58-ac67-c3365800c79f"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("23fd2ad4-a4f8-421e-8e40-4bcfa7c0b235"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("83825404-512a-4400-bb34-9de9a2dd6ff1"), "借出人员", 10, "JCRY" },
                    { new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"), "试用人员", 16, "SYRY" },
                    { new Guid("4913df20-319c-4019-b89a-8cc89b015623"), "内部退养", 15, "NBTY" },
                    { new Guid("92fd27bc-4d2c-4f98-b8e6-512d7f26b270"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("c008e596-f50d-478b-87a0-039f9b32fe8e"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("82133b64-c8de-491a-afa8-d52954c3fe7f"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("0fd30ada-d031-46df-ace5-2f0a9c95ffd9"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("13633d73-053c-4000-b2d5-90a04273df5c"), "实习进修", 9, "SXJX" },
                    { new Guid("7141605b-d1eb-410e-b966-eafde0b823c9"), "人事代理", 2, "RSDL" },
                    { new Guid("1721f7e4-e431-4173-9145-91018cd27518"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("9b1848f4-8315-4cb8-9f5e-8a54f0804d92"), "返聘人员", 6, "FPRY" },
                    { new Guid("ecbaadc8-5eea-436f-85d4-4a47482760e6"), "辞职人员", 5, "CZRY" },
                    { new Guid("456c2106-89f9-4e92-9008-b281b7cb85cc"), "离退人员", 4, "LTRY" },
                    { new Guid("b1684ad9-ab97-416e-a9e9-0c442f02a2d8"), "临时人员", 3, "LSRY" },
                    { new Guid("90b1984b-3a7b-4925-bb7a-98d97b612362"), "在编人员", 1, "ZBRY" },
                    { new Guid("adea9395-64c6-46be-9f82-8e720f3078f1"), "除名人员", 8, "CMRY" }
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
                    { new Guid("3649058d-92cb-4351-be67-134df9c1be8e"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("ee287ca4-f361-4ee5-82d0-764ed3a164fc"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("01210774-9c9f-48f3-b750-dfb1ea5f4d97"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("ea08db48-01f2-4ead-9a07-c303d3762706"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("6b7d5e1a-5c5d-4f90-b829-276d8f217ef2"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("7252961d-20cf-4e8f-bd17-ade5c64fe857"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("da7ed7e3-a260-45d7-b4ac-9bc588578ad0"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("a34f639b-4559-40f0-87b9-1e71f2b3e288"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("98f932ad-ce19-4389-a0f3-ebb096a55f46"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("5dea5587-8714-4a02-a6e9-62f77929eb13"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("7ec6cc3a-7efe-44e4-a76a-3142fcd47513"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("16271a5b-ba0b-49ff-9563-633adcda5016"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("bb0c94d0-cb37-4344-9b25-1f661a377277"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("8ff47f93-3e38-49a5-b274-fa36c9f77389"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c21685da-fa19-47dc-bfa8-e00c1652b772"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("5d426158-538b-4cdb-aa20-5223fe0b9036"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("ed5f7df2-d03f-43b7-b895-c153ca680603"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c3f78bcf-7fa6-4e72-8aa2-1c7ed124d54b"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("906f1fd7-ef2e-440b-8b52-d97d957db8ef"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("947ed658-509e-4573-9c41-3399c56f6165"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d5595f16-7642-4815-8131-1b6d705068e3"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("f00e8e02-05a5-473b-adc5-fae9a550e78d"), "Index", "ComMarriage", "婚姻状况", 13, "HYZK", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("008fb261-dca0-4c5b-8859-b4fcbd0dcbb5"), "Index", "ComDegree", "学位", 12, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("7da9fda9-f37d-4d93-bf78-ccced1ed7728"), "Index", "ComEducation", "学历", 11, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("440aa228-85ef-41e1-9a7e-1a0f2e08cfa5"), "Index", "SysEmpType", "人员类别", 10, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("8bea0ab3-f76a-47f7-b886-c65081ac7dc2"), "Index", "ComAdminDuty", "行政职务", 9, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("8a76b950-f16f-475d-bb8a-dcc0269aad4a"), "Index", "ComProfessionTitle", "职称", 8, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("c3408793-ee8c-41f3-b8f8-6f24cb5d3d67"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ab72c428-66ee-4f4f-b737-24f49011360a"), "Index", "ComProfessionTitleType", "职称系列", 6, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("880c9ae9-7d0e-4ceb-a1ce-a9f14b09323a"), "Index", "ComPolitical", "政治面貌", 5, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("837e43c7-993f-4813-bf41-c53e7ae7881b"), "Index", "ComNation", "民族", 4, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("5be1e55c-b6d7-48a0-b4a1-5118d975a785"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("94183da2-9554-4767-bc57-fe32a2fa536a"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("62848550-deca-405a-a287-fcd8f7d9ace9"), "Index", "SysDept", "科室信息", 14, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("ffa2aab6-a2f7-4f84-96e9-e5e693cfe295"), "Index", "ComProfessionTitleLevel", "职称级别", 7, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("6b685328-3999-4c34-b16f-b1200916a448"), "Index", "SysEmp", "人员管理", 15, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
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
                name: "SysNavbarType");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleLevel");

            migrationBuilder.DropTable(
                name: "ComProfessionTitleType");
        }
    }
}
