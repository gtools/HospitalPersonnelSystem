using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class sysemp : Migration
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

            migrationBuilder.InsertData(
                table: "ComAdminDuty",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("520633ee-c48b-4db6-aaa9-3382899b0e42"), "院长", 1, "YC,YZ" },
                    { new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"), "无", 15, "M,W" },
                    { new Guid("8e8adf37-45a2-4ea4-ab5a-ee37a0b3fec9"), "返聘", 14, "FP" },
                    { new Guid("b1004de7-dd15-4029-83c6-6e39d4ceb601"), "干事", 13, "GS" },
                    { new Guid("42f61d84-5911-4ee5-8221-8d60754a70c4"), "科员", 12, "KY" },
                    { new Guid("0f0ef0bf-0c1d-4375-8d1d-c83fb9d56ace"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("fa86e41a-b4d3-4f16-881d-b4cd9241295f"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("9b4f29a0-fcec-4151-9b55-ca0275449f96"), "副主任", 9, "FZR" },
                    { new Guid("f893a978-ba55-4f49-b234-124981ba0760"), "大科主任", 7, "DKZR" },
                    { new Guid("55deea6e-5ca1-4d0e-823d-c04a17aa3868"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("059b1771-8cf8-41d6-8325-5dd9ac140c87"), "团委书记", 5, "TWSJ" },
                    { new Guid("b19f79a9-adea-4955-a0df-841ae471f83b"), "副书记", 4, "FSJ" },
                    { new Guid("9b823378-d715-4d1b-82b1-49f56a602f32"), "书记", 3, "SJ" },
                    { new Guid("1988ddf2-8fcc-4347-9380-f357e9822a98"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("0e570ef2-9f7f-40c2-b208-8cfa7561694d"), "科主任", 8, "KZR" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6b2ea297-6c7b-4a9c-bfeb-9a50a1e86d2c"), "无", 5, "M,W" },
                    { new Guid("0f3aa531-8244-4cb5-bba2-30d7414625b1"), "学士", 4, "XS" },
                    { new Guid("84308527-af9b-46f7-946d-1e353e9098f5"), "博士", 2, "BS" },
                    { new Guid("b48d03cf-9647-4957-a7a9-58d1914309b1"), "博士后", 1, "BSH" },
                    { new Guid("b8647faf-c493-4b31-aefc-59490635a24c"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("80ea3174-7fda-4692-9ec2-3db8495588bc"), "博士研究生", 1, "BSYJS" },
                    { new Guid("cddcdfb2-24e5-46b8-82ec-3f43791fcc32"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("d7558a54-43be-4303-bf11-08f2bbafffa6"), "本科", 3, "BK" },
                    { new Guid("79f5e3cd-af4a-4527-8878-41a22bd79d46"), "专科", 4, "ZK" },
                    { new Guid("5ccfbbd8-0f8a-4f65-93bf-799f075bfb86"), "中专", 5, "ZZ" },
                    { new Guid("e344ad42-eb61-417e-804d-89c71eca7e6c"), "高中及以下", 6, "GZJYX" },
                    { new Guid("47ac947a-7fbb-4a92-96b8-f0c75ef136aa"), "技校", 7, "JJ,JX" },
                    { new Guid("1f8000e0-d062-4466-97db-040474162fab"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("07fa2344-50aa-4dba-9962-8779ef6ecc60"), "男", 1, "N" },
                    { new Guid("c054f047-5fbe-4dc3-ad3c-32037e18b383"), "女", 2, "N" },
                    { new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"), "未知", 3, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"), "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK" },
                    { new Guid("30b0e34d-cb46-4650-afad-5e8b5288ed05"), "离婚", 4, "LH" },
                    { new Guid("05e32b18-149d-4af5-9e8a-eb630b250cf3"), "未婚", 1, "WH" },
                    { new Guid("d533333e-8f04-40da-983e-eb4ec079eda2"), "已婚", 2, "YH" },
                    { new Guid("eca1931a-e69a-4fda-9f5d-a2c4cfd7388e"), "丧偶", 3, "SO" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("d6b6fc5f-15df-459d-8e25-9199d073d306"), "仫佬族", 32, "MLZ" },
                    { new Guid("60178d1c-62ab-4179-a367-f7ab18e3e709"), "羌族", 33, "QZ" },
                    { new Guid("d50ebd1e-8a70-4db1-8abf-910567bfcf1f"), "布朗族", 34, "BLZ" },
                    { new Guid("55198a23-15ee-493e-9715-3ca3ae0354dc"), "撒拉族", 35, "SLZ" },
                    { new Guid("24fe8b69-bd16-4d75-922b-a4717644dff6"), "毛难族", 36, "MNZ" },
                    { new Guid("775f88ae-a150-4a2e-a903-5b4cfcdfa830"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("5886b1bd-23dd-46c8-8574-d036bcd53628"), "锡伯族", 38, "XBZ" },
                    { new Guid("92769fcd-b0ba-42eb-b6f7-fd587c9bf914"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("7c5d21e1-9a8a-4567-a022-9c54e185a18e"), "普米族", 40, "PMZ" },
                    { new Guid("13ee562f-3089-479d-b5ef-d119b1a7db7e"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("eebc2c3b-de77-4752-b92a-ccce878f3e52"), "怒族", 42, "NZ" },
                    { new Guid("bdbdb51f-fc2e-482c-a64d-6e77c1591fa2"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("2f24f752-c40a-4e5a-bb39-31e5e6aef999"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("89d82a89-81b5-4e91-a990-ee7a1a8bdc50"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("4c7aa156-360e-441d-ade3-5c9a82bb0a30"), "裕固族", 48, "YGZ" },
                    { new Guid("62686e0e-34c5-4f22-b0a7-f90cebb0f122"), "京族", 49, "JZ" },
                    { new Guid("6b51952e-2322-4b0b-b767-5e9a9b3d02f9"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("d541fc97-e8eb-4fbe-839a-666c279912b4"), "独龙族", 51, "DLZ" },
                    { new Guid("17fd5fd9-4de9-4a4c-a7a9-14cf22e8ce6a"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("10b0581e-c4a2-4d9e-8744-06b78a8c9add"), "赫哲族", 53, "HZZ" },
                    { new Guid("01ff7f59-a876-4ac6-a30e-8a46f59f9e2d"), "门巴族", 54, "MBZ" },
                    { new Guid("a6eb49de-3d3b-4426-9638-5d5c292afdd6"), "珞巴族", 55, "LBZ" },
                    { new Guid("e435c530-8292-46c8-b98b-757f7f7f8586"), "基诺族", 56, "JNZ" },
                    { new Guid("f720f863-85c8-47d4-9a17-7b146795bd1f"), "其他", 57, "JT,QT" },
                    { new Guid("ce4c48d9-be64-4a73-8f85-ef03b5fdf1f6"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("05730a1d-9803-4800-af3e-ad0973c20c37"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("e257e89c-3225-4e40-b080-0ffd55989b6a"), "崩龙族", 46, "BLZ" },
                    { new Guid("29e11f7b-a6f4-496d-ba53-74d81c4c771f"), "土族", 30, "TZ" },
                    { new Guid("b5fa4b2d-d54a-4af0-a3b6-eb2ad125fca6"), "保安族", 47, "BAZ" },
                    { new Guid("3c4fa3f4-4e05-4712-b9cc-54d7d232dd6f"), "景颇族", 28, "JPZ" },
                    { new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"), "汉族", 1, "HZ" },
                    { new Guid("125af20a-05f2-4360-ad22-c31c96fee7d2"), "蒙古族", 2, "MGZ" },
                    { new Guid("f6593d03-2150-4787-9eb7-56cfc6e42af6"), "回族", 3, "HZ" },
                    { new Guid("062054c0-596b-44e2-a474-95b212f3ed81"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("dee4d2f3-9aed-4a68-bbf3-3b822b3a975d"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("defb1d09-ea53-4851-847b-3d2384ecec02"), "苗族", 6, "MZ" },
                    { new Guid("cb36a1b6-82f7-4b56-8b6e-4ce9b3c090a8"), "彝族", 7, "YZ" },
                    { new Guid("f66dc976-43f3-48a5-9cbd-984a1e541a5d"), "壮族", 8, "ZZ" },
                    { new Guid("a2b29557-6233-4f8e-955d-51f65d80c43e"), "布依族", 9, "BYZ" },
                    { new Guid("0e6662af-45c6-4520-9fe1-bbaeecfb86a0"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("0cff6174-5352-45ba-b473-e8af9c95c99b"), "满族", 11, "MZ" },
                    { new Guid("d05f6a47-6239-4771-899e-e6d1f792c5e6"), "侗族", 12, "DZ,TZ" },
                    { new Guid("4beab6b5-7df2-447d-8484-455f3e99524d"), "瑶族", 13, "YZ" },
                    { new Guid("ab4117fc-334e-4b6f-b6d0-08357ddc2ebe"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("a88f687c-f0f9-4f2d-93f9-db1d300f29d9"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("611b5190-58ed-4a98-901d-1d72d4dcf5e1"), "纳西族", 27, "NXZ" },
                    { new Guid("8a4249e1-21b4-4bf8-a344-9910aaa596ad"), "东乡族", 26, "DXZ" },
                    { new Guid("c5a44058-8b12-47a8-8295-5d1bd7f9983e"), "水族", 25, "SZ" },
                    { new Guid("a7ecfbb3-8be7-48a9-ac1f-6804d807a8cf"), "拉祜族", 24, "LHZ" },
                    { new Guid("0e200734-36da-47c8-85fb-02b1c264abc4"), "白族", 14, "BZ" },
                    { new Guid("220930b3-9705-497f-b06a-a2e563d6742a"), "畲族", 22, "SZ" },
                    { new Guid("2b191f90-2104-4414-b613-c679856a7433"), "高山族", 23, "GSZ" },
                    { new Guid("19f373ce-ffcf-4cf8-9aed-cc4bfc8180c6"), "傈僳族", 20, "LSZ" },
                    { new Guid("15d70dbf-78f6-4f28-97ed-30dcb9842e5d"), "黎族", 19, "LZ" },
                    { new Guid("782e08c8-1f74-4590-a97f-de6cfafe2b7f"), "傣族", 18, "DZ" },
                    { new Guid("625d609f-05cd-4d99-9811-8b9eb3eb6459"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("e3096d33-71dc-4e7d-a6f8-31cdfd2b72d6"), "哈尼族", 16, "HNZ" },
                    { new Guid("1ba3efe3-2fdc-4a6a-95e3-dc9c06b59013"), "佤族", 21, "WZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("8525cba8-9d54-44ec-b3ac-584bc35e7b11"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"), "群众", 13, "QZ" },
                    { new Guid("6bf1c928-f204-4ebb-9d0a-9736df99e925"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("cccce48d-4daf-4fae-b51c-aaa4f232c26e"), "台盟盟员", 11, "TMMY" },
                    { new Guid("a1cf9baa-4949-4121-9e9f-b90dcd5aa19b"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("8b60d9d8-a225-4043-a0dc-9ef3d6ccb029"), "农工党党员", 8, "NGDDY" },
                    { new Guid("3704f305-4a12-429a-90c5-d8a26cadac87"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("bb71467f-d418-4722-9d73-81ef8a457dbc"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("435e8a81-e243-443d-8cff-d2fdf71f6470"), "民盟盟员", 5, "MMMY" },
                    { new Guid("312a1908-831c-44db-bd24-1ef37d1b3fbe"), "民进会员", 7, "MJHY,MJKY" },
                    { new Guid("356af1cb-7437-4dfd-894f-dd4f1b911746"), "共青团员", 3, "GQTY" },
                    { new Guid("920420a9-ebe1-4774-8730-f32466267138"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("5a10dcca-f743-48d4-bd71-dcc8cbc4b251"), "中共党员", 1, "ZGDY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("442c036f-dde7-4ab0-aad7-f4a4afd7465a"), "卫", 1, "W" },
                    { new Guid("4dbe8911-71ed-4fde-a92f-a1310a8bb666"), "工", 2, "G" }
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
                    { new Guid("46977799-a117-4544-a8af-00252ac42c38"), "公证员", 24, "GZY" },
                    { new Guid("596592e1-67e4-48f9-99c9-47dce1c9f342"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("3919e6a1-ffa8-4d29-ac7a-cb746faaea8e"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("c3cd2ac4-52c1-4129-9f68-5d3a876efaab"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("2f1eec53-cbf6-4c9d-b909-533d2d8ddc66"), "翻译人员", 22, "FYRY" },
                    { new Guid("4349d50f-971f-48d0-82bd-e7ce6d92a06f"), "律师", 23, "LS" },
                    { new Guid("ee7b36e7-6123-44d7-aad5-ad90f8d52af7"), "海关人员", 25, "HGRY" },
                    { new Guid("4a101a72-bd30-4eca-ae31-fb5531258e6d"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("30df1e4d-4641-432f-b0d1-f265f243afaf"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("5b451f50-8197-4c9a-9106-6e48a346a6ca"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("87fae6a8-276a-40e2-a12e-62e3aa0909e0"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("95c3e533-1d6b-407d-9247-5e7f62be6c55"), "体育教练员", 30, "TYJLY" },
                    { new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"), "无", 32, "M,W" },
                    { new Guid("9403ce46-e0a2-4a6a-95ff-9c3cca15ab50"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("b2e7614f-f9a1-43b8-a704-50ff24dd6815"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("864f3319-7dfe-4b67-91d0-99457407b804"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"), "卫生技术人员", 1, "WSJSRY,WSJZRY" },
                    { new Guid("51b700cf-bad3-4ff2-8a98-0678ccd1521d"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("0dfdd501-a202-48ed-ab7a-de986748153d"), "新闻专业人员", 16, "XWZYRY" },
                    { new Guid("ea7c2801-ee7e-469e-a855-1347c9c96b53"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("abf1a772-09df-4c65-a5f9-0ceffd085579"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("b2637983-d85e-40d5-8001-cccd4601601f"), "中学教师", 5, "ZXJS" },
                    { new Guid("19b2a7e9-aabd-4f8f-8d9d-5de08ab2e91d"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("a7c631a5-e308-42b3-9472-97140b783e6d"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("80b25d97-2e02-4c7a-8f23-c7cf496037df"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("a2505535-f75a-48cc-9d25-076400111441"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("96e0f964-0861-453f-94f8-e48efbad732f"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("2b5b9b5a-5748-417f-a5db-e3217cb64fea"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("ef1df2b7-f9dc-4ae9-87c7-daa2113b8a48"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("fb66f9c4-35ae-4408-8bc8-189abacc26d1"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("23c98c0f-a6a1-4f7b-89e3-c2ec3c242a4b"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("4a9aa7fe-1ec1-49c7-9682-c483a2366d69"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("8bf4450e-107e-4893-869c-17940436f60b"), "借出人员", 10, "JCRY" },
                    { new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"), "试用人员", 16, "SYRY" },
                    { new Guid("4a8f584c-7be1-46cd-885f-4abd41f95732"), "内部退养", 15, "NBTY" },
                    { new Guid("3442e56b-a348-468d-9bce-82d3288c8351"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("8e086618-e889-4b39-9ef9-098b18aaa572"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("4a93a926-639c-4b0c-a4ad-a5d09399a856"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("e068a839-f8c6-4962-a1ec-c58eac9ea4db"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("069c64bc-5f51-41f5-a179-a3a962ba4696"), "实习进修", 9, "SXJX" },
                    { new Guid("6013b422-70d0-4a2b-9e82-c11586ad91d7"), "人事代理", 2, "RSDL" },
                    { new Guid("a6eaaf89-2f3a-4769-83f7-201f7e1bae1b"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("fc8a773c-43f2-4550-8f20-c838b7dd885c"), "返聘人员", 6, "FPRY" },
                    { new Guid("4b4201f4-c153-43ce-9c66-f794b61c9269"), "辞职人员", 5, "CZRY" },
                    { new Guid("da23319b-0599-4047-8d80-482ac0322b85"), "离退人员", 4, "LTRY" },
                    { new Guid("b032326b-d74e-4110-a11b-6ffa4615c176"), "临时人员", 3, "LSRY" },
                    { new Guid("2db865be-6fc2-4344-99cf-30534802f170"), "在编人员", 1, "ZBRY" },
                    { new Guid("618d9c01-6d8d-40dc-967e-fbcc5d3259d0"), "除名人员", 8, "CMRY" }
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
                    { new Guid("ee1acec5-5b8c-471d-8e4c-1797963916e7"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("59393e25-fe3d-453d-9622-d5d705c9fa74"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("91e11499-5250-4bf1-bf24-988f2e223c4c"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("32a5a6b9-584c-4b2b-8c3f-105c653f5270"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c230efa5-8c4a-44ad-a615-3b1727de19a5"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("7a2ec004-23f3-4123-abd8-831ada164952"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d14d09f9-acc3-4f70-aa34-7379565c13a2"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("4f0e992c-b892-424e-a877-0674cad71fa6"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("00a15d5b-bddd-40e2-8aa5-70b81ff3928e"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("8adaf683-4cf9-4a95-8dba-8634025ef9ce"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("4b4e962c-0526-4a20-9ca9-93171b5715ba"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e27a4041-6227-4855-a6d6-caf3e2b13b35"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e262551c-8165-4fff-83f6-127e0040ee1a"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("2ae101cc-4bec-4280-9181-978316e67c5f"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("6b629ee5-d216-448a-9105-01ffac4432f3"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("a10b7876-e124-4a14-a90b-89639b526e3f"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("62c7eb06-8777-4d1c-9ce1-fd398319d4ac"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("61d7e0cd-64a6-4c44-b5c2-181bdd959e6f"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("40eae5b7-5c3f-47c5-a09b-9f71e769a970"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("4e3829f6-bb73-4c4c-9e5a-08e771953dd8"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("75bbcc1d-8a84-4260-9371-a958bf33aa17"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("46671bea-8417-4981-bac2-b81ced5bd8a8"), "Index", "ComMarriage", "婚姻状况", 13, "HYZK", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("d678a468-0582-4362-a5cc-acf9988168c3"), "Index", "ComDegree", "学位", 12, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("d8759034-211a-4b4b-9161-da7286716550"), "Index", "ComEducation", "学历", 11, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("a86cc36a-a851-4234-bc8d-6531fc6ffb75"), "Index", "SysEmpType", "人员类别", 10, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("2e4f408f-3760-4529-9e32-05e1bc061493"), "Index", "ComAdminDuty", "行政职务", 9, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("93943266-8562-43e4-a3b0-3d21763b805a"), "Index", "ComProfessionTitle", "职称", 8, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("9fe533d0-5c2f-4487-9377-d7f6eec54b10"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("76d6d639-ad17-475e-837a-8dcaee0e2e9f"), "Index", "ComProfessionTitleType", "职称系列", 6, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0f43f0a8-e6e8-4185-95ab-eb5654fa649e"), "Index", "ComPolitical", "政治面貌", 5, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0e7f78fd-0db7-4326-9c08-dd34f9337b07"), "Index", "ComNation", "民族", 4, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("b0ed1bce-a2bb-4ae5-87b0-2974d74827ea"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("baefe4fd-ce7c-4374-b855-d3a93218706f"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ce67b524-3f64-4bfc-9b62-a28cc4fbc787"), "Index", "SysDept", "科室信息", 14, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("181700bc-bcf3-4082-824a-c549ea404ea1"), "Index", "ComProfessionTitleLevel", "职称级别", 7, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("015bea5f-35c3-4d5e-b1bd-d703c822607b"), "Index", "SysEmp", "人员管理", 15, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
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
