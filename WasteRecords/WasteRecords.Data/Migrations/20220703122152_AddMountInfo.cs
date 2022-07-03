using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WasteRecords.Data.Migrations
{
    public partial class AddMountInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Records");
        }
    }
}
