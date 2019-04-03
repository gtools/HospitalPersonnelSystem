using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class ComGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComGender",
                columns: table => new
                {
                    Code = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(nullable: false),
                    Spell = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComGender", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComGender");
        }
    }
}
