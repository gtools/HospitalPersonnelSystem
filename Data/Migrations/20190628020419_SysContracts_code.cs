using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Migrations
{
    public partial class SysContracts_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SysContract",
                table: "SysContract");

            migrationBuilder.AlterColumn<Guid>(
                name: "Code",
                table: "SysProfessionInfo",
                nullable: false,
                defaultValueSql: "newsequentialid()",
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SysEducation",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<string>(
                name: "CreateEmp",
                table: "SysEducation",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Code",
                table: "SysContract",
                nullable: false,
                defaultValueSql: "newsequentialid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysContract",
                table: "SysContract",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_SysContract_EmpCode",
                table: "SysContract",
                column: "EmpCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SysContract",
                table: "SysContract");

            migrationBuilder.DropIndex(
                name: "IX_SysContract_EmpCode",
                table: "SysContract");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SysEducation");

            migrationBuilder.DropColumn(
                name: "CreateEmp",
                table: "SysEducation");

            migrationBuilder.AlterColumn<Guid>(
                name: "Code",
                table: "SysProfessionInfo",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newsequentialid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Code",
                table: "SysContract",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newsequentialid()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysContract",
                table: "SysContract",
                column: "EmpCode");
        }
    }
}
