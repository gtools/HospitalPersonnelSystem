using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class sysiteminfo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SysItem",
                columns: table => new
                {
                    ItemCode = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    ItemName = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysItem", x => x.ItemCode);
                });

            migrationBuilder.CreateTable(
                name: "SysItemInfo",
                columns: table => new
                {
                    ItemKey = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    ItemValue = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: false),
                    ItemCode = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysItemInfo", x => x.ItemKey);
                    table.ForeignKey(
                        name: "FK_ItemCode_SysItem",
                        column: x => x.ItemCode,
                        principalTable: "SysItem",
                        principalColumn: "ItemCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SysItem",
                columns: new[] { "ItemCode", "ItemName", "Spell" },
                values: new object[] { new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "民族", "MZ" });

            migrationBuilder.InsertData(
                table: "SysItem",
                columns: new[] { "ItemCode", "ItemName", "Spell" },
                values: new object[] { new Guid("627ebe5d-c8d4-40a0-bd19-0d2b849a21b9"), "性别", "XB" });

            migrationBuilder.InsertData(
                table: "SysItemInfo",
                columns: new[] { "ItemKey", "ItemCode", "ItemValue", "Spell" },
                values: new object[,]
                {
                    { new Guid("9b849977-0000-0000-0000-000000000001"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "汉族", "HZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000033"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "羌族", "QZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000034"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "布朗族", "BLZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000035"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "撒拉族", "LSZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000036"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "毛难族", "MNZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000037"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "仡佬族", "QLZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000038"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "锡伯族", "XBZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000039"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "阿昌族", "ACZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000040"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "普米族", "PMZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000041"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "塔吉克族", "TJKZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000042"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "怒族", "NZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000043"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "乌孜别克族", "WZBKZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000044"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "俄罗斯族", "ELSZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000045"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "鄂温克族", "EWKZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000046"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "崩龙族", "BLZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000047"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "保安族", "BAZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000048"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "裕固族", "YGZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000049"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "京族", "JZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000050"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "塔塔尔族", "TTEZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000051"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "独龙族", "DLZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000052"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "鄂伦春族", "ELCZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000053"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "赫哲族", "HZZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000054"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "门巴族", "MBZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000055"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "珞巴族", "LBZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000056"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "基诺族", "JNZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000057"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "其他", "QT" },
                    { new Guid("9b849977-0000-0000-0000-000000000058"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "外国血统中国人士", "WGXTZGRS" },
                    { new Guid("216cb274-0000-0000-0000-000000000001"), new Guid("627ebe5d-c8d4-40a0-bd19-0d2b849a21b9"), "男", "N" },
                    { new Guid("9b849977-0000-0000-0000-000000000032"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "仫佬族", "MLZ" },
                    { new Guid("216cb274-0000-0000-0000-000000000002"), new Guid("627ebe5d-c8d4-40a0-bd19-0d2b849a21b9"), "女", "N" },
                    { new Guid("9b849977-0000-0000-0000-000000000031"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "达斡尔族", "DWEZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000029"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "柯尔克孜族", "HEKZZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000002"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "蒙古族", "MGZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000003"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "回族", "HZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000004"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "藏族", "ZZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000005"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "维吾尔族", "WWEZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000006"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "苗族", "MZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000007"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "彝族", "YZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000008"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "壮族", "ZZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000009"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "布依族", "BYZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000010"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "朝鲜族", "CXZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000011"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "满族", "MZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000012"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "侗族", "DZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000013"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "瑶族", "YZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000014"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "白族", "BZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000015"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "土家族", "TJZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000016"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "哈尼族", "HNZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000017"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "哈萨克族", "HSKZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000018"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "傣族", "TZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000019"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "黎族", "LZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000020"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "傈僳族", "LSZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000021"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "佤族", "WZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000022"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "畲族", "SZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000023"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "高山族", "GSZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000024"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "拉祜族", "LGZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000025"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "水族", "SZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000026"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "东乡族", "DXZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000027"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "纳西族", "NXZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000028"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "景颇族", "JPZ" },
                    { new Guid("9b849977-0000-0000-0000-000000000030"), new Guid("c93d568d-8c7d-424a-abfd-7faec0b12360"), "土族", "TZ" },
                    { new Guid("216cb274-0000-0000-0000-000000000003"), new Guid("627ebe5d-c8d4-40a0-bd19-0d2b849a21b9"), "未知", "WZ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysItemInfo_ItemCode",
                table: "SysItemInfo",
                column: "ItemCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysItemInfo");

            migrationBuilder.DropTable(
                name: "SysItem");
        }
    }
}
