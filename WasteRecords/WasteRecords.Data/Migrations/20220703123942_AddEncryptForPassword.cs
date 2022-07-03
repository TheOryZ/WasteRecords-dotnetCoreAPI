using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WasteRecords.Data.Migrations
{
    public partial class AddEncryptForPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "YWRtaW4xMjNKb2huRG9lMjNAYXNkYXNkQEA=");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "admin123");
        }
    }
}
